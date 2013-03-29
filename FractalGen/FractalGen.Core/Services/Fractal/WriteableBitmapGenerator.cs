namespace FractalGen.Core.Services
{
    public class WriteableBitmapGenerator : IWriteableBitmapGenerator
    {
        private readonly IMvxColorToIntService _colorToIntService;

        public WriteableBitmapGenerator(IMvxColorToIntService colorToIntService)
        {
            _colorToIntService = colorToIntService;
        }

        public ISimpleWriteableBitmap Generate(int width, int height)
        {
            return new SimpleWriteableBitmap(_colorToIntService, width, height);
        }
    }
}