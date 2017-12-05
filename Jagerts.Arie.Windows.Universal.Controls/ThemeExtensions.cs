using Jagerts.Arie.Windows.Classic.Controls.Converters;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Jagerts.Arie.Standard.Controls
{
    public static class ThemeExtensions
    {
        #region Properties

        private static DrawingColorBrushConverter DrawingColorBrushConverter { get; set; } = new DrawingColorBrushConverter();

        #endregion

        #region Methods

        private static object ConvertFromColor(object color) => ThemeExtensions.DrawingColorBrushConverter.Convert(color, typeof(SolidColorBrush), null, null);

        public static void Apply(this ButtonTheme host)
        {
            Application.Current.Resources["ArieButtonMainBackgroundBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonMainBackgroundBrush);
            Application.Current.Resources["ArieButtonMainBorderBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonMainBorderBrush);
            Application.Current.Resources["ArieButtonMainContentBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonMainContentBrush);

            Application.Current.Resources["ArieButtonHoverBackgroundBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonHoverBackgroundBrush);
            Application.Current.Resources["ArieButtonHoverBorderBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonHoverBorderBrush);
            Application.Current.Resources["ArieButtonHoverContentBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonHoverContentBrush);

            Application.Current.Resources["ArieButtonSelectedBackgroundBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonSelectedBackgroundBrush);
            Application.Current.Resources["ArieButtonSelectedBorderBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonSelectedBorderBrush);
            Application.Current.Resources["ArieButtonSelectedContentBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonSelectedContentBrush);

            Application.Current.Resources["ArieButtonDisabledBackgroundBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonDisabledBackgroundBrush);
            Application.Current.Resources["ArieButtonDisabledBorderBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonDisabledBorderBrush);
            Application.Current.Resources["ArieButtonDisabledContentBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonDisabledContentBrush);

            Application.Current.Resources["ArieButtonRadioBorderBrush"] = ThemeExtensions.ConvertFromColor(host.ArieButtonRadioBorderBrush);
        }

        public static void Apply(this GlobalTheme host)
        {
            host.ButtonTheme.Apply();
        }

        #endregion
    }
}
