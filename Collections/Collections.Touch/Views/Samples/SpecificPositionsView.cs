
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Plugins.DownloadCache;
using Cirrious.MvvmCross.Platform;
using System.Collections.Generic;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Collections.Core.ViewModels.Samples.SpecificPositions;
using Cirrious.MvvmCross.Binding.Touch.ExtensionMethods;
using Cirrious.MvvmCross.Views;

namespace Collections.Touch
{
	public partial class SpecificPositionsView : MvxBindingTouchViewController<SpecificPositionsViewModel>
	{
		private MvxDynamicImageHelper<UIImage> _secondImageHelper;
		private MvxDynamicImageHelper<UIImage> _felixImageHelper;

		public SpecificPositionsView (MvxShowViewModelRequest request) 
			: base (request, "SpecificPositionsView", null)
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

			this.AddBindings(
				new Dictionary<object, string>()
				{
					{ this._secondImageHelper, "{'ImageUrl':{'Path':'Kittens[2].ImageUrl'}}" },
					{ this.SecondLabel, "{'Text':{'Path':'Kittens[2].Name'}}" },
					{ this._felixImageHelper, "{'ImageUrl':{'Path':'Lookup[\"Felix\"].ImageUrl'}}" },
					{ this.FelixLabel, "{'Text':{'Path':'Lookup[\"Felix\"].Name'}}" },
				});
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
			_secondImageHelper = new MvxDynamicImageHelper<UIImage>();
			_secondImageHelper.ImageChanged += SecondImageHelperOnImageChanged;
			_felixImageHelper = new MvxDynamicImageHelper<UIImage>();
			_felixImageHelper.ImageChanged += FelixImageHelperOnImageChanged;
		}
		
		private void SecondImageHelperOnImageChanged(object sender, MvxValueEventArgs<UIImage> mvxValueEventArgs)
		{
			if (SecondImageView != null && mvxValueEventArgs.Value != null)
				SecondImageView.Image = mvxValueEventArgs.Value;
		}
		
		private void FelixImageHelperOnImageChanged(object sender, MvxValueEventArgs<UIImage> mvxValueEventArgs)
		{
			if (FelixImageView != null && mvxValueEventArgs.Value != null)
				FelixImageView.Image = mvxValueEventArgs.Value;
		}
	}
}

