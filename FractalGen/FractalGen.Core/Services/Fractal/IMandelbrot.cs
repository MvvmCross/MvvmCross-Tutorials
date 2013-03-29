namespace FractalGen.Core.Services
{
    public interface IMandelbrot
    {
        bool IsScaleComplete { get; }
        bool IsLineComplete { get; }
        void NextLine();
        IWriteableBitmap Bitmap { get; }
    }
}