
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
			
			this.CreateBinding ( this.KeyTextField).To( (MainViewModel vm) => vm.ParameterKey).Apply();
			this.CreateBinding ( this.AnonButton).To( (MainViewModel vm) => vm.GoAnonymousCommand).Apply();
			this.CreateBinding ( this.ParamsButton).To( (MainViewModel vm) => vm.GoParameterizedCommand).Apply();
			this.CreateBinding ( this.SimpleButton).To( (MainViewModel vm) => vm.GoSimpleCommand).Apply();

			this.View.AddGestureRecognizer( new UITapGestureRecognizer(() => {
				this.KeyTextField.ResignFirstResponder();
			}));
		}
	}
}

