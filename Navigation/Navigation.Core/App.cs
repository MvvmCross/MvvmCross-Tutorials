using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using Navigation.Core.ViewModels;

namespace Navigation.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainViewModel>());
        }
    }
}