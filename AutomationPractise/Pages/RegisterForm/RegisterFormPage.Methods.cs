using AutomationPractise.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractise.Pages.RegisterForm
{
    public partial class RegisterFormPage : BasePage
    {

        

        public void FillForm(RegistrationFormModel user)
        {
            Wait.Until(ExpectedConditions.ElementExists(By.Id("id_gender1")));
            ScrollTo(Title).Click();
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            SelectElement day = new SelectElement(Day);
            day.SelectByValue(user.Date.Day.ToString());
            SelectElement month = new SelectElement(Month);
            month.SelectByValue(user.Date.Month.ToString());
            SelectElement year = new SelectElement(Year);
            year.SelectByValue(user.Date.Year.ToString());
            ScrollTo(CustomerAddress).SendKeys(user.Address);
            CustomerCity.SendKeys(user.City);
            SelectElement state = new SelectElement(CustomerState);
            state.SelectByText(user.State);
            PostCode.SendKeys(user.ZipCode);
            MobilePhone.SendKeys(user.MobilePhone);
            ScrollTo(SubmitButton).Click();

        }

    }
}
