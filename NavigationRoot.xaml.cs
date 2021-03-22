
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NavigationApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationRoot : Page
    {
        public NavigationRoot()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RootContentFrame.Navigate(typeof(MainPage));
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
        }
    }
}
