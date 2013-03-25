
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Navigation.Core.ViewModels;

namespace Navigation.UI.Touch
{
	public partial class MainView : MvxViewController
	{
		public MainView () : base ("MainView", null)
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
			
			this.Bind ( this.KeyTextField, (MainViewModel vm) => vm.ParameterKey);
			this.Bind ( this.AnonButton, (MainViewModel vm) => vm.GoAnonymousCommand);
			this.Bind ( this.ParamsButton, (MainViewModel vm) => vm.GoParameterizedCommand);
			this.Bind ( this.SimpleButton, (MainViewModel vm) => vm.GoSimpleCommand);

			this.View.AddGestureRecognizer( new UITapGestureRecognizer(() => {
				this.KeyTextField.ResignFirstResponder();
			}));
		}
	}
}

