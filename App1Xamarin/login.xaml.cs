using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        public void afficher(object sender, EventArgs e)
        {
            txtLOG.Text = "LOGIN :" + txtName.Text;
            txtLOG.BackgroundColor = Color.Gray;
              }
    }
}