using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SimpleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            try
            {
                await Browser.OpenAsync(new Uri("https://internship.zuri.team"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception)
            {
                await DisplayAlert("Alert", "Could not open browser", "Ok");
            }
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            DisplayView.Opacity = 0;
            DisplayView.IsVisible = true;
            await DisplayView.FadeTo(1, 200);
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await DisplayView.FadeTo(0,200);
            DisplayView.IsVisible = false;
        }
    }
}
