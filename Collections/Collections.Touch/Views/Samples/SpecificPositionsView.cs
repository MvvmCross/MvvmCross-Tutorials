using MonoTouch.UIKit;
using System.Collections.Generic;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Collections.Core.ViewModels.Samples.SpecificPositions;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace Collections.Touch
{
	public partial class SpecificPositionsView : MvxViewController
	{
		private MvxImageViewLoader _secondImageHelper;
		private MvxImageViewLoader _felixImageHelper;

		public new SpecificPositionsViewModel ViewModel
		{
			get { return (SpecificPositionsViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public SpecificPositionsView () 
			: base ("SpecificPositionsView", null)
		{
			Title = "Specific Positions";
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

			InitialiseImageHelpers();

			// old syntax
			//this.AddBindings(
			//	new Dictionary<object, string>()
			//	{
			//		{ this._secondImageHelper, "ImageUrl Kittens[2].ImageUrl" },
			//		{ this.SecondLabel, "Text Kittens[2].Name" },
			//		{ this._felixImageHelper, "ImageUrl Lookup[Felix].ImageUrl" },
			//		{ this.FelixLabel, "Text Lookup[Felix].Name" },
			//	});

			// alternative syntax:
			this.Bind(_secondImageHelper, (SpecificPositionsViewModel vm) => vm.Kittens[2].ImageUrl);
			this.Bind(SecondLabel, (SpecificPositionsViewModel vm) => vm.Kittens[2].Name);
			this.Bind(_felixImageHelper, (SpecificPositionsViewModel vm) => vm.Lookup["Felix"].ImageUrl);
			this.Bind(FelixLabel, (SpecificPositionsViewModel vm) => vm.Lookup["Felix"].Name);

		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		private void InitialiseImageHelpers()
		{
			_secondImageHelper = new MvxImageViewLoader(() => SecondImageView);
			_felixImageHelper = new MvxImageViewLoader(() => FelixImageView);
		}
	}
}

