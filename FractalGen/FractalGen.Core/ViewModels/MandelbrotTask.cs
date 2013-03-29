using System;
using System.Threading;
using FractalGen.Core.Services;

namespace FractalGen.Core.ViewModels
{
    public interface IMandelbrotTaskGenerator
    {
        IMandelbrotTask Generate(int width, int height, Action<ISimpleWriteableBitmap> copyOutAction);
    }

    public class MandelbrotTaskGenerator : IMandelbrotTaskGenerator
    {
        private readonly IMandelbrotGenerator _mandelbrotGenerator;

        public MandelbrotTaskGenerator(IMandelbrotGenerator mandelbrotGenerator)
        {
            _mandelbrotGenerator = mandelbrotGenerator;
        }

        public IMandelbrotTask Generate(int width, int height, Action<ISimpleWriteableBitmap> copyOutAction)
        {
            var currentMandelbrot = _mandelbrotGenerator.Generate(width, height);
            return new MandelbrotTask(currentMandelbrot, copyOutAction);
        }
    }

    public interface IMandelbrotTask
    {
        IMandelbrot Mandelbrot { get; }
        bool CancelFlag { get; }
        bool CopyFlag { get; }
        void Cancel();
        void RequestCopy();
        void CopyComplete(ISimpleWriteableBitmap bitmap);
        void ProcessAsync();
    }

    public class MandelbrotTask : IMandelbrotTask
    {
        private readonly Action<ISimpleWriteableBitmap> _callback;

        public MandelbrotTask(IMandelbrot mandelbrot, Action<ISimpleWriteableBitmap> callback)
        {
            Mandelbrot = mandelbrot;
            _callback = callback;
        }

        public IMandelbrot Mandelbrot { get; private set; }
        public bool CancelFlag { get; private set; }
        public bool CopyFlag { get; private set; }

        public void Cancel()
        {
            CancelFlag = true;
        }

        public void RequestCopy()
        {
            CopyFlag = true;
        }

        public void CopyComplete(ISimpleWriteableBitmap bitmap)
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

        private void ProcessMandelbrot(MandelbrotTask task)
        {
            // work in chunks of 20 - why 20? No good reason - sorry.
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
}