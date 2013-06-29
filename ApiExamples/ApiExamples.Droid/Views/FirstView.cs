using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace ApiExamples.Droid.Views
{
    [Activity(Label = "Api examples")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }

    [Activity(NoHistory = true)]
    public class DateTimeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
           {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Date);
        }
    }

    [Activity(NoHistory = true)]
    public class TimeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Time);
        }
    }

    [Activity(NoHistory = true)]
    public class SpinnerView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Spinner);
        }
    }

    [Activity(NoHistory = true)]
    public class ListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_List);
        }
    }

    [Activity(NoHistory = true)]
    public class LinearLayoutView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_LinearLayout);
        }
    }

    [Activity(NoHistory = true)]
    public class FrameView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Frame);
        }
    }

    [Activity(NoHistory = true)]
    public class RelativeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Relative);
        }
    }

    [Activity(NoHistory = true)]
    public class TextView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Text);
        }
    }

    [Activity(NoHistory = true)]
    public class SeekView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Seek);
        }
    }

    [Activity(NoHistory = true)]
    public class ContainsSubView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_ContainsSub);
        }
    }

    [Activity(NoHistory = true)]
    public class ConvertThisView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_ConvertThis);
        }
    }
}