using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Marathon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private async void SaveUser(object sender, EventArgs e)
        {
        //    var user = (User)BindingContext;
        //    if (!String.IsNullOrEmpty(user.Name))
        //    {
        //        await App.Database.SaveItemAsync(user);
        //    }
            await this.Navigation.PopAsync();
        }
        private async void DeleteUser(object sender, EventArgs e)
        {
        //    var user = (User)BindingContext;
        //    await App.Database.DeleteItemAsync(user);
            await this.Navigation.PopAsync();
        }
        private async void Cancel(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}