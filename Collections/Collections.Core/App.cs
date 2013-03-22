using Cirrious.MvvmCross.ViewModels;

namespace Collections.Core
{
    public class App
        : MvxApplication
    {
        public App()
        {
            var startApplicationObject = new StartApplicationObject();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainMenuViewModel>());
        }
    }
}