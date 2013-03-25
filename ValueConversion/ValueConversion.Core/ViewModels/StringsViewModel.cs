using Cirrious.MvvmCross.ViewModels;

namespace ValueConversion.Core.ViewModels
{
    public class StringsViewModel : MvxViewModel
    {
        public StringsViewModel()
        {
            TheText = "Hello World";
        }

        private string _theText;
        public string TheText
        {
            get { return _theText; }
            set { _theText = value; RaisePropertyChanged(() => TheText); }
        }
    }
}