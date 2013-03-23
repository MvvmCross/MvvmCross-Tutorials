using System;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Plugins.DownloadCache;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Platform;
using MonoTouch.CoreGraphics;

namespace Collections.Touch
{
	[Register("KittenCell")]
	public partial class KittenCell : MvxTableViewCell
	{
		private const string BindingText = "Name Name;ImageUrl ImageUrl";

		private MvxImageViewLoader _imageHelper;

		public KittenCell ()
			: base(BindingText)
		{
			InitialiseImageHelper();
		}

		public KittenCell (IntPtr handle)
			: base(BindingText, handle)
		{
			InitialiseImageHelper();
		}

		public static float GetCellHeight ()
		{
			return 120f;
		}

		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			AnimateToScale(1.2f);
		}

		public override void TouchesCancelled (NSSet touches, UIEvent evt)
		{
			AnimateToScale(1.0f);
		}

		public override void TouchesEnded (NSSet touches, UIEvent evt)
		{
			AnimateToScale(1.0f);
		}

		private void AnimateToScale (float scale)
		{
			UIView.BeginAnimations("animateToScale");
			UIView.SetAnimationCurve(UIViewAnimationCurve.EaseIn);
			UIView.SetAnimationDuration(0.5);
			Transform = CGAffineTransform.MakeScale (scale, 1.0f);
			UIView.CommitAnimations();
		}
		private void InitialiseImageHelper()
		{
			_imageHelper = new MvxImageViewLoader(() => KittenImageView);
		}

		public string Name {
			get { return MainLabel.Text; }
			set { MainLabel.Text = value; }
		}

		public string ImageUrl {
			get { return _imageHelper.ImageUrl; }
			set { _imageHelper.ImageUrl = value; }
		}
	}
}

