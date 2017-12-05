using System;
using System.Collections.Generic;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public class GlobalTheme : Theme
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

        #region Methods

        public override void Apply()
        {
            this.ButtonTheme.Apply();
        }

        #endregion
    }
}
