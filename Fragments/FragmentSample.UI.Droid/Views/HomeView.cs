using System;
using Android.App;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Fragging;
using FragmentSample.Core.ViewModels;

namespace FragmentSample.UI.Droid.Views
{
    [Activity]
    public class HomeView
        : MvxFragmentActivity
    {
        public HomeViewModel HomeViewModel
        {
            get { return (HomeViewModel)base.ViewModel; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_HomeView);
            var dialog = FindViewById<Button>(Resource.Id.DialogButton);
            dialog.Click += DialogOnClick;
        }

        private void DialogOnClick(object sender, EventArgs eventArgs)
        {
            var dialog = new NameDialogFragment(this);
            dialog.ViewModel = HomeViewModel.Names;
            dialog.Show(SupportFragmentManager, "A Name Dialog");                                     
        }
    }
}