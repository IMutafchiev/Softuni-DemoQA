using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractise.Pages.NavigationToRegisterPage
{
    public partial class NavigationToRegisterPage : BasePage
    {
        public NavigationToRegisterPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public IWebElement SignInButton => Wait.Until(d => d.FindElement(By.ClassName("login")));

        public IWebElement CreateEmail => Wait.Until(d => d.FindElement(By.Id("email_create")));

        public IWebElement CreateEmailSubmit => Wait.Until(d => d.FindElement(By.Id("SubmitCreate")));
    }
}
