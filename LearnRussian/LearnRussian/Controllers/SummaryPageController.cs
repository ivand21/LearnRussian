using LearnRussian.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnRussian.Controllers
{
    public class SummaryPageController
    {
        private SummaryPage _page;

        public SummaryPageController(SummaryPage page)
        {
            _page = page;
        }

        public async void OnEndButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PopToRootAsync();
        }

    }
}
