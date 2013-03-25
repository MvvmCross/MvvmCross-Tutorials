using Cirrious.MvvmCross.ViewModels;

namespace ValueConversion.Core.ViewModels
{
    public class TwoWayViewModel : MvxViewModel
    {
        public TwoWayViewModel()
        {
            _amount = 42;
        }

        private double _amount;
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; RaisePropertyChanged(() => Amount); }
        }
    }
}