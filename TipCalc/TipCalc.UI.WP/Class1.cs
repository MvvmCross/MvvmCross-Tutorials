using Cirrious.MvvmCross.ViewModels;
using Microsoft.Phone.Controls;
using Cirrious.MvvmCross.WindowsPhone.Platform;

namespace TipCalc.UI.WP
{
    public class Setup : MvxPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame)
            : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxNavigationSerializer CreateNavigationSerializer()
        {
            Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded(true);
            return new MvxJsonNavigationSerializer();
        }
    }
}
