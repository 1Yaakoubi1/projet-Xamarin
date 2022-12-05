using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1Xamarin.ModelProjet;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin.ViewProjet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListUtilisateur : ContentPage
    {
        private  ObservableCollection<User> USERS;
        public ListUtilisateur()
        {
            InitializeComponent();

//            USERS = new ObservableCollection<User>
//            {
//new User{nom="fares", email="fares@", mdp="123"},
//new User{nom="chaima", email="chaima@", mdp="100"},
//            };


//            listUtilisateurs.ItemsSource = USERS;
        }


        // rafraichir la liste 
        protected async override void OnAppearing()
        {
            listUtilisateurs.ItemsSource = await App.database.GetUSERSAsync();

        }


        

        private void btnAjout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AjoutUtilisateur());
        }

        //private async void supprimer_Clicked(object sender, EventArgs e)
        //{
        //    var menuItem = sender as MenuItem;
        //    var utilisateur = menuItem.CommandParameter as User;
        //    await App.database.DeleteUserAsync(utilisateur);
        //    //USERS.Remove(utilisateur);
        //    OnAppearing();
        //}

       

        private async void supprimer_Clicked(object sender, EventArgs e)
        {
            var btnSupprimer = sender as Button;
            var utilisateur = btnSupprimer.CommandParameter as User;
            await App.database.DeleteUserAsync(utilisateur);
            //USERS.Remove(utilisateur);
            OnAppearing();
        }



        //private void btnDelete_Clicked(object sender, EventArgs e)
        //{
        //    //var menuItem = sender as MenuItem;
        //    var utilisateur = menuItem.CommandParameter as User;
        //    USERS.Remove(utilisateur);


        //}

    }
}

