using Cirrious.FluentLayouts;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using QuickLayout.Core.ViewModels;

namespace QuickLayout.Touch.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View.BackgroundColor = UIColor.White;
            base.ViewDidLoad();

            var buttonF = new UIButton(UIButtonType.RoundedRect);
            buttonF.SetTitle("Form", UIControlState.Normal);
            buttonF.TranslatesAutoresizingMaskIntoConstraints = false;
            Add(buttonF);

            var buttonD = new UIButton(UIButtonType.RoundedRect);
            buttonD.SetTitle("Details", UIControlState.Normal);
            buttonD.TranslatesAutoresizingMaskIntoConstraints = false;
            Add(buttonD);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(buttonF).To("GoForm");
            set.Bind(buttonD).To("GoDetails");
            set.Apply();

            var constraints = View.VerticalStackPanelConstraints(20, 10, 20, 10, 5, View.Subviews);
            View.AddConstraints(constraints);
        }
    }
}