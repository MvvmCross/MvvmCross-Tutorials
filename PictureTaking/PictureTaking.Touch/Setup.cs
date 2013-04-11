using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;

namespace PictureTaking.Touch
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, IMvxTouchViewPresenter presenter)
			: base(applicationDelegate, presenter)
		{
		}

		protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp ()
		{
			return new PictureTaking.Core.App();
		}
	}

	public class LinkerPleaseInclude
	{
		public void Stuff()
		{
			UIButton u = null;
			u.TouchUpInside += (object sender, System.EventArgs e) => {};

			UIImageView i = null;
			i.Image = null;
		}
	}
}