using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace quizzApp_AstonProject
{
    public partial class ConnectionPage : ContentPage
    {
        public ConnectionPage()
        {
            InitializeComponent();
        }

        public async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new RegistrationPage()));
        }

        public async void OnLoginButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new HomePage()));
        }
    }
}
