using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TreeViewCrash
{
    public sealed partial class TreeViewPage : Page
    {
        public IEnumerable<int> DemoItemsSource = Enumerable.Range(0, 150);
        public TreeViewPage()
        {
            Loaded += TreeViewPage_Loaded;
            this.InitializeComponent();
        }

        private void TreeViewPage_Loaded(object sender, RoutedEventArgs e)
        {
            var node = new Microsoft.UI.Xaml.Controls.TreeViewNode();

            foreach (var item in DemoItemsSource)
            {
                node.Children.Add(new Microsoft.UI.Xaml.Controls.TreeViewNode() { Content = item });
            }

            asd.RootNodes.Add(node);
        }
    }
}
