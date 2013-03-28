
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ValueConversion.Core.ViewModels;

namespace ValueConversion.UI.Touch
{
	public partial class TwoWayView : MvxViewController
	{
		public TwoWayView () : base ("TwoWayView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			this.CreateBinding(this.TheLabel)
				.To<TwoWayViewModel>(vm => vm.TheValue)
				.Apply();
			this.CreateBinding(this.TheTextField)
				.To<TwoWayViewModel>(vm => vm.TheValue)
				.WithConversion("TwoWay")
				.Apply();
		
			this.View.AddGestureRecognizer(new UITapGestureRecognizer(() => {
				TheTextField.ResignFirstResponder();
			}));
		}
	}
}

