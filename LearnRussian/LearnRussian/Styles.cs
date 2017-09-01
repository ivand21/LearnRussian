using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LearnRussian
{
    public static class Styles
    {
        public static readonly int BUTTON_LETTER_SIZE = 50;

        public static readonly Style MenuButtonStyle = new Style(typeof(Button))
        {
            Setters =
            {
                new Setter {Property = Button.BackgroundColorProperty, Value = Color.FromHex("#2a2533")},
                new Setter {Property = Button.TextColorProperty, Value = Color.White},
                new Setter {Property = Button.VerticalOptionsProperty, Value = LayoutOptions.FillAndExpand },
                new Setter {Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand }
            }
        };

        public static readonly Style ActionButtonStyle = new Style(typeof(Button))
        {
            Setters =
            {
                new Setter {Property = Button.BackgroundColorProperty, Value = Color.FromHex("#2a2533")},
                new Setter {Property = Button.TextColorProperty, Value = Color.White},
                new Setter {Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand }
            }
        };


        public static readonly Style ButtonLetterStyle = new Style(typeof(Button))
        {
            Setters =
            {
                new Setter {Property = Button.BackgroundColorProperty, Value = Color.FromHex("#2a2533") },
                new Setter {Property = Button.TextColorProperty, Value = Color.White},
                new Setter {Property = Button.FontAttributesProperty, Value = FontAttributes.Bold },
                new Setter {Property = Button.BorderColorProperty, Value = Color.White },
                new Setter {Property = Button.BorderWidthProperty, Value = 5 },
                new Setter {Property = Button.WidthRequestProperty, Value = BUTTON_LETTER_SIZE },
                new Setter {Property = Button.HeightRequestProperty, Value = BUTTON_LETTER_SIZE },
                new Setter {Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.Start },
                new Setter {Property = Button.VerticalOptionsProperty, Value = LayoutOptions.Start },
                new Setter {Property = Button.FontSizeProperty, Value = 10 }
            }
        };

        public static readonly Style TestLabelStyle = new Style(typeof(Label))
        {
            Setters =
            {
                new Setter {Property = Label.TextColorProperty, Value = Color.Black},
                new Setter {Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
                new Setter {Property = Label.HorizontalTextAlignmentProperty, Value = TextAlignment.Center },
                new Setter {Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                new Setter {Property = Label.FontSizeProperty, Value = 64 },
                new Setter {Property = Label.MarginProperty, Value = new Thickness(0,0,0,50) }
            }
        };

        public static readonly Style SummaryLabelStyle = new Style(typeof(Label))
        {
            Setters =
            {
                new Setter {Property = Label.TextColorProperty, Value = Color.Black},
                new Setter {Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.StartAndExpand },
                new Setter {Property = Label.FontSizeProperty, Value = 18 },
            }
        };


    }
}
