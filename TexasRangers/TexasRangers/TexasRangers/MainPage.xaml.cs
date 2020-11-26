using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


//MAIN PAGE BUTTONS
namespace TexasRangers
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        //OPENS FOOD MENU
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
    }
}
