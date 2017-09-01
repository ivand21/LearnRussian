using LearnRussian.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LearnRussian.Pages
{
    public class TestPage : ContentPage
    {
        private TestPageController _controller;
        public Label Question { get; set; }

        
        public TestPage()
        {
            _controller = new TestPageController(this);

            Question = new Label()
            {
                Style = Styles.TestLabelStyle,
                Text = _controller.RandomLetter()
            };

            var btnApply = new Button()
            {
                Style = Styles.ActionButtonStyle,
                Text = "Zatwierdź",
                WidthRequest = 200
            };
            btnApply.Clicked += _controller.OnApplyButtonClicked;

            var btnEnd = new Button()
            {
                Style = Styles.ActionButtonStyle,
                Text = "Koniec",
                WidthRequest = 200
            };
            btnEnd.Clicked += _controller.OnEndButtonClicked;

            var body = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = { Question, btnApply, btnEnd }
            };

            Content = new StackLayout
            {
                Children = {
                    body
                }
            };
        }
    }
}