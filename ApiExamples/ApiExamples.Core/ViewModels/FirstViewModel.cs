using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;

namespace ApiExamples.Core.ViewModels
{
    public interface IAllTestsService
    {
        Type NextViewModelType(TestViewModel currentViewModel);
        IList<Type> All { get; }
    }
    public class AllTestsService
        : IAllTestsService
    {
        public AllTestsService()
        {
            All = GetType().Assembly.CreatableTypes()
                           .Where(t => typeof (TestViewModel).IsAssignableFrom(t))
                           .ToList();
        }

        public Type NextViewModelType(TestViewModel currentViewModel)
        {
            var index = All.IndexOf(currentViewModel.GetType());
            var nextIndex = index + 1;
            if (nextIndex < All.Count)
                return All[nextIndex];

            return null;
        }

        public IList<Type> All { get; private set; }
    }

    public class FirstViewModel 
		: MvxViewModel
    {
        public FirstViewModel(IAllTestsService service)
        {
            Tests = service.All;
        }

        private IList<Type> _tests;
        public IList<Type> Tests
        {
            get { return _tests; }
            set { _tests = value; RaisePropertyChanged(() => Tests); }
        }
        
        public ICommand GotoTestCommand
        {
            get { return new MvxCommand<Type>(type => ShowViewModel(type)); }
        }
    }

    public abstract class TestViewModel
        : MvxViewModel
    {
        public ICommand NextCommand
        {
            get
            {
                return new MvxCommand(() =>
                    {
                        var all = Mvx.Resolve<IAllTestsService>();
                        var next = all.NextViewModelType(this);
                        if (next == null)
                            Close(this);
                        else
                            ShowViewModel(next);
                    });
            }
        }
    }

    public class DateTimeViewModel
        : TestViewModel
    {
        private DateTime _property = DateTime.Now;
        public DateTime Property
        {
            get { return _property; }
            set { _property = value; RaisePropertyChanged(() => Property); }
        }
    }

    public class TimeViewModel
        : TestViewModel
    {
        private TimeSpan _property = DateTime.Now.TimeOfDay;
        public TimeSpan Property
        {
            get { return _property; }
            set { _property = value; RaisePropertyChanged(() => Property); }
        }
    }
}
