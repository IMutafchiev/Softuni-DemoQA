using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQA.Pages.ElementsPage.CheckBoxPage
{
    public partial class CheckBoxPage : BasePage
    {
        public CheckBoxPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement homeCheckBoxPath => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Home']//parent::label/parent::span/button"));

        public IWebElement homeCheckBox => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Home']//parent::label"));

        public IWebElement desktopCheckBoxPath => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Desktop']//parent::label/parent::span/button"));

        public IWebElement desktopCheckBox => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Desktop']//parent::label"));

        public IWebElement notesCheckBox => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Notes']//parent::label"));

        public IWebElement commandsCheckBox => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Commands']//parent::label"));

        public IWebElement documentsCheckBoxPath => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Documents']//parent::label/parent::span/button"));

        public IWebElement documentsCheckBox => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'Documents']//parent::label"));

        public IWebElement workSpaceCheckBoxPath => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'WorkSpace']//parent::label/parent::span/button"));

        public IWebElement workSpaceCheckBox => Driver.FindElement(By.XPath("//*[normalize-space(text()) = 'WorkSpace']//parent::label"));

        public List<IWebElement> results => Driver.FindElements(By.XPath("//div[@id='result']//span[@class='text-success']")).ToList();

    }
}
