using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public class ClassicDarkColorScheme : ColorScheme
    {
        #region Constructor

        public ClassicDarkColorScheme()
        {
            this.Name = "Classic Dark";
            this.MainBackgroundBrush = Color.FromArgb(0xFF, 0x66, 0x66, 0x66);
            this.MainBorderBrush = Color.FromArgb(0xFF, 0x55, 0x55, 0x55);
            this.MainContentBrush = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            this.HoverBackgroundBrush = Color.FromArgb(0xFF, 0x77, 0x77, 0x77);
            this.HoverBorderBrush = Color.FromArgb(0xFF, 0x66, 0x66, 0x66);
            this.HoverContentBrush = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            this.SelectedBackgroundBrush = Color.FromArgb(0xFF, 0x88, 0x88, 0x88);
            this.SelectedBorderBrush = Color.FromArgb(0xFF, 0x77, 0x77, 0x77);
            this.SelectedContentBrush = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            this.DisabledBackgroundBrush = Color.FromArgb(0xFF, 0x55, 0x55, 0x55);
            this.DisabledBorderBrush = Color.FromArgb(0xFF, 0x44, 0x44, 0x44);
            this.DisabledContentBrush = Color.FromArgb(0x7F, 0xFF, 0xFF, 0xFF);
            this.CheckedBorderBrush = Color.FromArgb(0xFF, 0xBB, 0xBB, 0xBB);
            this.WindowBackgroundBrush = Color.FromArgb(0xFF, 0x40, 0x40, 0x40);
        }

        #endregion
    }
}
