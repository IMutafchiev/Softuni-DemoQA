using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.ResizablePage
{
    public partial class ResizablePage : BasePage
    {

        public void ResizeElementByX()
        {
            ScrollTo(ResizableElement);
            ResizableElementWidhtBefore = ResizableElement.GetCssValue("width");
            Builder.ClickAndHold(ResizableElementToDrag)
                .MoveByOffset(120, 60)
                .Release()
                .Perform();
            ResizableElementWidthAfter = ResizableElement.GetCssValue("width");
        }

        public void ResizeElementByY()
        {
            ScrollTo(ResizableElement);
            ResizableElementHeightBefore = ResizableElement.GetCssValue("height");
            Builder.ClickAndHold(ResizableElementToDrag)
                .MoveByOffset(120, 60)
                .Release()
                .Perform();
            ResizableElementHeightAfter = ResizableElement.GetCssValue("height");
        }

    }
}
