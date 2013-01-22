using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Collections.Core.ViewModels;

namespace Collections.Droid.Views
{
    [Activity(Label = "Main Menu", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainMenuView : MvxBindingActivityView<MainMenuViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_MainMenuView);
        }
    }
}