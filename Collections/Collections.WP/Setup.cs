using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.WindowsPhone.Platform;
using Microsoft.Phone.Controls;

namespace Collections.WP
{
    public class Setup
        : MvxBaseWindowsPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame)
            : base(rootFrame)
        {
        }

        protected override void InitializeDefaultTextSerializer()
        {
            Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded(true);
        }

        protected override MvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}