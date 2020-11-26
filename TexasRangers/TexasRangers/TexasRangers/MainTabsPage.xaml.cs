using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


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
    }
}