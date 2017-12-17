using System.Windows;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class RadioButton : System.Windows.Controls.RadioButton
    {
        #region Constructor

        static RadioButton() => DefaultStyleKeyProperty.OverrideMetadata(typeof(RadioButton), new FrameworkPropertyMetadata(typeof(RadioButton)));

        #endregion
    }
}
