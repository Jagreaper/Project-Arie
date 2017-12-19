using Jagerts.Arie.Standard.Controls;
using System.Windows;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class RadioButton : System.Windows.Controls.RadioButton
    {
        #region Constructor

        static RadioButton()
        {
            if (!ColorSchemes.IsApplied)
                ColorSchemes.Default.Apply();

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadioButton), new FrameworkPropertyMetadata(typeof(RadioButton)));
        }

        #endregion
    }
}
