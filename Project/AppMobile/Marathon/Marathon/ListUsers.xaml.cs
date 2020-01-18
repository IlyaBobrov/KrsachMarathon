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
    public partial class ListUsers : ContentPage
    {
        public ListUsers()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            //создание таблицы, если ее нет
            await App.Database.CreateTable();
            //привязка данных
            List_Users_t.ItemsSource = await App.Database.GetItemsAsync();
            //
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            User selectedUser = (User)e.SelectedItem;
            UserPage UserPage = new UserPage();
            UserPage.BindingContext = selectedUser;
            await Navigation.PushAsync(UserPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateUser(object sender, EventArgs e)
        {
            User User = new User();
            RegistrationPage RegistrationUser = new RegistrationPage();
            RegistrationUser.BindingContext = User;
            await Navigation.PushAsync(RegistrationUser);
        }

    }
}