using LearnRussian.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LearnRussian
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Application.Current.Resources = new ResourceDictionary();

            var pageStyle = new Style(typeof(ContentPage))
            {
                Setters = {
                    new Setter { Property = Page.BackgroundImageProperty, Value = "background_flag.png"},
                    new Setter { Property = NavigationPage.HasNavigationBarProperty, Value = false },
                },
                ApplyToDerivedTypes = true
            };
            Resources = new ResourceDictionary();
            Resources.Add(pageStyle);

            MainPage = new NavigationPage(new MainPage());

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


    }
}
