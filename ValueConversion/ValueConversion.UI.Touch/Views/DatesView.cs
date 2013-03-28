
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ValueConversion.Core.ViewModels;

namespace ValueConversion.UI.Touch
{
	public partial class DatesView : MvxViewController
	{
		public DatesView () : base ("DatesView", null)
		{
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.CreateBinding(this.TheDateLabel).To<DatesViewModel>(vm => vm.TheDate).WithConversion("TimeAgo").Apply();
			this.CreateBinding(this.OldDateLabel).To<DatesViewModel>(vm => vm.OldDate).WithConversion("TimeAgo").Apply();
			this.CreateBinding(this.VeryOldDateLabel).To<DatesViewModel>(vm => vm.VeryOldDate).WithConversion("TimeAgo").Apply();

			this.CreateBinding(this.SimpleDateLabel).To<DatesViewModel>(vm => vm.TheDate).Apply();
			this.CreateBinding(this.SimpleOldDateLabel).To<DatesViewModel>(vm => vm.OldDate).Apply();
			this.CreateBinding(this.SimpleVeryOldDateLabel).To<DatesViewModel>(vm => vm.VeryOldDate).Apply();
		}
	}
}

