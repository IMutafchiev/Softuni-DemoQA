using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DroppablePage.AcceptDroppableSection
{
    public partial class AcceptDroppableSection : BasePage
    {
        public AcceptDroppableSection(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement AceptableSectionTab => Driver.FindElement(By.Id("droppableExample-tab-accept"));

        public IWebElement AcceptableDraggableElement => Driver.FindElement(By.XPath("//div[normalize-space(text()) = 'Acceptable']"));

        public IWebElement DroppableElement => Driver.FindElement(By.XPath("//div[@id='droppableExample-tabpane-accept']//div[@id='droppable']"));

        public string DroppableColorBefore { get; set; }

        public string DroppableColorAfter { get; set; }
    }
}
