using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public static class GlobalThemes
    {
        #region Fields

        private static GlobalTheme classicBlueTheme;

        private static GlobalTheme classicDarkTheme;

        private static ObservableCollection<GlobalTheme> all;

        #endregion

        #region Properties

        public static GlobalTheme ClassicBlueTheme => GlobalThemes.classicBlueTheme ?? (GlobalThemes.classicBlueTheme = GlobalThemes.CreateClassicBlueTheme());

        public static GlobalTheme ClassicDarkTheme => GlobalThemes.classicDarkTheme ?? (GlobalThemes.classicDarkTheme = GlobalThemes.CreateClassicDarkTheme());

        public static ObservableCollection<GlobalTheme> All => GlobalThemes.all ?? (GlobalThemes.all = GlobalThemes.CreateThemesList());

        #endregion

        #region Methods

        private static ObservableCollection<GlobalTheme> CreateThemesList()
        {
            return new ObservableCollection<GlobalTheme>()
            {
                GlobalThemes.ClassicBlueTheme,
                GlobalThemes.ClassicDarkTheme,
            };
        }

        private static GlobalTheme CreateClassicBlueTheme()
        {
            return new GlobalTheme
            {
                Name = "Classic Dark",
                MainBackgroundBrush = Color.FromArgb(0xFF, 0xEE, 0xEE, 0xF2),
                MainBorderBrush = Color.FromArgb(0xFF, 0xF5, 0xF5, 0xF5),
                MainContentBrush = Color.FromArgb(0xFF, 0x00, 0x00, 0x00),
                HoverBackgroundBrush = Color.FromArgb(0xFF, 0xC9, 0xDE, 0xF5),
                HoverBorderBrush = Color.FromArgb(0xFF, 0xCC, 0xCE, 0xDB),
                HoverContentBrush = Color.FromArgb(0x00, 0x00, 0x00, 0x00),
                SelectedBackgroundBrush = Color.FromArgb(0xFF, 0x33, 0x99, 0xFF),
                SelectedBorderBrush = Color.FromArgb(0xFF, 0x00, 0x7A, 0xCC),
                SelectedContentBrush = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF),
                DisabledBackgroundBrush = Color.FromArgb(0xFF, 0xEE, 0xEE, 0xF2),
                DisabledBorderBrush = Color.FromArgb(0xFF, 0xF5, 0xF5, 0xF5),
                DisabledContentBrush = Color.FromArgb(0xFF, 0x00, 0x00, 0x00),
                CheckedBorderBrush = Color.FromArgb(0xFF, 0x00, 0x7A, 0xCC),
            };
        }

        private static GlobalTheme CreateClassicDarkTheme()
        {
            return new GlobalTheme
            {
                Name = "Classic Dark",
                MainBackgroundBrush     = Color.FromArgb(0xFF, 0x66, 0x66, 0x66),
                MainBorderBrush         = Color.FromArgb(0xFF, 0x55, 0x55, 0x55),
                MainContentBrush        = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF),
                HoverBackgroundBrush    = Color.FromArgb(0xFF, 0x77, 0x77, 0x77),
                HoverBorderBrush        = Color.FromArgb(0xFF, 0x66, 0x66, 0x66),
                HoverContentBrush       = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF),
                SelectedBackgroundBrush = Color.FromArgb(0xFF, 0x88, 0x88, 0x88),
                SelectedBorderBrush     = Color.FromArgb(0xFF, 0x77, 0x77, 0x77),
                SelectedContentBrush    = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF),
                DisabledBackgroundBrush = Color.FromArgb(0xFF, 0x55, 0x55, 0x55),
                DisabledBorderBrush     = Color.FromArgb(0xFF, 0x44, 0x44, 0x44),
                DisabledContentBrush    = Color.FromArgb(0x7F, 0xFF, 0xFF, 0xFF),
                CheckedBorderBrush      = Color.FromArgb(0xFF, 0xBB, 0xBB, 0xBB),
            };
        }

        #endregion
    }
}
