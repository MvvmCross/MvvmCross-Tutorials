using Android.App;
using Cirrious.CrossCore.Droid.Interfaces;

namespace Mvvm.Framework
{
    public interface ITopActivity
        : IMvxAndroidCurrentTopActivity
    {
        new Activity Activity { get; set; }        
    }
}