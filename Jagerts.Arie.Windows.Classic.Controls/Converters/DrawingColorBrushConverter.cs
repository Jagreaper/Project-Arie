﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Jagerts.Arie.Windows.Classic.Controls.Converters
{
    class DrawingColorBrushConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is System.Drawing.Color dColor)
                return new SolidColorBrush(Color.FromArgb(dColor.A, dColor.R, dColor.G, dColor.B));

            if (value is Color mColor)
                return new SolidColorBrush(mColor);

            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion
    }
}
