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
    public partial class Developer : ContentPage
    {
        public Developer()
        {
            InitializeComponent();
            
        }
        protected override async void OnAppearing()
        {
            // создание таблицы, если ее нет
            await App.Database.CreateTable();
            // привязка данных
            List_Marathon_t.ItemsSource = await App.Database.GetItemsAsync();

            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Marathon selectedM = (Marathon)e.SelectedItem;
            MarathonPage MPage = new MarathonPage();
            MPage.BindingContext = selectedM;
            await Navigation.PushAsync(MPage);
        }
        // обработка нажатия кнопки добавления
        private async void Button_Clicked_CreateM(object sender, EventArgs e)
        {
            Marathon M = new Marathon();
            RegistrationPage RegistrationM = new RegistrationPage();
            RegistrationM.BindingContext = M;
            await Navigation.PushAsync(RegistrationM);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}