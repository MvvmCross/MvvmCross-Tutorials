using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;

namespace TipCalc.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterSingleton<ICalculation>(new Calculation());
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
        }
    }
}