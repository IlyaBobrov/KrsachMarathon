using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Marathon
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "userss.db";
        public static UsersClassRepository database;
        public static UsersClassRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new UsersClassRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
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
