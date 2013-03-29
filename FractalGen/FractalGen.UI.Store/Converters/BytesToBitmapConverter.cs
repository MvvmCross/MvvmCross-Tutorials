using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using FractalGen.Core.Services;
using Windows.UI.Xaml.Data;
using WriteableBitmap = Windows.UI.Xaml.Media.Imaging.WriteableBitmap;

namespace FractalGen.UI.Phone.Converters
{
    public class BytesToBitmapConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var bytes = (IWriteableBitmap)value;
            if (bytes == null)
                return null;

            var byteArray = new byte[bytes.Pixels.Length*4];
            Buffer.BlockCopy(bytes.Pixels, 0, byteArray, 0, byteArray.Length);
            var toReturn = new WriteableBitmap(bytes.Width, bytes.Height);
            var pixelStream = toReturn.PixelBuffer.AsStream();
            pixelStream.Seek(0, SeekOrigin.Begin);
            pixelStream.Write(byteArray, 0, byteArray.Length);
            return toReturn;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
