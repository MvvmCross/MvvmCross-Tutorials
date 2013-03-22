using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;
using Collections.Core.ViewModels.Samples.SmallFixed;

namespace Collections.Droid.Views
{
    [Activity(Label = "Small Fixed", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SmallFixedView : MvxActivity
    {
        public new SmallFixedViewModel ViewModel
        {
            get { return (SmallFixedViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_FixedView);
        }
    }
}