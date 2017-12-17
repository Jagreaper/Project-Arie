using System.Windows;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class Button : System.Windows.Controls.Button
    {
        #region Constructor

        static Button() => DefaultStyleKeyProperty.OverrideMetadata(typeof(Button), new FrameworkPropertyMetadata(typeof(Button)));

        #endregion
    }
}
