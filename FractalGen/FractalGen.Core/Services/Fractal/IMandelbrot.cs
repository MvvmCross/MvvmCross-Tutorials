namespace FractalGen.Core.Services
{
    public interface IMandelbrot
    {
        bool IsScaleComplete { get; }
        bool IsLineComplete { get; }
        ISimpleWriteableBitmap Bitmap { get; }
        void NextLine();
    }
}