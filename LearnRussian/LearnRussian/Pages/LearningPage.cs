using LearnRussian.Model;
using LearnRussian.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LearnRussian.Pages
{
	public class LearningPage : ContentPage
	{
        private LearningPageController _controller;
        private Grid _buttons;

        public AlphabetType CurrentAlphabet { get; set; }

		public LearningPage ()
		{
            _controller = new LearningPageController(this); 

            var layout = new StackLayout();

            var menu = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
            };

            var body = new StackLayout()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var btnSwapAlphabet = new Image()
            {
                Margin = new Thickness(10,0,0,0),
                Source = "icon_swap.png",
            };
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += _controller.OnSwapButtonClicked;
            btnSwapAlphabet.GestureRecognizers.Add(tapGestureRecognizer);

            var btnBack = new Button()
            {
                Style = Styles.ActionButtonStyle,
                Text = "Powrót",
            };
            btnBack.Clicked += _controller.OnBackButtonClicked;

            _buttons = BuildGrid();
            SetAlphabet(AlphabetType.Russian);

            menu.Children.Add(btnSwapAlphabet);
            menu.Children.Add(btnBack);
            body.Children.Add(_buttons);
            layout.Children.Add(menu);
            layout.Children.Add(body);

            Content = layout;
		}

        private Grid BuildGrid()
        {
            int numCols = 6;
            int numRows = Alphabet.Cyryllic.Length / numCols + 1;

            var grid = new Grid()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            for (int i = 0; i < numRows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(60, GridUnitType.Auto) });
            }

            for (int i = 0; i < numCols; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(100, GridUnitType.Auto) });
            }

            for (int i = 0; i < Alphabet.Cyryllic.Length; i++)
            {
                var btn = new Button() { Style = Styles.ButtonLetterStyle };
                btn.Clicked += _controller.OnLetterButtonClicked;
                grid.Children.Add(btn, i % numCols, i / numRows);
            }

            return grid;
        }

        public void SetAlphabet(AlphabetType alph)
        {
            var letters = _buttons.Children;
            int i = 0;

            foreach (var c in _buttons.Children)
            {
                var btn = c as Button;
                if (btn != null)
                {
                    if (alph == AlphabetType.Latin)
                        btn.Text = Alphabet.Phonetic[i];
                    else
                        btn.Text = Alphabet.Cyryllic[i].ToString();

                    i++;
                }
            }

            CurrentAlphabet = alph;
        }

    }
}