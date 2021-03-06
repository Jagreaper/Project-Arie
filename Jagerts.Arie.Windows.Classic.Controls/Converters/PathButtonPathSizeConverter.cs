﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Jagerts.Arie.Windows.Classic.Controls.Converters
{
    class PathButtonPathSizeConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double)
                return (double)value + 4;

            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double)
                return (double)value - 4;

            throw new NotSupportedException();
        }

        #endregion
    }
}
