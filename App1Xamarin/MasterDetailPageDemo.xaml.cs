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
    public partial class MasterDetailPageDemo : MasterDetailPage
    {
        public MasterDetailPageDemo()
        {
            InitializeComponent();
        }

       

        private void Vetements_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Vetement());
            IsPresented = false;
        }

        private void Accessoires_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Accessoires());
            IsPresented = false;
        }

        private void Electroménager_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Electromenager());
            IsPresented = false;
        }
    }
}