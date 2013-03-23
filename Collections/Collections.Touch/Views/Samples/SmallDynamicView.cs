using System;
using Collections.Core.ViewModels;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.Binding.Touch.Views;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Collections.Core.ViewModels.Samples.SmallFixed;
using Collections.Core.ViewModels.Samples.LargeFixed;
using Collections.Core.ViewModels.Samples.LargeDynamic;
using Collections.Core.ViewModels.Samples.SmallDynamic;

namespace Collections.Touch
{
	public class SmallDynamicView : BaseDynamicKittenTableView
	{
		public new SmallDynamicViewModel ViewModel
		{
			get { return (SmallDynamicViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public SmallDynamicView ()
		{
			Title = "Small Dynamic";
		}

		protected override void AddKittensPressed ()
		{
			ViewModel.AddKittenCommand.Execute(null);
		}
		
		protected override void KillKittensPressed ()
		{
			ViewModel.KillKittensCommand.Execute(null);
		}
	}
}
