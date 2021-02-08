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
    public partial class MainPage1 : ContentPage
    {
        private IList<ContactMethod> _contactMethods;
        public class ContactMethod
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }



        public MainPage1()
        {
            InitializeComponent();
            _contactMethods = GetContactMethods();

            foreach (var method in _contactMethods)
            {
                picker.Items.Add(method.Name);
            }
        }

        //private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var contactMethod = contactMethods.Items[contactMethods.SelectedIndex];
        //    DisplayAlert("Selection", contactMethod, "OK");
        //}

        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker.Items[picker.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);


            DisplayAlert("Selection", name, "OK");
        }


        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>()
            {
                new ContactMethod() {Id = 1, Name = "SMS"},
                new ContactMethod() {Id = 2, Name = "EMAIL"},
            };
        }

       
    }
}