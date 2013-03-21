
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TipCalc.Core;

namespace TipCalc.UI.Touch
{
	public partial class TipView : MvxViewController
	{
		public new TipViewModel ViewModel
		{
			get { return (TipViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public TipView () : base ("TipView", null)
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
			
			// Perform any additional setup after loading the view, typically from a nib.
			this.Bind (this.TipLabel, (TipViewModel vm) => vm.Tip ); 
			this.Bind (this.SubTotalTextField, (TipViewModel vm) => vm.SubTotal );
			this.Bind (this.GenerositySlider, (TipViewModel vm) => vm.Generosity );
		
			View.AddGestureRecognizer(new UITapGestureRecognizer(() => {
				this.SubTotalTextField.ResignFirstResponder();
			}));
		}


	}
}

