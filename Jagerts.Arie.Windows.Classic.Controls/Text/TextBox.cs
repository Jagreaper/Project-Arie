using Jagerts.Arie.Standard.Controls;
using System.Windows;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class TextBox : System.Windows.Controls.TextBox
    {
        #region Constructor

        static TextBox()
        {
            if (!ColorSchemes.IsApplied)
                ColorSchemes.Default.Apply();

            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextBox), new FrameworkPropertyMetadata(typeof(TextBox)));
        }

        #endregion
    }
}
