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
    public partial class FlyoutPage1 : FlyoutPage
    {
        public FlyoutPage1()
        {
            InitializeComponent();
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyoutPage1FlyoutMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            FlyoutPage.ListView.SelectedItem = null;
        }

        async private void BtnPush(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlyoutPage1()) ;
        }

        async private void BtnPop(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void BtnPushModal(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MasterDetailPageDemo());
        }

        async private void BtnPopModal(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }



    }
}