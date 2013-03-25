using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.CrossCore.WindowsPhone.Converters;
using Cirrious.MvvmCross.Plugins.Color;
using Cirrious.MvvmCross.Plugins.Visibility;
using ValueConversion.Core.Converters;

namespace ValueConversion.UI.WP.NativeConverters
{
    public class NativeTimeAgoConverter : MvxNativeValueConverter<TimeAgoConverter>
    {
    }
    public class NativeVisibilityConverter : MvxNativeValueConverter<MvxVisibilityConverter>
    {
    }
    public class NativeInvertedVisibilityConverter : MvxNativeValueConverter<MvxInvertedVisibilityConverter>
    {
    }
    public class NativeColorConverter : MvxNativeValueConverter<MvxNativeColorConverter>
    {
    }
    public class NativeStringLengthConverter : MvxNativeValueConverter<StringLengthConverter>
    {        
    }
    public class NativeStringReverseConverter : MvxNativeValueConverter<StringReverseConverter>
    {
    }
}
