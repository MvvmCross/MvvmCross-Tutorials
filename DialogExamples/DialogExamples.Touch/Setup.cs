using MvvmCross.Dialog.iOS;
using UIKit;
using MvvmCross.Platform.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;

namespace DialogExamples.iOS
{
	public class Setup : MvxIosDialogSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp ()
		{
			return new Core.App();
		}
	}
}