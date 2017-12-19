using Jagerts.Arie.Standard.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class ListBox : System.Windows.Controls.ListBox
    {
        #region Constructor

        static ListBox()
        {
            if (!ColorSchemes.IsApplied)
                ColorSchemes.Default.Apply();

            DefaultStyleKeyProperty.OverrideMetadata(typeof(ListBox), new FrameworkPropertyMetadata(typeof(ListBox)));
        }

        #endregion
    }
}
