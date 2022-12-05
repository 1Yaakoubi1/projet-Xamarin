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
    public partial class UpdateMdpPage : ContentPage
    {
        public UpdateMdpPage()
        {
            InitializeComponent();

            TapGestureRecognizer labTap = new TapGestureRecognizer();
            labTap.Tapped += (sender, e) =>
            {
                Navigation.PushAsync(new AjoutUtilisateur());
            };

           LabConnect.GestureRecognizers.Add(labTap);
        }



     

        private async void UpdateMdp_Clicked(object sender, EventArgs e)
        {
            var test = await App.database.FindUserLogin(txtName.Text);
            if ((txtConfirmNouveauMdp.Text == txtNouveauMdp.Text)&&(test != null))
            {
                User U = new User { nom = txtName.Text, mdp = txtNouveauMdp.Text };

                await App.database.SaveUserAsync(U);

                await DisplayAlert("Update", "Mot de passe modifié avec succès", "ok");

                //await Navigation.PopAsync();
               await Navigation.PushAsync(new ProjetLogin());
            }
            else
            {
                await DisplayAlert("Erreur", "Les mots de passe que vous avez entrés ne sont pas identiques!!!", "ok");
            }
        }
    }
}