using System.Windows;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class TextBox : System.Windows.Controls.TextBox
    {
        #region Constructor

        static TextBox() => DefaultStyleKeyProperty.OverrideMetadata(typeof(TextBox), new FrameworkPropertyMetadata(typeof(TextBox)));

        #endregion
    }
}
