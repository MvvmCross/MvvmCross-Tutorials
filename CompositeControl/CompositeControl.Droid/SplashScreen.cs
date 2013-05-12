using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace CompositeControl.Droid
{
    [Activity(Label = "CompositeControl.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}