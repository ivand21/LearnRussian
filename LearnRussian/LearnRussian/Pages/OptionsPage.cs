using LearnRussian.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LearnRussian.Pages
{
	public class OptionsPage : ContentPage
	{
        private OptionsPageController _controller;

		public OptionsPage ()
		{
            _controller = new OptionsPageController(this);

            Label lblAlphQuestionDescription = new Label()
            {
                Text = "Łaciński -> cyrylica",
                Style = Styles.SummaryLabelStyle
            };

            Switch questionAlphSwitch = new Switch();
            questionAlphSwitch.Toggled += _controller.OnAlphSwitchToggled;

            Button btnBack = new Button()
            {
                Text = "Powrót",
                Style = Styles.ActionButtonStyle
            };
            btnBack.Clicked += _controller.OnBackButtonClicked;

            StackLayout alphQuestion = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center,
                Children = { lblAlphQuestionDescription, questionAlphSwitch }
            };

            StackLayout body = new StackLayout()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { alphQuestion, btnBack }
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