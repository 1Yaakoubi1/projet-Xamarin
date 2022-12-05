using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1Xamarin.ModelProjet;
using App1Xamarin.ViewProjet;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjetLogin : ContentPage
    {
        public ProjetLogin()
        {
            InitializeComponent();

            TapGestureRecognizer labTap = new TapGestureRecognizer();
            labTap.Tapped += (sender, e) =>
            {
                Navigation.PushAsync(new UpdateMdpPage());
            };

            mdpUpdate.GestureRecognizers.Add(labTap);
        }


        private async void Connect_Clicked(object sender, EventArgs e)

        {
            var test = await App.database.FindUser(txtName.Text, txtMdp.Text);
            if (test != null)
            {
                await Navigation.PushAsync(new ProjetItem());
            }

            else
            {
                await DisplayAlert("Erreur", "le nom d'utilisateur ou le mot de passe est incorrect!!!", "ok");
            }

        }


    }
}
