using System;
using Collections.Core.ViewModels;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Views;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Collections.Core.ViewModels.Samples.SmallFixed;
using Collections.Core.ViewModels.Samples.LargeFixed;
using Collections.Core.ViewModels.Samples.LargeDynamic;
using Collections.Core.ViewModels.Samples.SmallDynamic;

namespace Collections.Touch
{
	public class LargeFixedView : BaseKittenTableView
	{
		public new LargeFixedViewModel ViewModel
		{
			get { return (LargeFixedViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public LargeFixedView ()
		{
			Title = "Large Fixed";
		}
	}
	
}
