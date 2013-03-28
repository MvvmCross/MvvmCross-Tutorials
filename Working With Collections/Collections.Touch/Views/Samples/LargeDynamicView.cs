namespace Collections.Touch
{
    public class LargeDynamicView : BaseDynamicKittenTableView
    {
        public LargeDynamicView()
        {
            Title = "Large Dynamic";
        }

        protected override void AddKittensPressed()
        {
            ViewModel.AddKittenCommand.Execute(null);
        }

        protected override void KillKittensPressed()
        {
            ViewModel.KillKittensCommand.Execute(null);
        }
    }
}