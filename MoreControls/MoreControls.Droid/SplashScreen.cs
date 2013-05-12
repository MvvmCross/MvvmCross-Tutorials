using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace MoreControls.Droid
{
    [Activity(Label = "MoreControls.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}