using LearnRussian.Pages;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnRussian.Controllers
{
    public class CheckAnswerPopupController
    {
        private CheckAnswerPopup _page;
        public readonly TestPageController ParentController;

        public CheckAnswerPopupController(CheckAnswerPopup page, TestPageController parent)
        {
            _page = page;
            ParentController = parent;
        }

        public async void OnGoodAnswerButtonClicked(object sender, EventArgs e)
        {
            ParentController.Score.GoodAnswers++;
            await _page.Navigation.PopPopupAsync();
        }

        public async void OnWrongAnswerButtonClicked(object sender, EventArgs e)
        {
            ParentController.Score.WrongAnswers++;
            await _page.Navigation.PopPopupAsync();
        }
    }
}
