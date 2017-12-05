using System;
using System.Collections.Generic;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public class GlobalTheme : Theme
    {
        #region Properties

        public ButtonTheme ButtonTheme { get; set; }

        #endregion

        #region Methods

        public override void Apply()
        {
            this.ButtonTheme.Apply();
        }

        #endregion
    }
}
