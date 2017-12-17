using Jagerts.Arie.Standard.Controls;
using Jagerts.Arie.Standard.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Jagerts.Arie.Windows.Classic.Test.Viewmodels
{
    class MainViewModel : ViewModel
    {
        #region Constructor

        public MainViewModel()
            : base()
        {
            this.ToggleCommand = new RelayCommand(this.Toggle);
        }

        #endregion

        #region Properties

        private ColorScheme ColorScheme { get; set; } = ColorSchemes.Default;

        public ICommand ToggleCommand { get; private set; }

        public ObservableCollection<string> TestItems { get; private set; } = new ObservableCollection<string>()
        {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
        };

        #endregion

        #region Methods

        public void Toggle()
        {
            if (this.ColorScheme == ColorSchemes.ClassicDark)
                (this.ColorScheme = ColorSchemes.ClassicBlue).Apply();
            else if (this.ColorScheme == ColorSchemes.ClassicBlue)
                (this.ColorScheme = ColorSchemes.ClassicDark).Apply();
        }

        #endregion
    }
}
