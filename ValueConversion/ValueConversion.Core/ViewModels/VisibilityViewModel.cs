using Cirrious.MvvmCross.ViewModels;

namespace ValueConversion.Core.ViewModels
{
    public class VisibilityViewModel : MvxViewModel
    {
        public VisibilityViewModel()
        {
            _makeItVisible = true;
        }

        private bool _makeItVisible;
        public bool MakeItVisible
        {
            get { return _makeItVisible; }
            set { _makeItVisible = value; RaisePropertyChanged(() => MakeItVisible); }
        }
    }
}