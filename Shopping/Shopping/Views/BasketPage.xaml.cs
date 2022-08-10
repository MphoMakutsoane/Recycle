using System;
using Xamarin.Forms;

namespace Recycle.Views
{
    public partial class BasketPage : ContentPage
    {
        public BasketPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new MapsPage());
        }
    }
}
