using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.NavigationPage
{
    public partial class NavigationToPage : BasePage
    {

        public void NavigateTo(string cardsName)
        {
            ScrollTo(naviagationToCard(cardsName)).Click();
        }

    }
}
