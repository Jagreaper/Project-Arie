using Jagerts.Arie.Windows.Classic.Controls.Converters;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Jagerts.Arie.Standard.Controls
{
    public static class ColorSchemeExtensions
    {
        #region Properties

        private static DrawingColorBrushConverter DrawingColorBrushConverter { get; set; } = new DrawingColorBrushConverter();

        #endregion

        #region Methods

        private static object ConvertFromColor(object color) => ColorSchemeExtensions.DrawingColorBrushConverter.Convert(color, typeof(SolidColorBrush), null, null);

        public static void Apply(this ColorScheme host)
        {
            Application.Current.Resources["ArieMainBackgroundBrush"] = ColorSchemeExtensions.ConvertFromColor(host.MainBackgroundBrush);
            Application.Current.Resources["ArieMainBorderBrush"] = ColorSchemeExtensions.ConvertFromColor(host.MainBorderBrush);
            Application.Current.Resources["ArieMainContentBrush"] = ColorSchemeExtensions.ConvertFromColor(host.MainContentBrush);

            Application.Current.Resources["ArieHoverBackgroundBrush"] = ColorSchemeExtensions.ConvertFromColor(host.HoverBackgroundBrush);
            Application.Current.Resources["ArieHoverBorderBrush"] = ColorSchemeExtensions.ConvertFromColor(host.HoverBorderBrush);
            Application.Current.Resources["ArieHoverContentBrush"] = ColorSchemeExtensions.ConvertFromColor(host.HoverContentBrush);

            Application.Current.Resources["ArieSelectedBackgroundBrush"] = ColorSchemeExtensions.ConvertFromColor(host.SelectedBackgroundBrush);
            Application.Current.Resources["ArieSelectedBorderBrush"] = ColorSchemeExtensions.ConvertFromColor(host.SelectedBorderBrush);
            Application.Current.Resources["ArieSelectedContentBrush"] = ColorSchemeExtensions.ConvertFromColor(host.SelectedContentBrush);

            Application.Current.Resources["ArieDisabledBackgroundBrush"] = ColorSchemeExtensions.ConvertFromColor(host.DisabledBackgroundBrush);
            Application.Current.Resources["ArieDisabledBorderBrush"] = ColorSchemeExtensions.ConvertFromColor(host.DisabledBorderBrush);
            Application.Current.Resources["ArieDisabledContentBrush"] = ColorSchemeExtensions.ConvertFromColor(host.DisabledContentBrush);

            Application.Current.Resources["ArieCheckedBorderBrush"] = ColorSchemeExtensions.ConvertFromColor(host.CheckedBorderBrush);
        }

        #endregion
    }
}
