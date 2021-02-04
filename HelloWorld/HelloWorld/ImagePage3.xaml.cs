using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ImagePage3 : ContentPage
    {
        public ImagePage3()
        {
            InitializeComponent();

            btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(iOS: "clock.png", Android: "clock.png", WinPhone: "Images/clock.png"));

        }
    }
}
