using LearnRussian.Model;
using LearnRussian.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LearnRussian.Controllers
{
    public class OptionsPageController
    {
        private OptionsPage _page;

        public OptionsPageController(OptionsPage page)
        {
            _page = page;
        }

        public async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PopAsync();
        }

        public void OnAlphSwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
                Settings.QuestionAlphabet = AlphabetType.Latin;
            else
                Settings.QuestionAlphabet = AlphabetType.Russian;
        }
    }
}
