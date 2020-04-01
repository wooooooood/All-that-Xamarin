using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllThatXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            InitializeComponent();
        }

        private async void OnOpenMapButton_Clicked(object sender, EventArgs e)
        {
            var placemark = new Placemark
            {
                CountryName = "United States",
                AdminArea = "WA",
                Thoroughfare = "Microsoft Building 25",
                Locality = "Redmond"
            };
            var options = new MapLaunchOptions
            {
                Name = "Microsoft Building 25",
                NavigationMode = NavigationMode.Driving
            };

            await Map.OpenAsync(placemark, options);
        }
    }
}