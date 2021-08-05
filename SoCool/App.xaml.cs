using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoCool
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Expander_Experimental", "Shapes_Experimental", "MediaElement_Experimental" });
            MainPage = new LoginShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
