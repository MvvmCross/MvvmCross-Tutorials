using Cirrious.MvvmCross.ViewModels;

namespace Navigation.Core.ViewModels
{
    public class AnonymousViewModel : MvxViewModel
    {
        private string _key;

        public void Init(string key)
        {
            Key = key;
        }

        public string Key
        {
            get { return _key; }
            set { _key = value; RaisePropertyChanged(() => Key); }
        }
    }
}