using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.NavigateToSectionsPage
{
    public partial class NavigateToSectionsPage : BasePage
    {
        public NavigateToSectionsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement section(string sectionName) => Driver.FindElement(By.XPath($"//*[normalize-space(text()) = '{sectionName}']/parent::li"));

        public IWebElement pageHeader => Wait.Until(d => d.FindElement(By.ClassName("main-header")));

    }
}
