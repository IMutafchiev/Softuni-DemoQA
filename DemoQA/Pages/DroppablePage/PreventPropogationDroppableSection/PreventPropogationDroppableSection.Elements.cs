using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DroppablePage.PreventPropogationDroppableSection
{
    public partial class PreventPropogationDroppableSection : BasePage
    {
        public PreventPropogationDroppableSection(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement PreventPropogationSectionTab => Driver.FindElement(By.Id("droppableExample-tab-preventPropogation"));

        public IWebElement DraggableElement => Driver.FindElement(By.XPath("//div[@class='pp-drop-container']//div[@class='drag-box mt-4 ui-draggable ui-draggable-handle']"));

        public IWebElement InnerDroppableElement => Driver.FindElement(By.Id("greedyDropBoxInner"));

        public IWebElement DroppableElement => Driver.FindElement(By.Id("greedyDropBox"));

        public string DroppableElementColorBefore { get; set; }

        public string DroppableElementColorAfter { get; set; }

        public string InnerDroppableElementColorBefore { get; set; }

        public string InnerDroppableElementColorAfter { get; set; }
    }
}
