using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SizeYou
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChrisPage : ContentPage
	{
		public ChrisPage ()
		{
			InitializeComponent ();
		}

        private void btnRay_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.Text = "Nope";
            btn = btnAnother;
            btn.Text = "Click Me";
        }

        private void btnChris_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.Text = "Nope";
            btn = btnJames;
            btn.Text = "Click Me";
        }

        private void btnJames_Clicked(object sender, EventArgs e)
        {
            var btn = btnChris;
            btn.Text = "Fuck Off";
            btn = btnRay;
            btn.Text = "Fuck Off";
            btn = btnJames;
            btn.Text = "Fuck Off";
            btn = btnAnother;
            btn.Text = "Fuck Off";
        }

        private void btnAnother_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.Text = "Nope";
            btn = btnChris;
            btn.Text = "Click Me";
        }
    }
}