using Jagerts.Arie.Standard.Mvvm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public class ColorScheme : ObservableObject
    {
        #region Fields

        private string name;

        private Color mainBackgroundBrush;

        private Color mainBorderBrush;

        private Color mainContentBrush;


        private Color hoverBackgroundBrush;

        private Color hoverBorderBrush;

        private Color hoverContentBrush;


        private Color selectedBackgroundBrush;

        private Color selectedBorderBrush;

        private Color selectedContentBrush;


        private Color disabledBackgroundBrush;

        private Color disabledBorderBrush;

        private Color disabledContentBrush;


        private Color checkedBorderBrush;

        private Color windowBackgroundBrush;

        #endregion

        #region Properties

        public string Name
        {
            get => this.name;
            set => this.Set(ref this.name, value);
        }

        public Color MainBackgroundBrush
        {
            get => this.mainBackgroundBrush;
            set => this.Set(ref this.mainBackgroundBrush, value);
        }

        public Color MainBorderBrush
        {
            get => this.mainBorderBrush;
            set => this.Set(ref this.mainBorderBrush, value);
        }

        public Color MainContentBrush
        {
            get => this.mainContentBrush;
            set => this.Set(ref this.mainContentBrush, value);
        }

        public Color HoverBackgroundBrush
        {
            get => this.hoverBackgroundBrush;
            set => this.Set(ref this.hoverBackgroundBrush, value);
        }

        public Color HoverBorderBrush
        {
            get => this.hoverBorderBrush;
            set => this.Set(ref this.hoverBorderBrush, value);
        }

        public Color HoverContentBrush
        {
            get => this.hoverContentBrush;
            set => this.Set(ref this.hoverContentBrush, value);
        }

        public Color SelectedBackgroundBrush
        {
            get => this.selectedBackgroundBrush;
            set => this.Set(ref this.selectedBackgroundBrush, value);
        }

        public Color SelectedBorderBrush
        {
            get => this.selectedBorderBrush;
            set => this.Set(ref this.selectedBorderBrush, value);
        }

        public Color SelectedContentBrush
        {
            get => this.selectedContentBrush;
            set => this.Set(ref this.selectedContentBrush, value);
        }


        public Color DisabledBackgroundBrush
        {
            get => this.disabledBackgroundBrush;
            set => this.Set(ref this.disabledBackgroundBrush, value);
        }

        public Color DisabledBorderBrush
        {
            get => this.disabledBorderBrush;
            set => this.Set(ref this.disabledBorderBrush, value);
        }

        public Color DisabledContentBrush
        {
            get => this.disabledContentBrush;
            set => this.Set(ref this.disabledContentBrush, value);
        }

        public Color CheckedBorderBrush
        {
            get => this.checkedBorderBrush;
            set => this.Set(ref this.checkedBorderBrush, value);
        }

        public Color WindowBackgroundBrush
        {
            get => this.windowBackgroundBrush;
            set => this.Set(ref this.windowBackgroundBrush, value);
        }

        #endregion
    }
}
