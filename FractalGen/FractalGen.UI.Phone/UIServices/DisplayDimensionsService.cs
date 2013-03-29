using FractalGen.Core.Services;

namespace FractalGen.UI.Phone.UIServices
{
    public class DisplayDimensionsService : IDisplayDimensionsService
    {
        public DisplayDimensionsService()
        {
            Height = 800;
            Width = 480;
        }

        public int Height { get; set; }
        public int Width { get; set; }
    }
}