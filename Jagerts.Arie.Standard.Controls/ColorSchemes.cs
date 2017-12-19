using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public static class ColorSchemes
    {
        #region Fields
        
        private static ColorScheme darkGray;

        private static ColorScheme lightBlue;

        private static ColorScheme lightRed;

        private static ColorScheme lightOrange;

        private static ColorScheme lightGreen;

        private static ObservableCollection<ColorScheme> all;

        #endregion

        #region Properties

        public static ColorScheme Default => ColorSchemes.DarkGray;
        
        public static ColorScheme DarkGray => ColorSchemes.darkGray ?? (ColorSchemes.darkGray = new DarkGrayColorScheme());

        public static ColorScheme LightBlue => ColorSchemes.lightBlue ?? (ColorSchemes.lightBlue = new LightBlueColorScheme());

        public static ColorScheme LightRed => ColorSchemes.lightRed ?? (ColorSchemes.lightRed = new LightRedColorScheme());

        public static ColorScheme LightOrange => ColorSchemes.lightOrange ?? (ColorSchemes.lightOrange = new LightOrangeColorScheme());

        public static ColorScheme LightGreen => ColorSchemes.lightGreen ?? (ColorSchemes.lightGreen = new LightGreenColorScheme());

        public static ObservableCollection<ColorScheme> All => ColorSchemes.all ?? (ColorSchemes.all = ColorSchemes.CreateThemesList());

        #endregion

        #region Methods

        private static ObservableCollection<ColorScheme> CreateThemesList()
        {
            return new ObservableCollection<ColorScheme>()
            {
                ColorSchemes.DarkGray,
                ColorSchemes.LightBlue,
                ColorSchemes.LightRed,
                ColorSchemes.LightOrange,
                ColorSchemes.LightGreen,
            };
        }

        #endregion
    }
}
