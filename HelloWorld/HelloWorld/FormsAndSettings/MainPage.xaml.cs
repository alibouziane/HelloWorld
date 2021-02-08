using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.FormsAndSettings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private void Switch_OnToggled(object sender, ToggledEventArgs e)
        //{
        //    label.IsVisible = e.Value;
        //}
        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
        }

        private void Entry_OnCompleted(object sender, EventArgs e)
        {
            label.Text = "Completed";
        }

        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            label.Text = e.NewTextValue ;

        }
    }
}