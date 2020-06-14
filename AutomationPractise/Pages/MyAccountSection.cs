using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractise.Pages
{
    public class MyAccountSection : BasePage
    {
        public MyAccountSection(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Message => Wait.Until(d => d.FindElement(By.XPath("//h1[@class='page-heading']")));
    }
}
