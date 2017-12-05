using Jagerts.Arie.Windows.Classic.Controls.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class ButtonTheme : Standard.Controls.ButtonTheme
    {
        #region Properties

        private DrawingColorBrushConverter DrawingColorBrushConverter { get; set; } = new DrawingColorBrushConverter();

        #endregion

        #region Methods

        private object ConvertFromColor(object color) => this.DrawingColorBrushConverter.Convert(color, typeof(SolidColorBrush), null, CultureInfo.CurrentCulture);

        public override void Apply()
        {
            Application.Current.Resources["ArieButtonMainBackgroundBrush"] = this.ConvertFromColor(this.ArieButtonMainBackgroundBrush);
            Application.Current.Resources["ArieButtonMainBorderBrush"] = this.ConvertFromColor(this.ArieButtonMainBorderBrush);
            Application.Current.Resources["ArieButtonMainContentBrush"] = this.ConvertFromColor(this.ArieButtonMainContentBrush);

            Application.Current.Resources["ArieButtonHoverBackgroundBrush"] = this.ConvertFromColor(this.ArieButtonHoverBackgroundBrush);
            Application.Current.Resources["ArieButtonHoverBorderBrush"] = this.ConvertFromColor(this.ArieButtonHoverBorderBrush);
            Application.Current.Resources["ArieButtonHoverContentBrush"] = this.ConvertFromColor(this.ArieButtonHoverContentBrush);

            Application.Current.Resources["ArieButtonSelectedBackgroundBrush"] = this.ConvertFromColor(this.ArieButtonSelectedBackgroundBrush);
            Application.Current.Resources["ArieButtonSelectedBorderBrush"] = this.ConvertFromColor(this.ArieButtonSelectedBorderBrush);
            Application.Current.Resources["ArieButtonSelectedContentBrush"] = this.ConvertFromColor(this.ArieButtonSelectedContentBrush);

            Application.Current.Resources["ArieButtonDisabledBackgroundBrush"] = this.ConvertFromColor(this.ArieButtonDisabledBackgroundBrush);
            Application.Current.Resources["ArieButtonDisabledBorderBrush"] = this.ConvertFromColor(this.ArieButtonDisabledBorderBrush);
            Application.Current.Resources["ArieButtonDisabledContentBrush"] = this.ConvertFromColor(this.ArieButtonDisabledContentBrush);

            Application.Current.Resources["ArieButtonRadioBorderBrush"] = this.ConvertFromColor(this.ArieButtonRadioBorderBrush);
        }

        #endregion
    }
}
