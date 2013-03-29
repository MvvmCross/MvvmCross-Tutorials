namespace FractalGen.Core.Services
{
    public interface IWriteableBitmapGenerator
    {
        IWriteableBitmap Generate(int width, int height);
    }
}