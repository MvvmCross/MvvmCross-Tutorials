namespace FractalGen.Core.Services
{
    public interface IWriteableBitmapGenerator
    {
        ISimpleWriteableBitmap Generate(int width, int height);
    }
}