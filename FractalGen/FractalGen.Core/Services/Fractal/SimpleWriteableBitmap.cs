using System;
using Cirrious.CrossCore.UI;

namespace FractalGen.Core.Services
{
    public class SimpleWriteableBitmap : ISimpleWriteableBitmap
    {
        private readonly IMvxColorToIntService _colorToIntService;

        public SimpleWriteableBitmap(IMvxColorToIntService colorToIntService, int baseWidth, int baseHeight)
        {
            _colorToIntService = colorToIntService;
            Height = baseHeight;
            Width = baseWidth;
            Pixels = new int[baseWidth*baseHeight];
        }

        public int Height { get; private set; }
        public int Width { get; private set; }
        public int[] Pixels { get; private set; }

        public ISimpleWriteableBitmap Clone()
        {
            var bitmap = new SimpleWriteableBitmap(_colorToIntService, Width, Height);
            Array.Copy(Pixels, bitmap.Pixels, Pixels.Length);
            return bitmap;
        }

        public void FillRectangle(int fromX, int fromY, int toX, int toY, MvxColor color)
        {
            for (var y = fromY; y < toY; y++)
            {
                var offset = y*Width;
                for (var x = fromX; x < toX; x++)
                {
                    Pixels[x + offset] = _colorToIntService.Convert(color);
                }
            }
        }
    }
}