using Jagerts.Arie.Standard.Controls;
using System.Windows;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class ComboBox : System.Windows.Controls.ComboBox
    {
        #region Constructor

        static ComboBox()
        {
            if (!ColorSchemes.IsApplied)
                ColorSchemes.Default.Apply();

            DefaultStyleKeyProperty.OverrideMetadata(typeof(ComboBox), new FrameworkPropertyMetadata(typeof(ComboBox)));
        }

        #endregion
    }
}
