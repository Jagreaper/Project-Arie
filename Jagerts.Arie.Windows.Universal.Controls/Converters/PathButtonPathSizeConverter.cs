using System;
using Windows.UI.Xaml.Data;

namespace Jagerts.Arie.Windows.Classic.Controls.Converters
{
    class PathButtonPathSizeConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is double)
                return (double)value + 4;

            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is double)
                return (double)value - 4;

            throw new NotSupportedException();
        }

        #endregion
    }
}
