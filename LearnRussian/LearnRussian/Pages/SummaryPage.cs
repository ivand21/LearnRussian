using LearnRussian.Controllers;
using LearnRussian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LearnRussian.Pages
{
	public class SummaryPage : ContentPage
	{
        public Score Score { get; set; }
        private SummaryPageController _controller;

		public SummaryPage(Score score)
		{
            _controller = new SummaryPageController(this);
            Score = score;

            var lblScoreHeader = new Label()
            {
                FontSize = 24,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0,0,0,30),
                Text = "Twój wynik:"                
            };

            var lblTotalAnswers = new Label()
            {
                Style = Styles.SummaryLabelStyle,
                Text = "Ilość pytań: " + score.TotalAnswers
            };

            var lblCorrectAnswers = new Label()
            {
                Style = Styles.SummaryLabelStyle,
                Text = "Dobrych odpowiedzi: " + score.GoodAnswers
            };

            var lblWrongAnswers = new Label()
            {
                Style = Styles.SummaryLabelStyle,
                Text = "Złych odpowiedzi: " + score.WrongAnswers
            };

            var lblPercent = new Label()
            {
                Style = Styles.SummaryLabelStyle,
                Text = "Procent dobrych odpowiedzi: " + score.Percent.ToString("F1") + "%"
            };

            var btnEnd = new Button()
            {
                Style = Styles.ActionButtonStyle,
                Text = "Menu główne",
                WidthRequest = 200
            };
            btnEnd.Clicked += _controller.OnEndButtonClicked;

            var labels = new StackLayout()
            {
                Margin = new Thickness(0, 0, 0, 100),
                Children = { lblScoreHeader, lblTotalAnswers, lblCorrectAnswers, lblWrongAnswers, lblPercent }
            };

            var body = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = { labels, btnEnd }
            };

            Content = new StackLayout {
				Children = { body }				
			};
		}
	}
}