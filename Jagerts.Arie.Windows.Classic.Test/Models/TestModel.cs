using Jagerts.Arie.Standard.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagerts.Arie.Windows.Classic.Test.Models
{
    public class TestModel : ObservableObject
    {
        #region Fields

        public string name;

        #endregion

        #region Properties

        public string Name
        {
            get => this.name;
            set => this.Set(ref this.name, value);
        }

        #endregion
    }
}
