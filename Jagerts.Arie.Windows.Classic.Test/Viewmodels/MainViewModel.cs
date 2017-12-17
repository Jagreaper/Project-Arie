using Jagerts.Arie.Standard.Controls;
using Jagerts.Arie.Standard.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagerts.Arie.Windows.Classic.Test.Viewmodels
{
    class MainViewModel : ViewModel
    {
        #region Constructor

        public MainViewModel() => ColorSchemes.ClassicBlue.Apply();

        #endregion

        #region Properties

        public ObservableCollection<string> TestItems { get; private set; } = new ObservableCollection<string>()
        {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
        };

        #endregion
    }
}
