using Jagerts.Arie.Standard.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jagerts.Arie.Standard.Controls
{
    public abstract class Theme : ObservableObject
    {
        #region Fields

        private string name;

        #endregion

        #region Properties

        public string Name
        {
            get => this.name;
            set => this.Set(ref this.name, value);
        }

        #endregion

        #region Methods

        public abstract void Apply();

        #endregion
    }
}
