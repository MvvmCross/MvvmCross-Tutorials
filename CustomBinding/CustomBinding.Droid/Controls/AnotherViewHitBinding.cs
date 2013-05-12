using System;
using Cirrious.MvvmCross.Binding;
using Cirrious.MvvmCross.Binding.Droid.Target;

namespace CustomBinding.Droid.Controls
{
    public class AnotherViewHitBinding
        : MvxAndroidTargetBinding
    {
        protected AnotherView AnotherView
        {
            get { return (AnotherView)Target; }
        }

        private string _currentValue;

        public AnotherViewHitBinding(AnotherView anotherView)
            : base(anotherView)
        {
            anotherView.UnusualNameChanged  += OnUnusualNameChanged;
        }

        private void OnUnusualNameChanged(object sender, EventArgs eventArgs)
        {
            var value = AnotherView.GetHitValue();
            if (value == _currentValue)
                return;
            FireValueChanged(value);
        }

        public override void SetValue(object value)
        {
            var stringValue = (string)value;
            var anotherView = AnotherView;
            
            if (anotherView == null)
            {
                // this can happen - we are using WeakReferences in the base class
                return;
            }

            _currentValue = stringValue;
            anotherView.HitMe(stringValue);
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                var anotherView = AnotherView;
                if (anotherView != null)
                    anotherView.UnusualNameChanged -= OnUnusualNameChanged;
            }
            base.Dispose(isDisposing);
        }

        public override Type TargetType
        {
            get { return typeof(string); }
        }

        public override MvxBindingMode DefaultMode
        {
            get { return MvxBindingMode.TwoWay; }
        }
    }
}