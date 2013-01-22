using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Collections.Core.ViewModels.Samples.SmallFixed;
using Collections.Core.ViewModels.Samples.SpecificPositions;

namespace Collections.Droid.Views
{
    [Activity(Label = "Specific Positions", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SpecificPositionsView : MvxBindingActivityView<SpecificPositionsViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_SpecificPositions);
        }
    }
}