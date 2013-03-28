
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ValueConversion.Core.ViewModels;

namespace ValueConversion.UI.Touch
{
	public partial class ColorsView : MvxViewController
	{
		public ColorsView () : base ("ColorsView", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			this.CreateBinding(this.RedSlider).To<ColorsViewModel>(vm => vm.Red).Apply();
			this.CreateBinding(this.GreenSlider).To<ColorsViewModel>(vm => vm.Green).Apply();
			this.CreateBinding(this.BlueSlider).To<ColorsViewModel>(vm => vm.Blue).Apply();
			this.CreateBinding(this.ColorView).For(v => v.BackgroundColor).To<ColorsViewModel>(vm => vm.Color)
				.WithConversion("NativeColor").Apply();
			this.CreateBinding(this.ColorLabel).For (v => v.TextColor).To<ColorsViewModel>(vm => vm.Color)
				.WithConversion("ContrastColor").Apply();
			this.CreateBinding(this.ColorLabel).For (v => v.Text).To<ColorsViewModel>(vm => vm.Color)
				.Apply();
		}
	}
}

