using LearnRussian.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LearnRussian.Pages
{
	public class HelpPage : ContentPage
	{
        private HelpPageController _controller;

		public HelpPage ()
		{
            _controller = new HelpPageController(this);

            var lblHeader = new Label()
            {
                Text = "Pomoc",
                FontSize = 28,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0, 10, 0, 50)
            };

            var lblLearning = new Label()
            {
                Style = Styles.SummaryLabelStyle,
                Text = " NAUKA: dotknij litery, aby zobaczyć jej odpowiednik w alfabecie rosyjskim lub fonetyczną"
                + " wymowę. Użyj przycisku ze strzałkami, aby zmieniać litery z rosyjskich na łacińskie"
                + " i odwrotnie.",
                Margin = new Thickness(10,10,10,30)
            };

            var lblTest = new Label()
            {
                Style = Styles.SummaryLabelStyle,
                Text = " TEST: odgaduj znaczenie liter alfabetu rosyjskiego lub odpowiedniki rosyjskie dla"
                + " fonetycznej wymowy (można zmienić w menu opcji). Po dotknięciu przycisku ZATWIERDŹ"
                + "sprawdź, czy Twoja odpowiedź"
                + " była poprawna i dotknij odpowiedni przycisk. Program oblicza statystyki odpowiedzi.",
                Margin = new Thickness(10, 10, 10, 30)
            };

            var btnBack = new Button()
            {
                Style = Styles.ActionButtonStyle,
                Text = "Powrót"
            };
            btnBack.Clicked += _controller.OnBackButtonClicked;

            StackLayout content = new StackLayout()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { lblHeader, lblLearning, lblTest, btnBack }
            };

			Content = new StackLayout {
				Children = {
					content
				}
			};
		}
	}
}