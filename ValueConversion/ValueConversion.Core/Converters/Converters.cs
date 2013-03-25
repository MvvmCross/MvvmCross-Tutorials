using System;
using Cirrious.CrossCore.Converters;
using Cirrious.MvvmCross.Plugins.Color;
using Cirrious.MvvmCross.Plugins.Visibility;

namespace ValueConversion.Core.Converters
{
    public class StringLengthConverter : MvxValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var asString = value as string;
            asString = asString ?? string.Empty;
            return asString.Length;
        }
    }

    public class StringReverseConverter : MvxValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var asString = value as string;
            asString = asString ?? string.Empty;
            char[] charArray = asString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    public class TimeAgoConverter
        : MvxValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var when = (DateTime)value;
            var difference = (DateTime.UtcNow - when).TotalSeconds;

            string whichFormat;
            int valueToFormat;
            if (difference < 30.0)
            {
                whichFormat = "Just now";
                valueToFormat = 0;
            }
            else if (difference < 100.0)
            {
                whichFormat = "{0}s ago";
                valueToFormat = (int)difference;
            }
            else if (difference < 3600.0)
            {
                whichFormat = "{0}m ago";
                valueToFormat = (int)(difference / 60);
            }
            else if (difference < 24 * 3600)
            {
                whichFormat = "{0}h ago";
                valueToFormat = (int)(difference / (3600));
            }
            else
            {
                whichFormat = "{0}d ago";
                valueToFormat = (int)(difference / (3600 * 24));
            }

            return string.Format(whichFormat, valueToFormat);
        }
    }

    public class Converters
    {
        public TimeAgoConverter TimeAgo = new TimeAgoConverter();
        public StringReverseConverter StringReverse = new StringReverseConverter();
        public StringLengthConverter StringLength = new StringLengthConverter();
        public MvxNativeColorConverter NativeColor = new MvxNativeColorConverter();
        public MvxVisibilityConverter Visibility = new MvxVisibilityConverter();
        public MvxInvertedVisibilityConverter InvertedVisibility = new MvxInvertedVisibilityConverter();
    }
}
