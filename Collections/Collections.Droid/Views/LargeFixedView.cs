using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Collections.Core.ViewModels.Samples.LargeFixed;

namespace Collections.Droid.Views
{
    [Activity(Label = "Large Fixed", ScreenOrientation = ScreenOrientation.Portrait)]
    public class LargeFixedView : MvxBindingActivityView<LargeFixedViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_FixedView);
        }
    }
}