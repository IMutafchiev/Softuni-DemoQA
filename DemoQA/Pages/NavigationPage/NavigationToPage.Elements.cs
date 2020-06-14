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


        public IWebElement naviagationToInteractions => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Interactions']//ancestor::div[@class='card mt-4 top-card']"));


        public IWebElement interactions => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Interactions']//span"));

        public IWebElement interactionsSideBar(string sectionName) => Driver.FindElement(By.XPath($"//*[normalize-space(text()) = '{sectionName}']"));

        public IWebElement pageHeader => Wait.Until(d => d.FindElement(By.ClassName("main-header")));
        
    }
}
