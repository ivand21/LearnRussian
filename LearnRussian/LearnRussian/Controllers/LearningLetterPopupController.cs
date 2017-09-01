using LearnRussian.Pages;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnRussian.Controllers
{
    public class LearningLetterPopupController
    {
        private LearningLetterPopup _page;

        public LearningLetterPopupController(LearningLetterPopup page)
        {
            _page = page;
        }

        public async void OnOkButtonClicked(object sender, EventArgs e)
        {
            await _page.Navigation.PopPopupAsync();
        }

    }
}
