using LearnRussian.Controllers;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LearnRussian.Pages
{
    public class LearningLetterPopup : PopupPage
    {
        private LearningLetterPopupController _controller;

        public LearningLetterPopup(string latin, string cyryllic)
        {
            _controller = new LearningLetterPopupController(this);

            var lblCyryllic = new Label()
            {
                Style = Styles.TestLabelStyle,
                Text = cyryllic
            };

            var lblPhonetic = new Label()
            {
                Style = Styles.SummaryLabelStyle,
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
                Text = "[ " + latin + " ]"
            };

            var btnOk = new Button()
            {
                Style = Styles.ActionButtonStyle,
                Text = "Powrót"
            };
            btnOk.Clicked += _controller.OnOkButtonClicked;

            var content = new StackLayout()
            {
                BackgroundColor = Color.LightGray,
                Padding = new Thickness(50,50,50,50),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { lblCyryllic, lblPhonetic, btnOk }
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