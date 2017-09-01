using LearnRussian.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnRussian.Controllers
{
    public class MainPageController
    {
        private MainPage _page;

        public MainPageController(MainPage page)
        {
            _page = page;
        }

        public async void OnLearningButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PushAsync(new LearningPage());
        }

        public async void OnTestButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PushAsync(new TestPage());
        }

        public async void OnOptionsButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PushAsync(_page.SettingsPage);
        }

        public async void OnAboutButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PushAsync(new AboutPage());
        }

        public async void OnHelpButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PushAsync(new HelpPage());
        }
    }
}
