using System;
using System.IO;
using TShirtLibrary;
using TShirtOderingApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TShirtOdering
{
    public partial class App : Application
    {
        static TShirtDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BuyTShirts());
        }
        public static TShirtDatabase Database
        
            {
                get
            { 
                    {
                    if (database==null)
                    {
                        database = new TShirtDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TShirtOderingSQlite.db3"));
                    }
                    return database;

                }
            }
        }
        public int ResumeAtTShirtOrdering { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
