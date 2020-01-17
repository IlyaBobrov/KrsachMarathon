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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void SaveUser(object sender, EventArgs e)
        {
            var user = (User)BindingContext;
            if (!String.IsNullOrEmpty(user.Name) && 
                !String.IsNullOrEmpty(user.Login) && 
                !String.IsNullOrEmpty(user.Phone) && 
                !String.IsNullOrEmpty(user.Login))
            {
                App.Database.SaveItem(user);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteUser(object sender, EventArgs e)
        {
            var user = (User)BindingContext;
            App.Database.DeleteItem(user.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}