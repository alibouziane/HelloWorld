using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopMainPage : ContentPage
    {
        public PopMainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            //var response = await DisplayAlert("Warnning", "Are you Sure", "Yes", "No");
            //if (response)
            //    await DisplayAlert("Done", "Your response will be saved!", "OK");
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");

            await DisplayAlert("Response", response, "OK");

        }
    }
}