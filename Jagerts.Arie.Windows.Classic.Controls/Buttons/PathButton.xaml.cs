using System.Windows;
using System.Windows.Media;

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
