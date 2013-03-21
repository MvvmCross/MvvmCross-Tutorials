using System;
using Cirrious.MvvmCross.Touch.Platform;
using TipCalc.Core;
using Cirrious.MvvmCross.Touch.Views.Presenters;

namespace TipCalc.UI.Touch
{
	public class Setup : MvxTouchSetup
	{
		public Setup (MvxApplicationDelegate appDelegate, IMvxTouchViewPresenter presenter)
			: base(appDelegate, presenter)
		{
		}

		protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp ()
		{
			return new App();
		}
	}
}

