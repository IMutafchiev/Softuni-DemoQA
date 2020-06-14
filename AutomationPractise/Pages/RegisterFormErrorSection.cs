using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationPractise.Pages
{
    public class RegisterFormErrorSection : BasePage
    {
        public RegisterFormErrorSection(IWebDriver driver) : base(driver)
        {
        }

        public List<IWebElement> ErrorMessage => Wait.Until(d => d.FindElements(By.XPath("//div[@class='alert alert-danger']//ol//li"))).ToList();
    }
}
