using System;
using MonoTouch.UIKit;
using Collections.Core.ViewModels.Samples.SmallFixed;
using Collections.Core.ViewModels.Samples.LargeFixed;
using Collections.Core.ViewModels.Samples.LargeDynamic;
using Collections.Core.ViewModels.Samples.SmallDynamic;

namespace Collections.Touch
{
	public class LargeDynamicView : BaseDynamicKittenTableView
	{
		public new LargeDynamicViewModel ViewModel
		{
			get { return (LargeDynamicViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public LargeDynamicView ()
		{
			Title = "Large Dynamic";
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
