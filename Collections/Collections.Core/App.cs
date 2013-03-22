using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using Collections.Core.ViewModels;

namespace Collections.Core
{
    public class App
        : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainMenuViewModel>());
        }
    }
}