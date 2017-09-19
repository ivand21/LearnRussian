using LearnRussian.Model;
using LearnRussian.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnRussian.Controllers
{
    public class TestPageController
    {
        private TestPage _page;
        public Score Score { get; set; }

        public TestPageController(TestPage page)
        {
            _page = page;
            Score = new Score();
        }

        public string RandomLetter()
        {
            Random rnd = new Random();
            if (Settings.QuestionAlphabet == AlphabetType.Russian)
            {
                return Alphabet.Cyryllic[rnd.Next(Alphabet.Cyryllic.Length)];
            }
            else
            {
                return Alphabet.Phonetic[rnd.Next(Alphabet.Phonetic.Length)];
            }
        }

        public async void OnApplyButtonClicked(object sender, EventArgs e)
        {
            int index;
            string letter;

            if (Settings.QuestionAlphabet == AlphabetType.Russian)
            {
                index = Array.IndexOf(Alphabet.Cyryllic, _page.Question.Text);
                letter = Alphabet.Phonetic[index];
            }
            else
            {
                index = Array.IndexOf(Alphabet.Phonetic, _page.Question.Text);
                letter = Alphabet.Cyryllic[index];
            }

            var popup = new CheckAnswerPopup(letter, this);
            await PopupNavigation.PushAsync(popup);

            _page.Question.Text = RandomLetter();
        }

        public async void OnEndButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PushAsync(new SummaryPage(Score));
        }

    }
}
