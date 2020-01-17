﻿using System;
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
        protected override void OnAppearing()
        {
            UsersList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            User selectedFriend = (User)e.SelectedItem;
            UserPage friendPage = new UserPage();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }
        // обработка нажатия кнопки добавления
        
        private async void CreateUser(object sender, EventArgs e)
        {
            User user = new User();
            RegistrationPage NewUserPage = new RegistrationPage();
            NewUserPage.BindingContext = user;
            await Navigation.PushAsync(NewUserPage);
        }

    }
}