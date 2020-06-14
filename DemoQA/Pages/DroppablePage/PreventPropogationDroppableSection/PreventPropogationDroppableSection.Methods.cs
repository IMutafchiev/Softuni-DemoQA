using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DroppablePage.PreventPropogationDroppableSection
{
    public partial class PreventPropogationDroppableSection : BasePage
    {

        public void DragAndDropElementToInnerDroppableElement()
        {
            PreventPropogationSectionTab.Click();
            WaitForLoad();
            ScrollTo(DraggableElement);
            DroppableElementColorBefore = DroppableElement.GetCssValue("background-color");
            InnerDroppableElementColorBefore = InnerDroppableElement.GetCssValue("background-color");
            Builder.DragAndDrop(DraggableElement, InnerDroppableElement).Perform();
            DroppableElementColorAfter = DroppableElement.GetCssValue("background-color");
            InnerDroppableElementColorAfter = InnerDroppableElement.GetCssValue("background-color");
        }
    }
}
