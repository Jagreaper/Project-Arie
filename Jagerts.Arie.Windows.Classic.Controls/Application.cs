using Jagerts.Arie.Standard.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class Application : System.Windows.Application
    {
        #region Constructor

        public Application() : base() => ColorSchemes.Default.Apply(); 

        #endregion
    }
}
