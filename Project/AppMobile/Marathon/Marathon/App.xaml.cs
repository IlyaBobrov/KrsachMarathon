using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Marathon
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("##FFF5F5F5"),
                BarTextColor = Color.FromHex("#FF808080")
            };
            
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
