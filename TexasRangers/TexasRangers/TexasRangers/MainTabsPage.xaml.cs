using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TexasRangers.Models;


//TABBED PAGES BUTTONS
namespace TexasRangers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabsPage : TabbedPage
    {
        public MainTabsPage()
        {
            InitializeComponent();
        }


        // OPENS FOOD MENU
        private async void FoodMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodMenuPage());
        }


        //OPENS DRINKS MENU
        private async void DrinksMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrinksMenuPage());
        }


        //OPENS DESSERTS MENU
        private async void DessertsMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DessertsMenuPage());
        }

        async void NewBooking_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookingEntryPage
            {
                BindingContext = new Booking()
            });
        }

        async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new BookingEntryPage
                {
                    BindingContext = e.SelectedItem as Booking
                });
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetBookingAsync();
        }
    }

}