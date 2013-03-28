using Cirrious.MvvmCross.ViewModels;

namespace ValueConversion.Core.ViewModels
{
    public class TwoWayViewModel : MvxViewModel
    {
        public TwoWayViewModel()
        {
            _theValue = 3;
        }

        private double _theValue;
        public double TheValue
        {
            get { return _theValue; }
            set { _theValue = value; RaisePropertyChanged(() => TheValue); }
        }
    }
}