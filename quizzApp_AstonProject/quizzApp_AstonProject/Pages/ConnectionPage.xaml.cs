using System;
using System.Collections.Generic;
using quizzApp_AstonProject.PageMenu;
using Xamarin.Forms;

namespace quizzApp_AstonProject.Pages
{
    public partial class ConnectionPage : ContentPage
    {
        public ConnectionPage()
        {
            InitializeComponent();
        }

        public async void GoToRegistrationPage(object sender, System.EventArgs args)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        public async void OnLoginButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
            Navigation.RemovePage(this);
        }

        public async void OnLoginFacebookButtonClicked(object sender, System.EventArgs e)
        {
            //await Navigation.PushAsync(new HomePage());
            var answer = await DisplayAlert("Facebook", "Créer un compte à partir de Facebook", "Ok", "Annuler");
            if(answer)
            {
                await DisplayAlert("Facebook", "Compte créé avec succès", "Fermer");
            }
        }

        public async void OnLoginTwitterButtonClicked(object sender, System.EventArgs e)
        {
            //await Navigation.PushAsync(new HomePage());
            var answer = await DisplayAlert("Twitter", "Créer un compte à partir de Twitter", "Ok", "Annuler");
            if (answer)
            {
                await DisplayAlert("Twitter", "Compte créé avec succès", "Fermer");
            }
        }

        public async void OnLoginGoogleButtonClicked(object sender, System.EventArgs e)
        {
            //await Navigation.PushAsync(new HomePage());
            var answer = await DisplayAlert("Google", "Créer un compte à partir de Google", "Ok", "Annuler");
            if (answer)
            {
                await DisplayAlert("Google", "Compte créé avec succès", "Fermer");
            }
        }

        public async void GetInfos(object sender, System.EventArgs e)
        {
            await DisplayAlert("Comment nous contacter ?", "Adresse email : quizzApp.infos@dev.com", "Ok");
        }
    }
}
