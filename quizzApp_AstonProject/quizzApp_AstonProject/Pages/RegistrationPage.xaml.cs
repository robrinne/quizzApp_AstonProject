using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace quizzApp_AstonProject.Pages
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        public async void GoToConnectionPageAfterInscritpion(object sender, System.EventArgs args)
        {
            var answer = await DisplayAlert("Inscription", "Votre compte à bien été créé", "Ok", "Annuler");
            if (answer)
            {
                await DisplayAlert("QuizzApp", "Vous devez valider votre adresse mail pour vous connectez ", "Fermer");
                await Navigation.PushAsync(new ConnectionPage());
            }
        }

        public async void GoToConnectionPage(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConnectionPage());
           
        }

        public async void GetInfos(object sender, System.EventArgs e)
        {
            await DisplayAlert("Comment nous contacter ?", "Adresse email : quizzApp.infos@dev.com", "Ok");
        }




    }
}
