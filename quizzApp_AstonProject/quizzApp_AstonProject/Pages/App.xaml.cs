using Xamarin.Forms;
using quizzApp_AstonProject.Pages;

namespace quizzApp_AstonProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage c = new NavigationPage(new ConnectionPage());
            c.BarBackgroundColor = Color.FromHex("#FFB864");

            MainPage = c;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
