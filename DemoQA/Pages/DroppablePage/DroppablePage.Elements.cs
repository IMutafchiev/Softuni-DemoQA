using DemoQA.Pages.DroppablePage.AcceptDroppableSection;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement DragabbleElement => Driver.FindElement(By.XPath("//div[@class='simple-drop-container']//div[@class='drag-box mt-4 ui-draggable ui-draggable-handle']"));

        public IWebElement DroppableElement => Driver.FindElement(By.XPath("//div[@class='simple-drop-container']//div[@id='droppable']"));
        
        public string DroppableElementColorBefore { get; set; }

        public string DroppableElementColorAfter { get; set; }
    }
    
}
