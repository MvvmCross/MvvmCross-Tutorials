using Cirrious.CrossCore.UI;
using Cirrious.MvvmCross.ViewModels;

namespace ValueConversion.Core.ViewModels
{
    public class ColorsViewModel : MvxViewModel
    {
        public ColorsViewModel()
        {
            _red = 255;
            UpdateColor();
        }

        private int _red;
        public int Red
        {
            get { return _red; }
            set { _red = value; RaisePropertyChanged(() => Red); UpdateColor(); }
        }
        
        private int _green;
        public int Green
        {
            get { return _green; }
            set { _green = value; RaisePropertyChanged(() => Green); UpdateColor(); }
        }

        private int _blue;
        public int Blue
        {
            get { return _blue; }
            set { _blue = value; RaisePropertyChanged(() => Blue); UpdateColor(); }
        }

        private MvxColor _color;
        public MvxColor Color
        {
            get { return _color; }
            set { _color = value; RaisePropertyChanged(() => Color); }
        }

        private void UpdateColor()
        {
            Color = new MvxColor(Red, Green, Blue);
        }
    }
}