using AutomationPractise.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractise.Pages.NavigationToRegisterPage
{
    public partial class NavigationToRegisterPage : BasePage
    {

        public void NavigateToRegister(RegistrationFormModel user)
        {
            SignInButton.Click();
            Wait.Until(ExpectedConditions.ElementExists(By.Id("email_create")));
            CreateEmail.SendKeys(user.Email);
            CreateEmailSubmit.Click();
        }

    }
}
