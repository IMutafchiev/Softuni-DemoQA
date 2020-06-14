using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {

        public void DragAndDropElement()
        {
            DroppableElementColorBefore = DroppableElement.GetCssValue("background-color");
            Builder.DragAndDrop(DragabbleElement, DroppableElement).Perform();
            DroppableElementColorAfter = DroppableElement.GetCssValue("background-color");
        }


    }
}
