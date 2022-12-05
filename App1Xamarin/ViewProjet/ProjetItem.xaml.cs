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
    public partial class ProjetItem : ContentPage
    {
        public ProjetItem()
        {
            InitializeComponent();

            FoireV.Source = ImageSource.FromFile("FoireV.png");
            Mag.Source = ImageSource.FromFile("shop.jpg");
            LogoIset.Source = ImageSource.FromFile("logoIset.jfif");
        }

       

        private void Magasin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterDetailPageDemo());
        }

        private void Foire_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoireCarousel());
        }

        private void Iset_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Iset());
        }
    }
}