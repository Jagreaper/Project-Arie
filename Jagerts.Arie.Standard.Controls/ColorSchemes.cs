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
        
        private static ColorScheme classicDark;

        private static ColorScheme classicBlue;

        private static ColorScheme lightRed;

        private static ColorScheme lightOrange;

        private static ObservableCollection<ColorScheme> all;

        #endregion

        #region Properties

        public static ColorScheme Default => ColorSchemes.ClassicDark;
        
        public static ColorScheme ClassicDark => ColorSchemes.classicDark ?? (ColorSchemes.classicDark = new ClassicDarkColorScheme());

        public static ColorScheme ClassicBlue => ColorSchemes.classicBlue ?? (ColorSchemes.classicBlue = new ClassicBlueColorScheme());

        public static ColorScheme LightRed => ColorSchemes.lightRed ?? (ColorSchemes.lightRed = new LightRedColorScheme());

        public static ColorScheme LightOrange => ColorSchemes.lightOrange ?? (ColorSchemes.lightOrange = new LightOrangeColorScheme());

        public static ObservableCollection<ColorScheme> All => ColorSchemes.all ?? (ColorSchemes.all = ColorSchemes.CreateThemesList());

        #endregion

        #region Methods

        private static ObservableCollection<ColorScheme> CreateThemesList()
        {
            return new ObservableCollection<ColorScheme>()
            {
                ColorSchemes.ClassicDark,
                ColorSchemes.ClassicBlue,
                ColorSchemes.LightRed,
                ColorSchemes.LightOrange,
            };
        }

        #endregion
    }
}
