using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _10DaysOfXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text))
            {
                greetingLabel.Text = $"Hello {nameEntry.Text}, welcome to 10 days of Xamarin!";
            }
            else
            {
                DisplayAlert("Error", "Your name can't be empty", "Oh right");
            }
        }
    }


}
