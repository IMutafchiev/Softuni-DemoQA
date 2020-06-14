using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractise.Pages.RegisterForm
{
    public partial class RegisterFormPage
    {
        public RegisterFormPage(IWebDriver driver) : base(driver)
        {
        }


        public RegisterFormErrorSection ErrorSection => new RegisterFormErrorSection(Driver);

        public MyAccountSection section => new MyAccountSection(Driver);

        public IWebElement Title => Wait.Until(d => d.FindElement(By.Id("id_gender1")));

        public IWebElement FirstName => Wait.Until(d => d.FindElement(By.Id("customer_firstname")));

        public IWebElement LastName => Wait.Until(d => d.FindElement(By.Id("customer_lastname")));

        public IWebElement Email => Wait.Until(d => d.FindElement(By.Id("email")));

        public IWebElement Password => Wait.Until(d => d.FindElement(By.Id("passwd")));

        public IWebElement Day => Wait.Until(d => d.FindElement(By.Id("days")));

        public IWebElement Month => Wait.Until(d => d.FindElement(By.Id("months")));

        public IWebElement Year => Wait.Until(d => d.FindElement(By.Id("years")));

        public IWebElement CustomerAddress => Wait.Until(d => d.FindElement(By.Id("address1")));

        public IWebElement CustomerCity => Wait.Until(d => d.FindElement(By.Id("city")));

        public IWebElement CustomerState => Wait.Until(d => d.FindElement(By.Id("id_state")));

        public IWebElement PostCode => Wait.Until(d => d.FindElement(By.Id("postcode")));

        public IWebElement MobilePhone => Wait.Until(d => d.FindElement(By.Id("phone_mobile")));

        public IWebElement SubmitButton => Wait.Until(d => d.FindElement(By.Id("submitAccount")));


    }
}
