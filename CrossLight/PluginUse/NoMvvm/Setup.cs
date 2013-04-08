using Android.Content;
using Cirrious.CrossCore.Interfaces.Platform.Diagnostics;
using Cirrious.CrossCore.Interfaces.Plugins;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.Platform.Diagnostics;
using Cirrious.CrossCore.Plugins;
using Cirrious.CrossCore.Droid.Interfaces;

namespace NoMvvm
{
    public class Setup
    {
        public static readonly Setup Instance = new Setup();

        private Setup()
        {            
        }

        public void EnsureInitialized(Context applicationContext)
        {
            if (MvxSimpleIoCContainer.Instance != null)
                return;

            var ioc = MvxSimpleIoCContainer.Initialise();

            ioc.RegisterSingleton<IMvxTrace>(new MvxDebugOnlyTrace());
            ioc.RegisterSingleton<IMvxPluginManager>(new MvxFileBasedPluginManager("Droid"));
	
			ioc.RegisterSingleton<IMvxAndroidGlobals>(new AndroidGlobals(applicationContext, GetType().Namespace));
		}
    }
}