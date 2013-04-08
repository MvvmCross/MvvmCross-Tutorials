using Android.Views;
using Cirrious.MvvmCross.Binding.Droid.Interfaces.Views;

namespace CrossLight.Framework
{
    public class LayoutInflaterProvider
        : IMvxLayoutInflater
    {
        public LayoutInflaterProvider(LayoutInflater layoutInflater)
        {
            LayoutInflater = layoutInflater;
        }

        public LayoutInflater LayoutInflater { get; private set; }
    }
}