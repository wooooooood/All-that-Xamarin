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

        private async void OnOpenDialButton_Clicked(object sender, EventArgs e)
        {
            var number = "6501234567";

            try
            {
                //When Open is requested the API will automatically attempt to format the number based on the country code if specified.
                PhoneDialer.Open(number);
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
                // Ex) iPad, iOS emulator
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}