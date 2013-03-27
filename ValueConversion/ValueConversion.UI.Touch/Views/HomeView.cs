using System;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ValueConversion.Core.ViewModels;

namespace ValueConversion.UI.Touch
{
	public class HomeView : MvxTableViewController
	{
		public HomeView ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var source = new MvxStandardTableViewSource(TableView, "TitleText Name; SelectedCommand ShowCommand");

			this.CreateBinding(source).To((HomeViewModel vm) => vm.Items).Apply();

			TableView.Source = source;
			TableView.ReloadData();

		}
	}
}

