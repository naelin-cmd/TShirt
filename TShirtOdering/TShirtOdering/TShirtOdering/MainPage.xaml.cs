using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TShirtLibrary;
using TShirtOdering;

namespace TShirtOderingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var TShirt = new TShirt();
            BindingContext = TShirt;
        }
        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var tshirtDatabase = (TShirt)BindingContext;
            await App.Database.SaveItemAsync(tshirtDatabase);
            await Navigation.PushAsync(new TShirtList());
        }
       
     

        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuyTShirts());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TShirtList());
        }
    }
}