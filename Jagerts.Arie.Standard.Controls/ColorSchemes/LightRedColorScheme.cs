using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    internal class LightRedColorScheme : ColorScheme
    {
        #region Constructor

        public LightRedColorScheme()
        {
            this.Name = "Light Red";
            this.MainBackgroundBrush = Color.FromArgb(0xFF, 0xEE, 0xEE, 0xF2);
            this.MainBorderBrush = Color.FromArgb(0xFF, 0xF5, 0xF5, 0xF5);
            this.MainContentBrush = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            this.HoverBackgroundBrush = Color.FromArgb(0xFF, 0xFF, 0xA3, 0xA3);
            this.HoverBorderBrush = Color.FromArgb(0xFF, 0xFC, 0xC2, 0xC2);
            this.HoverContentBrush = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            this.SelectedBackgroundBrush = Color.FromArgb(0xFF, 0xCC, 0x1E, 0x00);
            this.SelectedBorderBrush = Color.FromArgb(0xFF, 0xFF, 0x3D, 0x32);
            this.SelectedContentBrush = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            this.DisabledBackgroundBrush = Color.FromArgb(0xFF, 0xD2, 0xDD, 0xDD);
            this.DisabledBorderBrush = Color.FromArgb(0xFF, 0xD5, 0xD5, 0xD5);
            this.DisabledContentBrush = Color.FromArgb(0x7F, 0x00, 0x00, 0x00);
            this.CheckedBorderBrush = Color.FromArgb(0xFF, 0xCC, 0x1E, 0x00);
            this.WindowBackgroundBrush = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
        }

        #endregion
    }
}
