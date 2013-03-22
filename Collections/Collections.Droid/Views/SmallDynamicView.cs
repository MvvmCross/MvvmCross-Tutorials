using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;
using Collections.Core.ViewModels.Samples.SmallDynamic;

namespace Collections.Droid.Views
{
    [Activity(Label = "Small Dynamic", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SmallDynamicView : MvxActivity
    {
        public new SmallDynamicViewModel ViewModel
        {
            get { return (SmallDynamicViewModel) base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_DynamicView);
        }
    }
}