using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class ListBox : System.Windows.Controls.ListBox
    {
        #region Constructor

        static ListBox() => DefaultStyleKeyProperty.OverrideMetadata(typeof(ListBox), new FrameworkPropertyMetadata(typeof(ListBox)));

        #endregion
    }
}
