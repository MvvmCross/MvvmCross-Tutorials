using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using ValueConversion.Core;
using Cirrious.MvvmCross.Plugins.Visibility;
using Cirrious.MvvmCross.Plugins.Color;

namespace ValueConversion.UI.Touch
{
	public class Setup : MvxTouchSetup
	{
		public Setup (MvxApplicationDelegate dele, IMvxTouchViewPresenter presenter)
			: base(dele, presenter)
		{				
		}

		protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp ()
		{
			return new App();
		}

		protected override List<System.Reflection.Assembly> ValueConverterAssemblies {
			get {
				var toReturn = base.ValueConverterAssemblies;
				toReturn.Add(typeof(MvxNativeColorConverter).Assembly);
				toReturn.Add(typeof(MvxVisibilityConverter).Assembly);
				return toReturn;
			}
		}

		protected override void AddPluginsLoaders (Cirrious.CrossCore.Plugins.MvxLoaderPluginRegistry loaders)
		{
			base.AddPluginsLoaders (loaders);
			loaders.AddConventionalPlugin<Cirrious.MvvmCross.Plugins.Color.Touch.Plugin>();
			loaders.AddConventionalPlugin<Cirrious.MvvmCross.Plugins.Visibility.Touch.Plugin>();
		}

		public override void LoadPlugins (Cirrious.CrossCore.Plugins.IMvxPluginManager pluginManager)
		{
			pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Color.PluginLoader>();
			pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Visibility.PluginLoader>();
			base.LoadPlugins (pluginManager);
		}
	}

	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	
}
