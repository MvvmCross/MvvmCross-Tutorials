using System;
using Android.Graphics;
using Android.Widget;
using Cirrious.MvvmCross.Binding;
using Cirrious.MvvmCross.Binding.Droid.Target;
using FractalGen.Core.Services;

namespace FractalGen.UI.Droid.Views
{
    public class CustomImageTargetBinding : MvxAndroidTargetBinding
    {
        protected ImageView ImageView
        {
            get { return (ImageView) base.Target; }
        }

        public CustomImageTargetBinding(ImageView target)
            : base(target)
        {
        }

        public override void SetValue(object value)
        {
            var target = ImageView;
            if (target == null)
                return;

            if (value == null)
                return;

            var writable = (IWriteableBitmap) value;
            var bitmap = Bitmap.CreateBitmap(writable.Pixels, writable.Width, writable.Height, Bitmap.Config.Argb4444);
            target.SetImageBitmap(bitmap);
        }

        public override Type TargetType
        {
            get { return typeof(IWriteableBitmap); }
        }

        public override MvxBindingMode DefaultMode
        {
            get { return MvxBindingMode.OneWay; }
        }
    }
}