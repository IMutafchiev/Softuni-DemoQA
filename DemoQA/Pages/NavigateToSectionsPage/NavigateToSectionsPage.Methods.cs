using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.NavigateToSectionsPage
{
    public partial class NavigateToSectionsPage : BasePage
    {
        public void NavigateTo(string sectionName)
        {
            ScrollTo(section(sectionName)).Click();
        }
    }
}
