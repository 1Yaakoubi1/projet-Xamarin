using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using App1Xamarin.ViewProjet;
using App1Xamarin.ModelProjet;
using Xamarin.Essentials;

namespace App1Xamarin
{
    public partial class App : Application
    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "userProjet.db3");
        public static UserDatabase database { get; private set; }
        public App()
        {
            InitializeComponent();

            database = new UserDatabase(dbPath);

            MainPage = new NavigationPage(new ListUtilisateur());

            //MainPage = new AjoutContact();
            // MainPage = new NavigationPage(new ContactPage());

            //MainPage = new ProjetLogin();
            //MainPage = new ProjetItem();
            //MainPage = new FoireCarousel();


            //MainPage = new StackLayoutDemo();
            //MainPage = new PageTest();
            // MainPage = new login();
            //MainPage = new MasterDetailPageDemo();
            //MainPage = new NavigationPage(new Nav());
            //MainPage = new NavigationPage(new FlyoutPage1());
            //MainPage = new Iset();
            // MainPage = new CarouselDemo();

            //MainPage = new FlyoutPage1();

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
