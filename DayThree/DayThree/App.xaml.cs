using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DayThree
{
    public partial class App : Application
    {
        public static string DatabasePath;
        public App(string databasePath)
        {
            InitializeComponent();
            DatabasePath = databasePath;
            MainPage = new MainPage();
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
