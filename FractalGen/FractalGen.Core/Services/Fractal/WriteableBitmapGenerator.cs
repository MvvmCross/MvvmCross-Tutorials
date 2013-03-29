namespace FractalGen.Core.Services
{
    public class WriteableBitmapGenerator : IWriteableBitmapGenerator
    {
        private readonly IMvxColorToIntService _colorToIntService;

        public WriteableBitmapGenerator(IMvxColorToIntService colorToIntService)
        {
            _colorToIntService = colorToIntService;
        }

        public IWriteableBitmap Generate(int width, int height)
        {
            return new WriteableBitmap(_colorToIntService, width, height);
        }
    }
}