using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1Xamarin.ModelProjet;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin.ViewProjet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AjoutUtilisateur : ContentPage
    {
        public AjoutUtilisateur()
        {
            InitializeComponent();

            TapGestureRecognizer labTap = new TapGestureRecognizer();
            labTap.Tapped += (sender, e) => {
                Navigation.PushAsync(new ProjetLogin());
                } ;

            LabConnect.GestureRecognizers.Add(labTap);
        }

        

        private  async void Enregister_Clicked(object sender, EventArgs e)

        {
            var test = await App.database.FindUser(txtName.Text, txtMdp.Text);

            if ((txtMdp.Text== txtConfirmMdp.Text)&& (test == null))
            {
                User U = new User {nom=txtName.Text,email=txtEmail.Text,mdp=txtMdp.Text};

                await App.database.SaveUserAsync(U);

                await DisplayAlert("Ajout", "Utilisateur ajouté", "ok");

                await Navigation.PopAsync();
            }

            else if (test != null)
            {
                await DisplayAlert("Erreur", "Utilisateur existe déjà!!!", "ok");
            }
            else 
            {
                await DisplayAlert("Erreur", "Les mots de passe que vous avez entrés ne sont pas identiques!!!", "ok");
            }
        }

        private void ListUser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListUtilisateur());
        }


       
    }
}