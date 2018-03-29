using System;
using System.Collections.Generic;
using quizzApp_AstonProject.MenuItems;
using quizzApp_AstonProject.Pages;

using Xamarin.Forms;

namespace quizzApp_AstonProject.PageMenu
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }

        public MainPage()
        {
            InitializeComponent();
            base.BackgroundColor = Color.FromHex("#FFB864"); 

            menuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "Accueil", TargetType = typeof(HomePage) };
            var page2 = new MasterPageItem() { Title = "Quizz", TargetType = typeof(QuizzPage) };
            var page3 = new MasterPageItem() { Title = "Créer", TargetType = typeof(AddQuizzPage) };
            var page4 = new MasterPageItem() { Title = "Importer", TargetType = typeof(AddQuizzPage) };
            var page5 = new MasterPageItem() { Title = "Profil", TargetType = typeof(ProfilePage) };

            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);

            navigationDrawerList.ItemsSource = menuList;
            navigationDrawerList.SeparatorColor = Color.FromHex("#C0CCDA");

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage))) { BarBackgroundColor = Color.FromHex("#FFB864"), BarTextColor = Color.White };
       
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page)) { BarBackgroundColor = Color.FromHex("#FFB864"), BarTextColor = Color.White };
            IsPresented = false;
        }

        private async void OnDecoSelect(object sender, System.EventArgs args)
        {
            var answer = await DisplayAlert("Déconnexion", "Voulez-vous vraiment vous déconnecter ?", "Oui", "Non");
            if (answer)
            {
                await Navigation.PushAsync(new ConnectionPage() { });
            }
        }

        private async void OnContactUsSelect(object sender, System.EventArgs args)
        {
            await DisplayAlert("Comment nous contacter ?", "Adresse email : quizzApp.infos@dev.com", "Ok");
        }

    }
}
