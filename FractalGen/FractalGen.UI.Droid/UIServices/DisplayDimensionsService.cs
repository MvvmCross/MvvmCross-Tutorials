using FractalGen.Core.Services;

namespace FractalGen.UI.Droid.UIServices
{
    public class DisplayDimensionsService : IDisplayDimensionsService
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public DisplayDimensionsService()
        {
            Height = Width = 600;
        }
    }
}