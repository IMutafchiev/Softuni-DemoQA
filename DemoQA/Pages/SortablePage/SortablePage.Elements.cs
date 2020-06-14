using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQA.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FirstSortableElement(string firstElement) => Driver.FindElement(By.XPath($"//*[@class='vertical-list-container mt-4']//*[normalize-space(text()) = '{firstElement}']"));

        public IWebElement SecondSortableElement(string secondElement) => Driver.FindElement(By.XPath($"//*[@class='vertical-list-container mt-4']//*[normalize-space(text()) = '{secondElement}']"));

        public List<IWebElement> AllSortableElements => Driver.FindElements(By.XPath($"//*[@class='vertical-list-container mt-4']//*")).ToList();
    }
}
