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
    public partial class Nav : ContentPage
    {
        public Nav()
        {
            InitializeComponent();
            btnPush.Clicked += (sender, e) => { Navigation.PushAsync(new MasterDetailPageDemo()); };
        }
    }
}