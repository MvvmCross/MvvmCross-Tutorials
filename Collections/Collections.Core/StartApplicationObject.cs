using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.ViewModels;
using Collections.Core.ViewModels;

namespace Collections.Core
{
    public class StartApplicationObject
        : MvxApplicationObject
        , IMvxStartNavigation
    {
        public void Start()
        {
            RequestNavigate<MainMenuViewModel>();
        }

        public bool ApplicationCanOpenBookmarks
        {
            get { return false; }
        }
    }
}