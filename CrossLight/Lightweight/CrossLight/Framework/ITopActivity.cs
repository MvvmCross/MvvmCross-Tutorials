using Android.App;
using Cirrious.CrossCore.Droid.Interfaces;

namespace CrossLight.Framework
{
    public interface ITopActivity
        : IMvxAndroidCurrentTopActivity
    {
        new Activity Activity { get; set; }        
    }
}