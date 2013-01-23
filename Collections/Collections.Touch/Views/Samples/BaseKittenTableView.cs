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
	public class BaseKittenTableView<TViewModel> 
		: MvxBindingTouchTableViewController<TViewModel>
		where TViewModel : class, IMvxViewModel
	{
		public BaseKittenTableView (MvxShowViewModelRequest request)
			: base(request)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var source = new TableSource(TableView);
			this.AddBindings(new Dictionary<object, string>()
			    {
					{source, "{'ItemsSource':{'Path':'Kittens'}}" }
				});

			TableView.Source = source;
			TableView.ReloadData();
		}

		public class TableSource : MvxSimpleBindableTableViewSource
		{
			private static readonly NSString KittenCellIdentifier = new NSString("KittenCell");

			public TableSource (UITableView tableView)
				: base(tableView)
			{
				tableView.RegisterNibForCellReuse(UINib.FromName("KittenCell", NSBundle.MainBundle), KittenCellIdentifier);
			}

			public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
			{
				return KittenCell.GetCellHeight();
			}

			protected override NSString CellIdentifier {
				get {
					return KittenCellIdentifier;
				}
			}
		}
	}

}

