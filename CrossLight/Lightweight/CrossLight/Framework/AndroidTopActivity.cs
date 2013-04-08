using System;
using Android.App;
using Cirrious.CrossCore.Interfaces.Core;

namespace CrossLight.Framework
{
    public class AndroidTopActivity
        : ITopActivity
        , IMvxMainThreadDispatcher
        , IMvxMainThreadDispatcherProvider
    {
        public Activity Activity { get; set; }

        public IMvxMainThreadDispatcher Dispatcher
        {
            get { return this; }
        }

        public bool RequestMainThreadAction(Action action)
        {
            var activity = Activity;
            if (activity == null)
                return false;

            activity.RunOnUiThread(action);
            return true;
        }
    }
}