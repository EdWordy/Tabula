using Avalonia;
using Avalonia.Controls;
using DynamicData;
using Mirage.ViewModels;
using System;
using System.ComponentModel;

namespace Mirage.Views
{
    public partial class TabControl : UserControl
    {
        private TabItemModel tabItem = new TabItemModel();

        public TabControl()
        {
            InitializeComponent();

            // TabItemModel setup
            Tab tab1 = new("Header1", "Content1");
            Tab tab2 = new("Header2", "Content2");
            tabItem.AddItem(tab1);
            tabItem.AddItem(tab2);
            // data context setup
            DataContext = tabItem;
        }
    }
}
