using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartOakApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void DonationPageLoad(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BloodDonationPage());
        }
    }
}
