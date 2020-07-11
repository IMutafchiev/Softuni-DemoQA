using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQA.Pages.ElementsPage.TextBoxPage
{
    public partial class TextBoxPage : BasePage
    {
        public TextBoxPage(IWebDriver driver) : base(driver)
        {
        }


        public IWebElement fullNameField => Driver.FindElement(By.XPath("//input[@id='userName']"));

        public IWebElement emailField => Driver.FindElement(By.XPath("//input[@id='userEmail']"));

        public IWebElement currentAddressField => Driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));

        public IWebElement permamentAddressField => Driver.FindElement(By.XPath("//textarea[@id='permanentAddress']"));

        public IWebElement submitButton => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Submit']"));

        public List<IWebElement> outputFields => Driver.FindElements(By.XPath("//div[@id='output']//div//p")).ToList();
    }
}
