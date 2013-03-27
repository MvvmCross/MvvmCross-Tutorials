using System;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Plugins.DownloadCache;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Platform;
using Collections.Core.ViewModels.Samples.ListItems;

namespace Collections.Touch
{
	[Register("DogCell")]
	public partial class DogCell : MvxTableViewCell
	{
		private MvxImageViewLoader _imageHelper;
		
		public DogCell ()
			: base()
		{
			InitialiseImageHelper();
			InitialiseBindings();
		}
		
		public DogCell (IntPtr handle)
			: base(handle)
		{
			InitialiseImageHelper();
			InitialiseBindings();
		}

		private void InitialiseBindings()
		{
			// this is equivalent to:
			//private const string BindingText = "Name Name;ImageUrl ImageUrl";
			this.DelayBind(() =>
			 	{
					this.CreateBinding().For((cell) => cell.Name).To((Dog dog) => dog.Name).Apply();
					this.CreateBinding().For((cell) => cell.ImageUrl).To ((Dog dog) => dog.ImageUrl).Apply();
				});
		}
		
		public static float GetCellHeight ()
		{
			return 120f;
		}
		
		private void InitialiseImageHelper()
		{
			_imageHelper = new MvxImageViewLoader(() => DogImageView);
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
