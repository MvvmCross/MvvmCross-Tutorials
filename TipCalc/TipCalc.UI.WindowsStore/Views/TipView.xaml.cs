    using TipCalc.Core.ViewModels;
    using TipCalc.UI.WindowsStore.Common;

    namespace TipCalc.UI.WindowsStore.Views
    {
        public sealed partial class TipView : LayoutAwarePage
        {
            public new TipViewModel ViewModel
            {
                get { return (TipViewModel)base.ViewModel; }
                set { base.ViewModel = value; }
            }

            public TipView()
            {
                this.InitializeComponent();
            }
        }
    }
