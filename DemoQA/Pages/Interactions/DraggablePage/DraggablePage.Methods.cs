using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.DraggablePage
{
    public partial class DraggablePage : BasePage
    {

        public void DragElement()
        {
            DraggableElementLocationBefore = DraggableElemment.Location;
            Builder.DragAndDropToOffset(DraggableElemment, 70, 40).Perform();
            DraggableElementLocationAfter = DraggableElemment.Location;
        }

        public void DragElementByXAxis()
        {
            AxisDraggableSection.Click();
            WaitForLoad();
            XAxisDraggableElementLocationBefore = XAxisDragableElement.Location;
            Builder.DragAndDropToOffset(XAxisDragableElement, 70, 40).Perform();
            XAxisDraggableElementLocationAfter = XAxisDragableElement.Location;
        }

        public void DragElementByYAxis()
        {
            AxisDraggableSection.Click();
            WaitForLoad();
            YAxisDraggableElementLocationBefore = YAxisDragableElement.Location;
            Builder.DragAndDropToOffset(YAxisDragableElement, 70, 40).Perform();
            YAxisDraggableElementLocationAfter = YAxisDragableElement.Location;
        }

    }
}
