using Android.App;
using Cirrious.CrossCore.Droid.Platform;

namespace CrossLight.Framework
{
    public interface ITopActivity
        : IMvxAndroidCurrentTopActivity
    {
        new Activity Activity { get; set; }        
    }
}