using Jagerts.Arie.Standard.Controls;
using System.Windows;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class TextBlock : System.Windows.Controls.TextBlock
    {
        #region Constructor

        static TextBlock()
        {
            if (!ColorSchemes.IsApplied)
                ColorSchemes.Default.Apply();

            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextBlock), new FrameworkPropertyMetadata(typeof(TextBlock)));
        }

        #endregion
    }
}
