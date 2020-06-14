using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {

        public IWebElement ResizableElement => Driver.FindElement(By.XPath("//div[normalize-space(text()) = 'Resizable']//ancestor::div[@class='box react-resizable']"));

        public IWebElement ResizableElementToDrag => ResizableElement.FindElement(By.TagName("span"));

        public string ResizableElementWidhtBefore { get; set; }

        public string ResizableElementWidthAfter { get; set; }

        public string ResizableElementHeightBefore { get; set; }

        public string ResizableElementHeightAfter { get; set; }
    }
}
