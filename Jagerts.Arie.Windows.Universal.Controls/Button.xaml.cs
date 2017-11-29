using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Foundation = Windows.Foundation;
using FoundationCollections = Windows.Foundation.Collections;
using Xaml = Windows.UI.Xaml;
using XamlControls = Windows.UI.Xaml.Controls;
using XamlPrimitives = Windows.UI.Xaml.Controls.Primitives;
using XamlData = Windows.UI.Xaml.Data;
using XamlInput = Windows.UI.Xaml.Input;
using XamlMedia = Windows.UI.Xaml.Media;
using XamlNavigation = Windows.UI.Xaml.Navigation;

namespace Jagerts.Arie.Windows.Universal.Controls
{
    /// <summary>
    /// A dark theme styled custom button
    /// </summary>
    public sealed partial class Button : XamlControls.Button
    {
        public Button() => this.InitializeComponent();
    }
}
