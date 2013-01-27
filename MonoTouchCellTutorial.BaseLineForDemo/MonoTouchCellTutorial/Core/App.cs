using System;
using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;

using MonoTouchCellTutorial.Core.Interfaces;
using MonoTouchCellTutorial.Core.Services;

namespace MonoTouchCellTutorial.Core
{
	public class App 
		: MvxApplication
		, IMvxServiceProducer
	{
		public App ()
		{
			RegisterServices();
		}

		private void RegisterServices()
		{
			this.RegisterServiceInstance<IPricingModel>(new PricingModel());
			this.RegisterServiceInstance<IAnimalSupplier>(new AnimalSupplier());
		}
	}
}

