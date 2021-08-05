using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.Xaml;

namespace SoCool.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {

        }

        private void Facebook_Tapped(object sender, EventArgs e)
        {
            doTapAnimation(facebook);
            //login with facebook
        }

        private void instagram_Tapped(object sender, EventArgs e)
        {
            doTapAnimation(instagram);
            //login with instagram
        }

        private async void doTapAnimation(PancakeView view)
        {
            //await Task.Delay(200);
            //await view.FadeTo(0, 250);
            //await Task.Delay(200);
            //await view.FadeTo(1, 250);

            await Task.Delay(100);
            await view.FadeTo(0.3, 100);
            await Task.Delay(100);
            await view.FadeTo(1, 100);
        }

    }
}