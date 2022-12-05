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
    public partial class PageTest : ContentPage
    {
        public PageTest()
        {
            InitializeComponent();
        }

        public void Display(Object sender, EventArgs e)
        {
            lblMessage.Text = "Welcome." + txtName.Text;
            lblMessage.TextColor = Color.Purple;
            lblMessage.BackgroundColor = Color.Pink;


        }
    }
}





