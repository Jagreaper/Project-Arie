using System.Windows;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class TextBlock : System.Windows.Controls.TextBlock
    {
        #region Constructor

        static TextBlock() => DefaultStyleKeyProperty.OverrideMetadata(typeof(TextBlock), new FrameworkPropertyMetadata(typeof(TextBlock)));

        #endregion
    }
}
