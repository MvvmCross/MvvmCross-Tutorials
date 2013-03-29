using Cirrious.CrossCore.UI;

namespace FractalGen.Core.Services
{
    public interface IWriteableBitmap
    {
        IWriteableBitmap Clone();
        int[] Pixels { get; }
        int Height { get; }
        int Width { get; }
        void FillRectangle(int fromX, int fromY, int toX, int toY, MvxColor color);
    }
}