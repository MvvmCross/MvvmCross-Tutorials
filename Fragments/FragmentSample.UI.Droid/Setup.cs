using Android.Content;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using FragmentSample.Core;

namespace FragmentSample.UI.Droid
{
    public class Setup
        : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxNavigationSerializer CreateNavigationSerializer()
        {
            return new MvxJsonNavigationSerializer();
        }

        public override void LoadPlugins(Cirrious.CrossCore.Plugins.IMvxPluginManager pluginManager)
        {
            pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.File.PluginLoader>();
            pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Json.PluginLoader>();
            pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.DownloadCache.PluginLoader>();
            base.LoadPlugins(pluginManager);
        }
    }
}