using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TexasRangers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabsPage : TabbedPage
    {
        public MainTabsPage()
        {
            InitializeComponent();
        }

        private async void FoodMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodMenuPage());
        }

        private async void DrinksMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrinksMenuPage());
        }
    }
}