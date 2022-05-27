using ResourceApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        DetailPageViewModel _DetailPageViewModel;
        public DetailPage()
        {
            InitializeComponent();

            _DetailPageViewModel = new DetailPageViewModel(this.Navigation);
            this.BindingContext = _DetailPageViewModel;


        }
    }
}