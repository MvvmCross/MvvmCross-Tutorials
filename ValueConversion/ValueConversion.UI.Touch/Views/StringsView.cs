
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ValueConversion.Core.ViewModels;

namespace ValueConversion.UI.Touch
{
	public partial class StringsView : MvxViewController
	{
		public StringsView () : base ("StringsView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			this.CreateBinding(this.TextEditor).To<StringsViewModel>(vm => vm.TheText).Apply();
			this.CreateBinding(this.LengthLabel).To<StringsViewModel>(vm => vm.TheText)
				.WithConversion("StringLength").Apply();
			this.CreateBinding(this.ReversedLabel).To<StringsViewModel>(vm => vm.TheText)
				.WithConversion("StringReverse").Apply();

			this.View.AddGestureRecognizer(new UITapGestureRecognizer(() => {
				TextEditor.ResignFirstResponder();
			}));
		}
	}
}

