using System.Text;
using System.Windows;
using Microsoft.Phone.Controls;
using ZuneSearchClient;

namespace ZuneClientApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
             Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            var client = new ZuneClient();

            //var results = await client.SearchAsync("Dark Knight", includeArtists: false, includeTracks: false);
            //var results = await client.GetAlbumsForArtistAsync("790f0000-0200-11db-89ca-0019b92a3933");
            var result = await client.GetAppInfoAsync("3e1d2705-20aa-437e-b5b9-88f96502879e");

            var s = new StringBuilder();
            

            MessageBox.Show(s.ToString());
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}