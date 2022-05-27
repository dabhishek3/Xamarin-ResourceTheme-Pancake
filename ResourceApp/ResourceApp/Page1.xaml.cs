using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

       

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Themechangepage());
        }
    }
}