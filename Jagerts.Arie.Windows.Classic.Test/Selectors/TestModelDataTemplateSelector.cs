using Jagerts.Arie.Windows.Classic.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Jagerts.Arie.Windows.Classic.Test.Selectors
{
    class TestModelDataTemplateSelector : DataTemplateSelector
    {
        #region Properties

        public DataTemplate TestModelTemplate { get; set; }

        #endregion

        #region Methods

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is TestModel)
                return this.TestModelTemplate;

            return null;
        }

        #endregion
    }
}
