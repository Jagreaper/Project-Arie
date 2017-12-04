using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    /// <summary>
    /// A dark theme styled custom button
    /// </summary>
    public sealed partial class PathButton : System.Windows.Controls.Button
    {
        #region Constructor

        public PathButton() => this.InitializeComponent();

        #endregion

        #region Properties

        public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register("PathData", typeof(Geometry), typeof(PathButton), new PropertyMetadata(null));

        public static readonly DependencyProperty PathStyleProperty = DependencyProperty.Register("PathStyle", typeof(Style), typeof(PathButton), new PropertyMetadata(null));

        public Geometry PathData
        {
            get => (Geometry)this.GetValue(PathDataProperty);
            set => this.SetValue(PathDataProperty, value);
        }

        public Style PathStyle
        {
            get => (Style)this.GetValue(PathStyleProperty);
            set => this.SetValue(PathStyleProperty, value);
        }

        #endregion
    }
}
