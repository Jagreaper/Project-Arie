using Jagerts.Arie.Standard.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public class GlobalTheme : ObservableObject
    {
        #region Fields

        private ButtonTheme buttonTheme;

        #endregion 

        #region Properties

        public ButtonTheme ButtonTheme
        {
            get => this.buttonTheme;
            set => this.Set(ref this.buttonTheme, value);
        }

        #endregion
    }
}
