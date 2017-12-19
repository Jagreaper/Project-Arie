using Jagerts.Arie.Standard.Controls;
using System.Windows;
using System.Windows.Media;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    public class PathRadioButton : RadioButton
    {
        #region Constructor

        static PathRadioButton()
        {
            if (!ColorSchemes.IsApplied)
                ColorSchemes.Default.Apply();

            DefaultStyleKeyProperty.OverrideMetadata(typeof(PathRadioButton), new FrameworkPropertyMetadata(typeof(PathRadioButton)));
        }

        #endregion

        #region Fields

        public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register("PathData", typeof(Geometry), typeof(PathRadioButton), new PropertyMetadata(null));

        public static readonly DependencyProperty PathStyleProperty = DependencyProperty.Register("PathStyle", typeof(Style), typeof(PathRadioButton), new PropertyMetadata(null));

        #endregion

        #region Properties

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
