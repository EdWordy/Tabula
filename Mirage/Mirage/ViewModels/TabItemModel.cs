using System.Collections.ObjectModel;

namespace Mirage.ViewModels
{
    public class TabItemModel : ViewModelBase
    {
        public static TabItemModel _instance;

        public ObservableCollection<Tab>? Tabs { get; set; }

        public void AddItem(Tab tab)
        {
            Tabs.Add(tab);
        }

        public void RemoveItem(Tab tab)
        {
            if (Tabs != null)
            {
                Tabs.Remove(tab);
            }
        }

        public TabItemModel() 
        {
            if (_instance == null)
            {
                _instance = this;
            }
            
            Tabs = new ObservableCollection<Tab>();
        }
    }

    public class Tab
    {
        public string? Header { get; set; }
        public string? Content { get; set; }

        public Tab(string header, string content) 
        {
            Header = header;
            Content = content;
        }

        public void OnClickClose()
        {
            TabItemModel._instance.RemoveItem(this);
        }
    }

    public class TabStrip
    {
        public string Content { get; set; }
        public TabStrip(string header) 
        {
            Content = header;
        }
    }
}
