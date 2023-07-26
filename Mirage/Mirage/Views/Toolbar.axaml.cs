using Avalonia;
using Avalonia.Controls;
using Mirage.ViewModels;

namespace Mirage.Views
{
    public partial class Toolbar : UserControl
    {
        public Toolbar()
        {
            InitializeComponent();
            DataContext = this;
        }

        public void OnClickNewTab()
        {
            Tab tab = new("New", "");
            TabItemModel._instance.AddItem(tab);
        }
    }
}
