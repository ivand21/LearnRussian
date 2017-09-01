using LearnRussian.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LearnRussian.Pages
{
	public class AboutPage : ContentPage
	{
        private AboutPageController _controller;

        public AboutPage()
        {
            _controller = new AboutPageController(this);

            Label lblCredits = new Label()
            {
                Text = "Created by Jan Dąbrowski (Ivand)",
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black
            };

            Button btnBack = new Button()
            {
                Text = "Powrót",
                Style = Styles.ActionButtonStyle
            };
            btnBack.Clicked += _controller.OnBackButtonClicked;

            StackLayout body = new StackLayout()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {lblCredits,btnBack}
            };


            Content = new StackLayout {
				Children = {
					body
				}
			};
		}
	}
}