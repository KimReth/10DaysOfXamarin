using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDaysOfXamarin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TenDaysOfXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExperiencesPage : ContentPage
    {
        public ExperiencesPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked (object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ReadExperiences();
        }
        private void ReadExperiences()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Experience>();
                List<Experience> experiences = conn.Table<Experience>().ToList();
                experiencesListView.ItemsSource = experiences;
            }
        }
    }
}