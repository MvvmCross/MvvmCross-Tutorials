using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Interfaces.ViewModels;

namespace Collections.Core
{
    public class App
        : MvxApplication
        , IMvxServiceProducer
    {
        public App()
        {
            var startApplicationObject = new StartApplicationObject();
            this.RegisterServiceInstance<IMvxStartNavigation>(startApplicationObject);
        }
    }
}