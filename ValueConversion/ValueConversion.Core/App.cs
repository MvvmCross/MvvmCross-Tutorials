using System.Linq;
using System.Text;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using ValueConversion.Core.ViewModels;

namespace ValueConversion.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<HomeViewModel>());    
        }
    }
}
