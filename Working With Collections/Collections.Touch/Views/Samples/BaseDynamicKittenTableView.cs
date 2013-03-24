using System;
using Collections.Core.ViewModels;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.Binding.Touch.ExtensionMethods;
using Cirrious.MvvmCross.Binding.Touch.Views;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Collections.Core.ViewModels.Samples.SmallFixed;
using Cirrious.MvvmCross.Interfaces.ViewModels;

namespace Collections.Touch
{
	public abstract class BaseDynamicKittenTableView<TViewModel>
		: BaseKittenTableView<TViewModel> 
			where TViewModel : class, IMvxViewModel		
	{
		public BaseDynamicKittenTableView (MvxShowViewModelRequest request)
			: base(request)
		{
		}

		private UIBarButtonItem _rightButton;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_rightButton = new UIBarButtonItem(UIBarButtonSystemItem.Action);
			_rightButton.Clicked += HandleRightButtonClicked;
			NavigationItem.RightBarButtonItem = _rightButton;
		}

		void HandleRightButtonClicked(object sender, EventArgs e)
		{
			var sheet = new UIActionSheet("Actions");
			sheet.AddButton("Add");
			sheet.AddButton("Kill");
			sheet.Clicked += HandleActionSheetButtonClicked;
			sheet.ShowFrom(_rightButton, true);
		}

		void HandleActionSheetButtonClicked (object sender, UIButtonEventArgs e)
		{
			switch (e.ButtonIndex) {
			case 0:
				AddKittensPressed();
				break;
			case 1:
				KillKittensPressed();
				break;
			}
		}

		protected abstract void AddKittensPressed();
		protected abstract void KillKittensPressed();
	}	
}
