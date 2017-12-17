using Jagerts.Arie.Standard.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class Application : System.Windows.Application
    {
        #region Methods
        
        public Application()
        {
            ColorSchemes.Default.Apply();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ColorSchemes.Default.Apply();
        }

        protected override void OnLoadCompleted(NavigationEventArgs e)
        {
            base.OnLoadCompleted(e);
            ColorSchemes.Default.Apply();
        }

        #endregion
    }
}
