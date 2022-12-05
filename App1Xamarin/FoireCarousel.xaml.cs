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
    public partial class FoireCarousel : CarouselPage
    {
        public FoireCarousel()
        {
            InitializeComponent();
            Voiture1.Source = ImageSource.FromFile("CHERYTIGGO.jfif");
            Voiture2.Source = ImageSource.FromFile("HYUNDAII20.jfif");
            Voiture3.Source = ImageSource.FromFile("TOYOTAPRADO.jfif");
            Voiture4.Source = ImageSource.FromFile("WALLYSCAR619.jfif");

        }
    }
}