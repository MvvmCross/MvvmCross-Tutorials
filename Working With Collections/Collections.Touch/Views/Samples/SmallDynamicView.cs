namespace Collections.Touch
{
    public class SmallDynamicView : BaseDynamicKittenTableView
    {
        public SmallDynamicView()
        {
            Title = "Small Dynamic";
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