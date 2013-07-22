using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using QuickLayout.Core.ViewModels;

namespace QuickLayout.Touch.Views
{
    [Register("TipView")]
    public class TipView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View.BackgroundColor = UIColor.White;
            base.ViewDidLoad();

            var subTotal = new UITextField();
            subTotal.KeyboardType = UIKeyboardType.DecimalPad;
            Add(subTotal);

            var seek = new UISlider()
                {
                    MinValue = 0,
                    MaxValue = 100,
                };
            Add(seek);

            var seekLabel = new UILabel();
            Add(seekLabel);

            var tipLabel = new UILabel();
            Add(tipLabel);

            var totalLabel = new UILabel();
            Add(totalLabel);

            var set = this.CreateBindingSet<TipView, TipViewModel>();
            set.Bind(subTotal).To(vm => vm.SubTotal);
            set.Bind(seek).To(vm => vm.Generosity);
            set.Bind(seekLabel).To(vm => vm.Generosity);
            set.Bind(tipLabel).To(vm => vm.Tip);
            set.Bind(totalLabel).To("SubTotal + Tip");
            set.Apply();
        }
    }
}