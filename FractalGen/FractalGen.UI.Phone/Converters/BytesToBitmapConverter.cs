using System;
using System.Globalization;
using System.Windows.Data;
using FractalGen.Core.Services;
using WriteableBitmap = System.Windows.Media.Imaging.WriteableBitmap;

namespace FractalGen.UI.Phone.Converters
{
    public class BytesToBitmapConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var bytes = (IWriteableBitmap) value;
            if (bytes == null)
                return null;

            var toReturn = new WriteableBitmap(bytes.Width, bytes.Height);
            Array.Copy(bytes.Pixels, toReturn.Pixels, bytes.Pixels.Length);
            return toReturn;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
