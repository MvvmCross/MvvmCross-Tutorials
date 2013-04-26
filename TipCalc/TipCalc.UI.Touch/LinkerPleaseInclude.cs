using MonoTouch.UIKit;

namespace TipCalc.UI.Touch
{
    public class LinkerPleaseInclude
    {
        public void IncludeTextSet()
        {
            var u = new UITextField();
            u.Text = u.Text + "h";

            var l = new UILabel();
            l.Text = l.Text + "h";
        }
    }
}