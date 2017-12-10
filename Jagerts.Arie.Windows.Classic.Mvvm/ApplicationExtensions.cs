using Jagerts.Arie.Standard.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Jagerts.Arie.Windows.Classic.Mvvm
{
    public static class ApplicationExtensions
    {
        #region Properties

        public static ViewModel CurrentViewModel { get; private set; }

        #endregion

        #region Methods
        
        public static void Navigate(this Application host, UserControl view)
        {
            ApplicationExtensions.CurrentViewModel?.OnClosing(host, EventArgs.Empty);
            ApplicationExtensions.CurrentViewModel?.OnClose(host, EventArgs.Empty);
            ApplicationExtensions.CurrentViewModel = view.DataContext is ViewModel ? (ViewModel)view.DataContext : null;
            ApplicationExtensions.CurrentViewModel?.OnLoad(host, EventArgs.Empty);
        }

        #endregion
    }
}
