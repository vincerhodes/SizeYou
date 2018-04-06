using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SizeYou
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

        }

        private async void btnRay_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RaysPage());
        }

        private async void btnChris_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChrisPage());
        }

        private async void btnJames_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JamesPage());
        }

        private async void btnAnother_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnotherPage());
        }
    }
}
