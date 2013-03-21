// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace TipCalc.UI.Touch
{
	[Register ("TipView")]
	partial class TipView
	{
		[Outlet]
		MonoTouch.UIKit.UITextField SubTotalTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider GenerositySlider { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TipLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SubTotalTextField != null) {
				SubTotalTextField.Dispose ();
				SubTotalTextField = null;
			}

			if (GenerositySlider != null) {
				GenerositySlider.Dispose ();
				GenerositySlider = null;
			}

			if (TipLabel != null) {
				TipLabel.Dispose ();
				TipLabel = null;
			}
		}
	}
}
