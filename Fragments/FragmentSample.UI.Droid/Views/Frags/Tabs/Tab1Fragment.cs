using Android.OS;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;

namespace FragmentSample.UI.Droid.Views
{
    public class Tab1Fragment : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container,
                                          Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.tabs_1, null);
        }
    }
}