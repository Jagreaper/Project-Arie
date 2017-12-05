using System;
using System.Drawing;

namespace Jagerts.Arie.Standard.Controls
{
    public abstract class ButtonTheme : Theme
    {
        #region Fields

        private Color arieButtonMainBackgroundBrush;

        private Color arieButtonMainBorderBrush;

        private Color arieButtonMainContentBrush;


        private Color arieButtonHoverBackgroundBrush;

        private Color arieButtonHoverBorderBrush;

        private Color arieButtonHoverContentBrush;


        private Color arieButtonSelectedBackgroundBrush;

        private Color arieButtonSelectedBorderBrush;

        private Color arieButtonSelectedContentBrush;


        private Color arieButtonDisabledBackgroundBrush;

        private Color arieButtonDisabledBorderBrush;

        private Color arieButtonDisabledContentBrush;


        private Color arieButtonRadioBorderBrush;

        #endregion

        #region Properties

        public Color ArieButtonMainBackgroundBrush
        {
            get => this.arieButtonMainBackgroundBrush;
            set => this.Set(ref this.arieButtonMainBackgroundBrush, value);
        }

        public Color ArieButtonMainBorderBrush
        {
            get => this.arieButtonMainBorderBrush;
            set => this.Set(ref this.arieButtonMainBorderBrush, value);
        }

        public Color ArieButtonMainContentBrush
        {
            get => this.arieButtonMainBorderBrush;
            set => this.Set(ref this.arieButtonMainBorderBrush, value);
        }
        
        public Color ArieButtonHoverBackgroundBrush
        {
            get => this.arieButtonHoverBackgroundBrush;
            set => this.Set(ref this.arieButtonHoverBackgroundBrush, value);
        }

        public Color ArieButtonHoverBorderBrush
        {
            get => this.arieButtonHoverBorderBrush;
            set => this.Set(ref this.arieButtonHoverBorderBrush, value);
        }

        public Color ArieButtonHoverContentBrush
        {
            get => this.arieButtonHoverContentBrush;
            set => this.Set(ref this.arieButtonHoverContentBrush, value);
        }
        
        public Color ArieButtonSelectedBackgroundBrush
        {
            get => this.arieButtonSelectedBackgroundBrush;
            set => this.Set(ref this.arieButtonSelectedBackgroundBrush, value);
        }

        public Color ArieButtonSelectedBorderBrush
        {
            get => this.arieButtonSelectedBorderBrush;
            set => this.Set(ref this.arieButtonSelectedBorderBrush, value);
        }

        public Color ArieButtonSelectedContentBrush
        {
            get => this.arieButtonSelectedContentBrush;
            set => this.Set(ref this.arieButtonSelectedContentBrush, value);
        }


        public Color ArieButtonDisabledBackgroundBrush
        {
            get => this.arieButtonDisabledBackgroundBrush;
            set => this.Set(ref this.arieButtonDisabledBackgroundBrush, value);
        }

        public Color ArieButtonDisabledBorderBrush
        {
            get => this.arieButtonDisabledBorderBrush;
            set => this.Set(ref this.arieButtonDisabledBorderBrush, value);
        }

        public Color ArieButtonDisabledContentBrush
        {
            get => this.arieButtonDisabledContentBrush;
            set => this.Set(ref this.arieButtonDisabledContentBrush, value);
        }
        
        public Color ArieButtonRadioBorderBrush
        {
            get => this.arieButtonRadioBorderBrush;
            set => this.Set(ref this.arieButtonRadioBorderBrush, value);
        }

        #endregion
    }
}
