using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TexasRangers
{
    public partial class App : Application
    {
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
