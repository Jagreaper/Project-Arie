using System;
using System.Drawing;

namespace Jagerts.Arie.Standard.Controls
{
    public abstract class ButtonTheme : Theme
    {
        #region Properties

        public Color ArieButtonMainBackgroundBrush { get; set; }

        public Color ArieButtonMainBorderBrush { get; set; }

        public Color ArieButtonMainContentBrush { get; set; }


        public Color ArieButtonHoverBackgroundBrush { get; set; }

        public Color ArieButtonHoverBorderBrush { get; set; }

        public Color ArieButtonHoverContentBrush { get; set; }


        public Color ArieButtonSelectedBackgroundBrush { get; set; }

        public Color ArieButtonSelectedBorderBrush { get; set; }

        public Color ArieButtonSelectedContentBrush { get; set; }


        public Color ArieButtonDisabledBackgroundBrush { get; set; }

        public Color ArieButtonDisabledBorderBrush { get; set; }

        public Color ArieButtonDisabledContentBrush { get; set; }


        public Color ArieButtonRadioBorderBrush { get; set; }

        #endregion
    }
}
