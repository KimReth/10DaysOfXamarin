using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TenDaysOfXamarin.Models;
using SQLite;

namespace TenDaysOfXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckIfShouldBeEnabled()
        {
            saveButton.IsEnabled = false;
            if (!string.IsNullOrWhiteSpace(titleEntry.Text) && !string.IsNullOrWhiteSpace(contentEditor.Text))
                saveButton.IsEnabled = true;
        }

        void TitleEntry_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            CheckIfShouldBeEnabled();
        }

        void ContentEditor_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            CheckIfShouldBeEnabled();
        }

        void SaveButton_Clicked(object sender, System.EventArgs e)
        {
            Experience newExperience = new Experience()
            {
                Title = titleEntry.Text,
                Content = contentEditor.Text,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            int insertedItems = 0;
            //Everytime a new connection is created, it must be closed. Using statement helps ensure this.
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasePath)) 
            {
                conn.CreateTable<Experience>();
                conn.Insert(newExperience);
            }

            if (insertedItems > 0)
            {
                titleEntry.Text = string.Empty;
                contentEditor.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Error", "There was an error inserting the Experience, please try again", "Ok");
            }
        }

        void ContentEntry_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}
