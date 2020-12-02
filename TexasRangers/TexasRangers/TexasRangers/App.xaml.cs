using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TexasRangers.Data;
using System.IO;

namespace TexasRangers
{
    public partial class App : Application
    {
        static BookingDatabase database;

        public static BookingDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new BookingDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new MainPage());
           // tabbedPage.Children.Add(new ());
            //tabbedPage.Children.Add(new ());
            MainPage = new NavigationPage (new MainTabsPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
