using Jagerts.Arie.Standard.Controls;
using Jagerts.Arie.Standard.Mvvm;
using Jagerts.Arie.Windows.Classic.Test.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Jagerts.Arie.Windows.Classic.Test.ViewModels
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

        private int Index { get; set; }

        private ColorScheme ColorScheme { get; set; } = ColorSchemes.Default;

        public ICommand ToggleCommand { get; private set; }

        public ObservableCollection<TestModel> TestModels { get; private set; } = new ObservableCollection<TestModel>()
        {
            new TestModel() { Name = "Test Model 1" },
            new TestModel() { Name = "Test Model 2" },
            new TestModel() { Name = "Test Model 3" },
            new TestModel() { Name = "Test Model 4" },
        };

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
            Application app = App.Current;
            this.Index = (this.Index + 1) % ColorSchemes.All.Count;
            ColorSchemes.All[this.Index].Apply();
        }

        #endregion
    }
}
