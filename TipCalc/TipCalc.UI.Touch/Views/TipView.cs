using MonoTouch.UIKit;
using TipCalc.Core.ViewModels;

namespace TipCalc.UI.Touch
{
    public partial class TipView : MvxViewController
    {
        public TipView() : base("TipView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CreateBinding(TipLabel).To((TipViewModel vm) => vm.Tip).Apply();
            this.CreateBinding(SubTotalTextField).To((TipViewModel vm) => vm.SubTotal).Apply();
            this.CreateBinding(GenerositySlider).To((TipViewModel vm) => vm.Generosity).Apply();

            View.AddGestureRecognizer(new UITapGestureRecognizer(() => { SubTotalTextField.ResignFirstResponder(); }));
        }
    }
}