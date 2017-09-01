using LearnRussian.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnRussian.Controllers
{
    public class AboutPageController
    {
        private AboutPage _page;

        public AboutPageController(AboutPage page)
        {
            _page = page;
        }

        public async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PopAsync();
        }

    }
}
