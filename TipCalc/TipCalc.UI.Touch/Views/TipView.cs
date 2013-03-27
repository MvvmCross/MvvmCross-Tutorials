using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TipCalc.Core;
using TipCalc.Core.ViewModels;

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
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			this.CreateBinding (this.TipLabel).To ( (TipViewModel vm) => vm.Tip ).Apply(); 
			this.CreateBinding (this.SubTotalTextField).To ( (TipViewModel vm) => vm.SubTotal ).Apply();
			this.CreateBinding (this.GenerositySlider).To ( (TipViewModel vm) => vm.Generosity ).Apply();
		
			View.AddGestureRecognizer(new UITapGestureRecognizer(() => {
				this.SubTotalTextField.ResignFirstResponder();
			}));
		}
	}
}

