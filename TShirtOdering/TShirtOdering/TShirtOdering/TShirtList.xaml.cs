using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtLibrary;
using TShirtOdering;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TShirtOderingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TShirtList : ContentPage
    {
        public List<TShirt> TShirtOrders { get; set; }


        public TShirtList()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var tshirtDatabase = App.Database;
            TShirtOrders = await tshirtDatabase.GetItemsAsync();
            BindingContext = this;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuyTShirts());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {

            var placemark = new Placemark
            {
                CountryName = "United States",
                AdminArea = "WA",
                Thoroughfare = "Microsoft Building 25",
                Locality = "Redmond"
            };
            var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

            await Map.OpenAsync(placemark, options);
        }
  
    
    
    
    
    
    
    
    
    }


}

        
    
    
    
    
    
    
    
    
    
