using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.InstagramApp
{
    public partial class UserProfilePage : ContentPage
    {
        private UserService _service = new UserService();

        public UserProfilePage(int userId)
        {
            BindingContext = _service.GetUser(userId);

            InitializeComponent();
        }
    }
}