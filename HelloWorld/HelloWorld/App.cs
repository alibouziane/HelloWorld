using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloWorld.MvvmDemo.Views;
using Xamarin.Forms;

namespace HelloWorld
{
    public class App : Application
    {
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";

        public App()
        {

            //MainPage = new ListExercisePage();
            //MainPage = new NavigationPage(new WelcomePage())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};

            //MainPage = new NavigationPage(new ContactsPage());
            //MainPage = new NavigationPage(new InstagramApp.MainPage());
            //MainPage = new FormsAndSettings.MainPage();
            //MainPage = new NavigationPage(new FormsAndSettings.MainPage2());
            //MainPage =  new NavigationPage(new NetFlixRoulette.Views.MoviesPage());
            MainPage = new NavigationPage(new PlaylistsPage());
            //MainPage = new NavigationPage(new MvvmContactBook.Views.ContactsPage());




        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();
                return "";

            }
            set
            {
                Properties[TitleKey] = value;

            }
        }

        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                    return (bool)Properties[NotificationsEnabledKey];
                return false;

            }
            set
            {
                Properties[NotificationsEnabledKey] = value;

            }
        }
    }
}
