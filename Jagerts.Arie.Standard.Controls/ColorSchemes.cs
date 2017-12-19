using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public static class ColorSchemes
    {
        #region Fields
        
        private static ObservableCollection<ColorScheme> all;

        private static ColorScheme darkGray;

        private static ColorScheme lightBlue;

        private static ColorScheme lightRed;

        private static ColorScheme lightOrange;

        private static ColorScheme lightGreen;

        private static ColorScheme lightPurple;

        #endregion

        #region Properties

        public static bool IsApplied => ColorSchemes.All.Where(c => c.IsApplied).Count() > 0;

        public static ObservableCollection<ColorScheme> All => ColorSchemes.all ?? (ColorSchemes.all = ColorSchemes.CreateThemesList());

        public static ColorScheme Default => ColorSchemes.DarkGray;
        
        public static ColorScheme DarkGray => ColorSchemes.darkGray ?? (ColorSchemes.darkGray = new DarkGrayColorScheme());

        public static ColorScheme LightBlue => ColorSchemes.lightBlue ?? (ColorSchemes.lightBlue = new LightBlueColorScheme());

        public static ColorScheme LightRed => ColorSchemes.lightRed ?? (ColorSchemes.lightRed = new LightRedColorScheme());

        public static ColorScheme LightOrange => ColorSchemes.lightOrange ?? (ColorSchemes.lightOrange = new LightOrangeColorScheme());

        public static ColorScheme LightGreen => ColorSchemes.lightGreen ?? (ColorSchemes.lightGreen = new LightGreenColorScheme());

        public static ColorScheme LightPurple => ColorSchemes.lightPurple ?? (ColorSchemes.lightPurple = new LightPurpleColorScheme());

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
                ColorSchemes.LightPurple,
            };
        }

        #endregion
    }
}
