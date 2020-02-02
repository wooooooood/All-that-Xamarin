using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace All_that_Xamarin.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/wooooooood/All-that-Xamarin"));
        }

        public ICommand OpenWebCommand { get; }
    }
}