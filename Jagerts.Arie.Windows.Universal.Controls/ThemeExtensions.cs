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

        public static void Apply(this GlobalTheme host)
        {
            Application.Current.Resources["ArieMainBackgroundBrush"] = ThemeExtensions.ConvertFromColor(host.MainBackgroundBrush);
            Application.Current.Resources["ArieMainBorderBrush"] = ThemeExtensions.ConvertFromColor(host.MainBorderBrush);
            Application.Current.Resources["ArieMainContentBrush"] = ThemeExtensions.ConvertFromColor(host.MainContentBrush);

            Application.Current.Resources["ArieHoverBackgroundBrush"] = ThemeExtensions.ConvertFromColor(host.HoverBackgroundBrush);
            Application.Current.Resources["ArieHoverBorderBrush"] = ThemeExtensions.ConvertFromColor(host.HoverBorderBrush);
            Application.Current.Resources["ArieHoverContentBrush"] = ThemeExtensions.ConvertFromColor(host.HoverContentBrush);

            Application.Current.Resources["ArieSelectedBackgroundBrush"] = ThemeExtensions.ConvertFromColor(host.SelectedBackgroundBrush);
            Application.Current.Resources["ArieSelectedBorderBrush"] = ThemeExtensions.ConvertFromColor(host.SelectedBorderBrush);
            Application.Current.Resources["ArieSelectedContentBrush"] = ThemeExtensions.ConvertFromColor(host.SelectedContentBrush);

            Application.Current.Resources["ArieDisabledBackgroundBrush"] = ThemeExtensions.ConvertFromColor(host.DisabledBackgroundBrush);
            Application.Current.Resources["ArieDisabledBorderBrush"] = ThemeExtensions.ConvertFromColor(host.DisabledBorderBrush);
            Application.Current.Resources["ArieDisabledContentBrush"] = ThemeExtensions.ConvertFromColor(host.DisabledContentBrush);

            Application.Current.Resources["ArieCheckedBorderBrush"] = ThemeExtensions.ConvertFromColor(host.CheckedBorderBrush);
        }

        #endregion
    }
}
