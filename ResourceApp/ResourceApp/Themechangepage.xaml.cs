using ResourceApp.Theme;
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
    public partial class Themechangepage : ContentPage
    {
        public Themechangepage()
        {
            InitializeComponent();
        }

        private void darkmodetapped(object sender, EventArgs e)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new DarkTheme());
                Darkmode.IsVisible = false;
                Lightmode.IsVisible = true;
            }
        }

        private void lightmodetapped(object sender, EventArgs e)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new LightTheme());
                Darkmode.IsVisible = true;
                Lightmode.IsVisible = false;
            }
        }
    }
}