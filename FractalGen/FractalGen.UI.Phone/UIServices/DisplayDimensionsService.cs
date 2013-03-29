using FractalGen.Core.Services;

namespace FractalGen.UI.Phone.UIServices
{
    public class DisplayDimensionsService : IDisplayDimensionsService
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        public DisplayDimensionsService()
        {
            Height = Width = 440;
        }
    }
}