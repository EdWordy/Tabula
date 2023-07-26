using Avalonia.Controls;

namespace Mirage.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        DataContext = this;
    }
}
