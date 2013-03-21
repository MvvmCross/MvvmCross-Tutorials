using System;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Plugins.DownloadCache;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Platform;

namespace Collections.Touch
{
	[Register("DogCell")]
	public partial class DogCell : MvxBaseBindableTableViewCell
	{
		private const string BindingText = "{'Name':{'Path':'Name'},'ImageUrl':{'Path':'ImageUrl'}}";
		
		private MvxDynamicImageHelper<UIImage> _imageHelper;
		
		public DogCell ()
			: base(BindingText)
		{
			InitialiseImageHelper();
		}
		
		public DogCell (IntPtr handle)
			: base(BindingText, handle)
		{
			InitialiseImageHelper();
		}
		
		public static float GetCellHeight ()
		{
			return 120f;
		}
		
		private void InitialiseImageHelper()
		{
			_imageHelper = new MvxDynamicImageHelper<UIImage>();
			_imageHelper.ImageChanged += ImageHelperOnImageChanged;
		}
		
		private void ImageHelperOnImageChanged(object sender, MvxValueEventArgs<UIImage> mvxValueEventArgs)
		{
			if (DogImageView != null && mvxValueEventArgs.Value != null)
				DogImageView.Image = mvxValueEventArgs.Value;
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
