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
    public partial class IntroductionPage : ContentPage
    {
        public IntroductionPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            //await Navigation.PopAsync();
            await Navigation.PopModalAsync();//modal page to avoid to navigate to the precedent page
        }
        protected override bool OnBackButtonPressed()
        {
            return true; //disable the back button on phone
        }
    }
}