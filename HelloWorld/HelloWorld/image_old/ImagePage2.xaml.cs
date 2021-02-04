using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ImagePage2 : ContentPage
    {
        public ImagePage2()
        {
            InitializeComponent();
            image.Source = ImageSource.FromResource("HelloWorld.Images.background.jpg");
        }
    }
}
