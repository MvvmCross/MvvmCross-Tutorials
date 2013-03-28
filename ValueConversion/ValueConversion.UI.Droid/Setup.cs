using System.Collections.Generic;
using System.Reflection;
using Android.Content;
using Cirrious.CrossCore.Plugins;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.Plugins.Color;
using Cirrious.MvvmCross.Plugins.Visibility;
using Cirrious.MvvmCross.ViewModels;
using ValueConversion.Core;
using PluginLoader = Cirrious.MvvmCross.Plugins.Color.PluginLoader;

namespace ValueConversion.UI.Droid
{
    public class Setup
        : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override List<Assembly> ValueConverterAssemblies
        {
            get
            {
                var toReturn = base.ValueConverterAssemblies;
                toReturn.Add(typeof (MvxNativeColorValueConverter).Assembly);
                toReturn.Add(typeof (MvxVisibilityValueConverter).Assembly);
                return toReturn;
            }
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxNavigationSerializer CreateNavigationSerializer()
        {
            return new MvxJsonNavigationSerializer();
        }

        public override void LoadPlugins(IMvxPluginManager pluginManager)
        {
            pluginManager.EnsurePluginLoaded<PluginLoader>();
            pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Json.PluginLoader>();
            pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Visibility.PluginLoader>();
            base.LoadPlugins(pluginManager);
        }
    }
}