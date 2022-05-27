using MvvmHelpers;
using ResourceApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ResourceApp.ViewModel
{
    public class DetailPageViewModel : BaseViewModel
    {
        public ObservableCollection<Menu> menu { get; set; }
        public ObservableCollection<FilterModel> FilterLists { get; set; }
        public DetailPageViewModel(INavigation nav)
        {
            Navigation = nav;

            AddOptioninPop();
        }

        public void AddOptioninPop()
        {
            FilterLists = new ObservableCollection<FilterModel>();
            FilterLists.Add(new FilterModel
            {
                Icon = "settings",
                Name = "Settings",

            });


            FilterLists.Add(new FilterModel
            {
                Icon = "support",
                Name = "Support",

            });


            FilterLists.Add(new FilterModel
            {
                Icon = "User",
                Name = "Profile",

            });
            
            FilterLists.Add(new FilterModel
            {
                Icon = "heart",
                Name = "Wishlist",

            });


           
        }




    }
}