using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Jagerts.Arie.Windows.Classic.Controls
{
    /// <summary>
    /// A dark theme styled custom combo box
    /// </summary>
    public sealed partial class ComboBox : System.Windows.Controls.ComboBox
    {
        public ComboBox() => this.InitializeComponent();

        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnItemsChanged(e);
            List<System.Windows.Controls.ComboBoxItem> items = this.Items.SourceCollection.OfType<object>()
                                                                         .Where(o => o is System.Windows.Controls.ComboBoxItem && !(o is ComboBoxItem))
                                                                         .Select(o => (System.Windows.Controls.ComboBoxItem)o).Reverse().ToList();

            foreach (System.Windows.Controls.ComboBoxItem item in items)
            {
                if (this.Items.Contains(item))
                {
                    this.Items.Remove(item);
                    this.Items.Add(new ComboBoxItem() { Content = item.Content, });
                }
            }
        }
    }
}
