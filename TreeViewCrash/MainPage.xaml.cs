using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TreeViewCrash
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigationButton_Click(object sender, RoutedEventArgs e)
        {
            CrashFrame.Navigate(typeof(TreeViewPage));
        }
    }
}
