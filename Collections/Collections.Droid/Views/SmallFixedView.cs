using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Collections.Core.ViewModels.Samples.SmallFixed;

namespace Collections.Droid.Views
{
    [Activity(Label = "Small Fixed", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SmallFixedView : MvxBindingActivityView<SmallFixedViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_FixedView);
        }
    }
}