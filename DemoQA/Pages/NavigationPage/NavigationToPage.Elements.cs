using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.NavigationPage
{
    public partial class NavigationToPage : BasePage
    {
        public NavigationToPage(IWebDriver driver) : base(driver)
        {
        }


        public IWebElement naviagationToCard(string cardName) => Driver.FindElement(By.XPath($"//*[normalize-space(text()) = '{cardName}']//ancestor::div[@class='card mt-4 top-card']"));


        public IWebElement cardName(string cardName) => Driver.FindElement(By.XPath($"//*[normalize-space(text()) = '{cardName}']/parent::div"));

        public IWebElement pageHeader => Wait.Until(d => d.FindElement(By.ClassName("main-header")));
        
    }
}
