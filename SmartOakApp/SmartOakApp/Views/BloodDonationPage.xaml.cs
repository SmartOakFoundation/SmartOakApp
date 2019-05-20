using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SmartOakApp.BloodDonation;
using SmartOakApp.BloodDonationDataSource;
namespace SmartOakApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BloodDonationPage : ContentPage
	{
		public BloodDonationPage ()
		{
			InitializeComponent ();
            Data data = new Data();
            MainListView.ItemsSource = data.Entries();
		}
	}
}