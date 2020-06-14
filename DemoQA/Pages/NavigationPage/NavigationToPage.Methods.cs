using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.NavigationPage
{
    public partial class NavigationToPage : BasePage
    {

        public void NavigateTo(string sectionName)
        {
            naviagationToInteractions.Click();
            ScrollTo(interactions);
            interactionsSideBar(sectionName).Click();
        }

    }
}
