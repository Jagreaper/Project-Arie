using System.Windows;
using System.Windows.Media;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    /// <summary>
    /// A dark theme styled custom toggle button
    /// </summary>
    public sealed partial class ToggleButton : System.Windows.Controls.Primitives.ToggleButton
    {
        #region Constructor

        public ToggleButton() => this.InitializeComponent();

        #endregion

        #region Properties

        public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register("PathData", typeof(Geometry), typeof(ToggleButton), new PropertyMetadata(null));

        public static readonly DependencyProperty PathStyleProperty = DependencyProperty.Register("PathStyle", typeof(Style), typeof(ToggleButton), new PropertyMetadata(null));

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
