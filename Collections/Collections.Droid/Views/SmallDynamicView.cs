using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Collections.Core.ViewModels.Samples.SmallDynamic;

namespace Collections.Droid.Views
{
    [Activity(Label = "Small Dynamic", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SmallDynamicView : MvxBindingActivityView<SmallDynamicViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_DynamicView);
        }
    }
}