using System;
using System.Collections.Generic;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public abstract class Theme
    {
        #region Properties

        public string Name { get; private set; }

        #endregion

        #region Methods

        public abstract void Apply();

        #endregion
    }
}
