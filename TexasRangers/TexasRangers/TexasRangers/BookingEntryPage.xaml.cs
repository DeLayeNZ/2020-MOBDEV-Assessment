using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TexasRangers.Models;
using System.IO;

namespace TexasRangers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingEntryPage : ContentPage
    {
        public BookingEntryPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var booking = (Booking)BindingContext;
            booking.Date = DateTime.UtcNow;
            await App.Database.SaveBookingAsync(booking);
            await Navigation.PopAsync();
        }

        //THIS IS THE DELETE BUTTON
        async void Button_Clicked_1(object sender, EventArgs e)
        {
            var booking = (Booking)BindingContext;
            await App.Database.DeleteBookingAsync(booking);
            await Navigation.PopAsync();
        }
    }
}