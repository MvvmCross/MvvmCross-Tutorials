using System;
using Cirrious.MvvmCross.Binding.Touch;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Interfaces;
using Cirrious.MvvmCross.Platform;
using Cirrious.MvvmCross.Application;

namespace MonoTouchCellTutorial
{
	public class Setup : MvxBaseTouchBindingSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, IMvxTouchViewPresenter presenter)
			: base(applicationDelegate, presenter)
		{
		}

		#region Overrides of MvxBaseSetup
		
		protected override MvxApplication CreateApp()
		{
			var app = new Core.App();
			return app;
		}
		
		protected override void AddPluginsLoaders(MvxLoaderPluginRegistry registry)
		{
			registry.AddConventionalPlugin<Cirrious.MvvmCross.Plugins.DownloadCache.Touch.Plugin>();
			registry.AddConventionalPlugin<Cirrious.MvvmCross.Plugins.File.Touch.Plugin>();
			base.AddPluginsLoaders(registry);
		}
		
		#endregion	
	}
}

