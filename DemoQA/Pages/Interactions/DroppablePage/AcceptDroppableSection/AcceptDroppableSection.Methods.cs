using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.DroppablePage.AcceptDroppableSection
{
    public partial class AcceptDroppableSection : BasePage
    {
        public void DragAndDropAcceptableElement()
        {
            AceptableSectionTab.Click();
            WaitForLoad();
            DroppableColorBefore = DroppableElement.GetCssValue("background-color");
            Builder.DragAndDrop(AcceptableDraggableElement,
                DroppableElement).Perform();
            DroppableColorAfter =
                DroppableElement.GetCssValue("background-color");
        }
    }
}
