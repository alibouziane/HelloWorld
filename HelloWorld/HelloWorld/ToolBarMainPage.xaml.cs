using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolBarMainPage : ContentPage
    {
        public ToolBarMainPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_OnActivated(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem activated", "OK");
        }
    }
}