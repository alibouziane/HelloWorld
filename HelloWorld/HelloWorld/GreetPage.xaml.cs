using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

            var x = new OnPlatform<Thickness>()
            {
                Android = new Thickness(0),
                iOS = new Thickness(0, 20, 0, 0)
            };
            Padding = x;







            //if (Device.OS == TargetPlatform.iOS)
            //    Padding = new Thickness(0, 20, 0, 0);
            //else if (Device.OS == TargetPlatform.Android)
            //    Padding = new Thickness(10, 20, 0, 0);
            //else if (Device.OS == TargetPlatform.WinPhone)
            //    Padding = new Thickness(30, 20, 0, 0);

            //Padding = Device.OnPlatform(iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(10, 20, 0, 0),
            //    WinPhone: new Thickness(30, 20, 0, 0));


            //Device.OnPlatform(iOS: () =>
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //},
            //Android: () =>
            //{
            //    //..
            //});

            //Content = new Label()
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello World"
            //};
        }

        //private void Button_OnClicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Title", "Hello WOrld", "OK");
        //}
        //private void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    label.Text = $"Value is {e.NewValue:F2}";
        //}
    }
}
