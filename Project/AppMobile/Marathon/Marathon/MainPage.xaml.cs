using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Marathon
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Profile(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserPage());
        }

        private void Button_Clicked_EE(object sender, EventArgs e)
        {
            
        }

        private async void Button_Clicked_Test_UR(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarathonPage());
        }

        private async void Button_Clicked_Admin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminPage());

        }

        private async void Button_Clicked_Reg(object sender, EventArgs e)
        {
            //User user = new User();
            //RegistrationPage NewUserPage = new RegistrationPage();
            //NewUserPage.BindingContext = user;
            //await Navigation.PushAsync(new RegistrationPage());

        }

        private async  void Button_Clicked_Users(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListUsers());

        }
    }
}
