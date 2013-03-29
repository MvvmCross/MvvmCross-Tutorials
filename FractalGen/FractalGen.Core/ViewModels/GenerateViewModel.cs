using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Input;
using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.ViewModels;
using FractalGen.Core.Services;

namespace FractalGen.Core.ViewModels
{
    public class LikeATask
    {
        public LikeATask(IMandelbrot mandelbrot, Action<IWriteableBitmap> callback)
        {
            Mandelbrot = mandelbrot;
            _callback = callback;
        }

        public IMandelbrot Mandelbrot { get; private set; }
        public bool CancelFlag { get; private set; }
        public bool CopyFlag { get; private set; }
        private readonly Action<IWriteableBitmap> _callback;

        public void Cancel()
        {
            CancelFlag = true;
        }

        public void Copy()
        {
            CopyFlag = true;
        }

        public void CopyComplete(IWriteableBitmap bitmap)
        {
            CopyFlag = false;
            if (CancelFlag)
                return;
            _callback(bitmap);
        }

        public void ProcessAsync()
        {
            ThreadPool.QueueUserWorkItem(ignored => ProcessMandelbrot(this));
        }

        private void ProcessMandelbrot(LikeATask task)
        {
            for (int i = 0; i < 20; i++)
            {
                if (task.Mandelbrot.IsScaleComplete)
                {
                    var final = task.Mandelbrot.Bitmap.Clone();
                    task.CopyComplete(final);
                    return;
                }

                if (task.CancelFlag)
                    return;

                if (task.CopyFlag)
                {
                    var bitmap = task.Mandelbrot.Bitmap.Clone();
                    task.CopyComplete(bitmap);
                }

                task.Mandelbrot.NextLine();
            }

            ProcessAsync();
        }
    }

    public class GenerateViewModel : MvxViewModel
    {
        public const int NumberInList = 1;

        private readonly MvxSubscriptionToken _mvxSubscriptionToken;
        private readonly IMandelbrotGenerator _mandelbrotGenerator;
        private readonly IDisplayDimensionsService _displayDimensionsService;
        private List<LikeATask> _currentTasks;


        public GenerateViewModel(IMvxMessenger messenger, IMandelbrotGenerator mandelbrotGenerator, IDisplayDimensionsService displayDimensionsService)
        {
            _displayDimensionsService = displayDimensionsService;
            _mandelbrotGenerator = mandelbrotGenerator;
            _mvxSubscriptionToken = messenger.Subscribe<TickMessage>(OnTick);
            Bitmaps = new ObservableCollection<IWriteableBitmap>();
            _currentTasks = new List<LikeATask>();
            DoStartAll();
        }

        private ObservableCollection<IWriteableBitmap> _bitmaps;
        public ObservableCollection<IWriteableBitmap> Bitmaps
        {
            get { return _bitmaps; }
            set { _bitmaps = value; RaisePropertyChanged(() => Bitmaps); }
        }

        public ICommand RestartCommand
        {
            get
            {
                return new MvxCommand(DoStartAll);
            }
        }

        private void DoStartAll()
        {
            if (_currentTasks != null)
            {
                foreach (var task in _currentTasks)
                    task.Cancel();
                _currentTasks.Clear();
            }
            for (var i = 0; i < NumberInList; i++)
                StartNewMandelbrot(i);
        }

        private void StartNewMandelbrot(int index)
        {
            while (Bitmaps.Count <= index)
                Bitmaps.Add(null);

            var currentMandelbrot = _mandelbrotGenerator.Generate(_displayDimensionsService.Width,
                                                               _displayDimensionsService.Height);
            var newTask = new LikeATask(currentMandelbrot, (bitmap) => InvokeOnMainThread(() => Bitmaps[index] = bitmap));
            _currentTasks.Add(newTask);
            newTask.ProcessAsync();
        }

        private void OnTick(TickMessage obj)
        {
            InvokeOnMainThread(() =>
                {
                    if (_currentTasks != null)
                    {
                        foreach (var task in _currentTasks)
                            task.Copy();
                    }
                });
        }
    }
}
