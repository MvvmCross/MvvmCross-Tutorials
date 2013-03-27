using Cirrious.MvvmCross.ViewModels;

namespace ValueConversion.Core.ViewModels
{
    public class TwoWayViewModel : MvxViewModel
    {
        public TwoWayViewModel()
        {
            _theText = "The answer is 42";
        }

        private string _theText;
        public string TheText
        {
            get { return _theText; }
            set { _theText = value; RaisePropertyChanged(() => TheText); }
        }
    }
}