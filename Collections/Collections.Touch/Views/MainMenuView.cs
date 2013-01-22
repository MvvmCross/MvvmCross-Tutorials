using System;
using Collections.Core.ViewModels;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.Binding.Touch.ExtensionMethods;
using Cirrious.MvvmCross.Binding.Touch.Views;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Collections.Touch
{
	public class MainMenuView : MvxBindingTouchTableViewController<MainMenuViewModel>
	{
		public MainMenuView (MvxShowViewModelRequest request)
			: base(request)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var source = new TableSource(TableView);
			this.AddBindings(new Dictionary<object, string>()
			    {
					{source, "{'ItemsSource':{'Path':'MenuItems'}}" }
				});

			TableView.Source = source;
			TableView.ReloadData();
		}

		public class TableSource : MvxSimpleBindableTableViewSource
		{
			private static readonly NSString Identifier = new NSString("MenuCellIdentifier");
			private const string BindingText = "{'TitleText':{'Path':'Title'},'SelectedCommand':{'Path':'ShowCommand'}}";

			public TableSource (UITableView tableView)
				: base(tableView, MonoTouch.UIKit.UITableViewCellStyle.Default, TableSource.Identifier, BindingText)
			{				
			}
		}
	}
}

