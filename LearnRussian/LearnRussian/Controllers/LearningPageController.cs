using LearnRussian.Model;
using LearnRussian.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LearnRussian.Controllers
{
    public class LearningPageController
    {
        private LearningPage _page;

        public LearningPageController(LearningPage page)
        {
            _page = page;
        }

        public async void OnLetterButtonClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            int index;

            if (_page.CurrentAlphabet == AlphabetType.Latin)
            {
                index = Array.IndexOf(Alphabet.Phonetic, btn.Text);
                await PopupNavigation.PushAsync(new LearningLetterPopup(btn.Text,Alphabet.Cyryllic[index].ToString()));
            }
            else
            {
                index = Array.IndexOf(Alphabet.Cyryllic, btn.Text);
                await PopupNavigation.PushAsync(new LearningLetterPopup(btn.Text, Alphabet.Phonetic[index].ToString()));
            }
        }

        public async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PopAsync();
        }

        public void OnSwapButtonClicked(object sender, EventArgs e)
        {
            if (_page.CurrentAlphabet == AlphabetType.Russian)
                _page.SetAlphabet(AlphabetType.Latin);
            else
                _page.SetAlphabet(AlphabetType.Russian);
        }
    }
}
