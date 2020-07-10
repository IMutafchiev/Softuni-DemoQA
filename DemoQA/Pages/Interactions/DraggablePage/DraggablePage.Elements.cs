using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DemoQA.Pages.Interactions.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver) : base(driver)
        {
        }


        public IWebElement DraggableElemment => Driver.FindElement(By.XPath("//div[@class='fade tab-pane active show']//div[@class='drag-box ui-draggable ui-draggable-handle']"));

        public IWebElement AxisDraggableSection => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));

        public IWebElement XAxisDragableElement => Driver.FindElement(By.XPath("//div[@class='axis-restriction-container mt-4']//div[normalize-space(text()) = 'Only X']"));

        public IWebElement YAxisDragableElement => Driver.FindElement(By.XPath("//div[@class='axis-restriction-container mt-4']//div[normalize-space(text()) = 'Only Y']"));

        public Point DraggableElementLocationBefore { get; set; }

        public Point DraggableElementLocationAfter { get; set; }

        public Point XAxisDraggableElementLocationBefore { get; set; }

        public Point XAxisDraggableElementLocationAfter { get; set; }

        public Point YAxisDraggableElementLocationBefore { get; set; }

        public Point YAxisDraggableElementLocationAfter { get; set; }
    }
}
