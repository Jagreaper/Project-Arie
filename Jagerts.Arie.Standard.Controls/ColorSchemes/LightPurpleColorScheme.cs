using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    internal class LightPurpleColorScheme : ColorScheme
    {
        #region Constructor

        public LightPurpleColorScheme()
        {
            this.Name = "Light Purple";
            this.MainBackgroundBrush = Color.FromArgb(0xFF, 0xEE, 0xEE, 0xF2);
            this.MainBorderBrush = Color.FromArgb(0xFF, 0xF5, 0xF5, 0xF5);
            this.MainContentBrush = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            this.HoverBackgroundBrush = Color.FromArgb(0xFF, 0xDC, 0x93, 0xFF);
            this.HoverBorderBrush = Color.FromArgb(0xFF, 0xE0, 0xB0, 0xFC);
            this.HoverContentBrush = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            this.SelectedBackgroundBrush = Color.FromArgb(0xFF, 0x8B, 0x00, 0xCC);
            this.SelectedBorderBrush = Color.FromArgb(0xFF, 0xBE, 0x31, 0xFF);
            this.SelectedContentBrush = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            this.DisabledBackgroundBrush = Color.FromArgb(0xFF, 0xDD, 0xDD, 0xD2);
            this.DisabledBorderBrush = Color.FromArgb(0xFF, 0xD5, 0xD5, 0xD5);
            this.DisabledContentBrush = Color.FromArgb(0x7F, 0x00, 0x00, 0x00);
            this.CheckedBorderBrush = Color.FromArgb(0xFF, 0x8B, 0x00, 0xCC);
            this.WindowBackgroundBrush = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
        }

        #endregion
    }
}
