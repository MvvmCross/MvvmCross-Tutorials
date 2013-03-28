
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ValueConversion.Core.ViewModels;

namespace ValueConversion.UI.Touch
{
	public partial class VisibilityView : MvxViewController
	{
		public VisibilityView () : base ("VisibilityView", null)
		{
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.CreateBinding(this.TheThing).For("Visibility")
				.To<VisibilityViewModel>(vm => vm.MakeItVisible)
				.WithConversion("Visibility").Apply();
			this.CreateBinding(this.ShowSwitch).To<VisibilityViewModel>(vm => vm.MakeItVisible)
				.Apply();
		}
	}
}

