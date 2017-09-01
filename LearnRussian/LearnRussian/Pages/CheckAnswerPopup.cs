using LearnRussian.Controllers;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LearnRussian.Pages
{
    public class CheckAnswerPopup : PopupPage
    {
        private CheckAnswerPopupController _controller;
        public bool IsAnswerCorrect { get; set; }

        public CheckAnswerPopup(string correctAnswer, TestPageController parent)
        {
            _controller = new CheckAnswerPopupController(this, parent);

            var lblCorrectAnswer = new Label()
            {
                Style = Styles.SummaryLabelStyle,
                Text = "Prawidłowa odpowiedź: " + correctAnswer
            };

            var imgGood = new Image()
            {
                Source = "ok_icon.png",
                Margin = new Thickness(10, 30, 10, 0),
            };
            var tgrGood = new TapGestureRecognizer();
            tgrGood.Tapped += _controller.OnGoodAnswerButtonClicked;
            imgGood.GestureRecognizers.Add(tgrGood);


            var imgWrong = new Image()
            {
                Source = "wrong_icon.png",
                Margin = new Thickness(10, 30, 10, 0),
            };
            var tgrWrong = new TapGestureRecognizer();
            tgrWrong.Tapped += _controller.OnWrongAnswerButtonClicked;
            imgWrong.GestureRecognizers.Add(tgrWrong);


            var info = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                Children = { lblCorrectAnswer }
            };

            var buttons = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children = { imgGood, imgWrong }
            };

            var content = new StackLayout()
            {
                BackgroundColor = Color.LightGray,
                Padding = new Thickness(50, 50, 50, 50),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { info, buttons }
            };


            Content = new StackLayout
            {
                Children = {
                    content
                }
            };
        }

        protected override bool OnBackgroundClicked()
        {
            return base.OnBackgroundClicked();
        }

    }
}