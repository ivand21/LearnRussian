using LearnRussian.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnRussian.Pages
{
    public partial class MainPage : ContentPage
    {
        private MainPageController _controller;
        public OptionsPage SettingsPage { get; set; }

        public MainPage()
        {
            _controller = new MainPageController(this);
            SettingsPage = new OptionsPage();

            var layout = new StackLayout();

            var menu = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };


            var btnLearning = new Button
            {
                Style = Styles.MenuButtonStyle,
                Text = "Nauka",
            };

            var btnTest = new Button
            {
                Style = Styles.MenuButtonStyle,
                Text = "Test",
            };

            var btnOptions = new Button
            {
                Style = Styles.MenuButtonStyle,
                Text = "Opcje",
            };

            var btnAbout = new Button
            {
                Style = Styles.MenuButtonStyle,
                Text = "O autorze",
            };

            var btnHelp = new Button
            {
                Style = Styles.MenuButtonStyle,
                Text = "Pomoc",
            };

            layout.Children.Add(menu);

            menu.Children.Add(btnLearning);
            menu.Children.Add(btnTest);
            menu.Children.Add(btnOptions);
            menu.Children.Add(btnAbout);
            menu.Children.Add(btnHelp);

            btnLearning.Clicked += _controller.OnLearningButtonClicked;
            btnTest.Clicked += _controller.OnTestButtonClicked;
            btnOptions.Clicked += _controller.OnOptionsButtonClicked;
            btnAbout.Clicked += _controller.OnAboutButtonClicked;
            btnHelp.Clicked += _controller.OnHelpButtonClicked;

            Content = layout;
            //BackgroundImage = "background_flag.png";
        }
    }
}
