using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.DraggablePage
{
    public partial class DraggablePage : BasePage
    {

        public void AssertIsDraggableElementMoved()
        {
            Assert.AreNotEqual(DraggableElementLocationBefore, DraggableElementLocationAfter);
        }

        public void AssertIsXAxisDraggableElementIsMovedOnlyByXAxis()
        {
            Assert.AreNotEqual(XAxisDraggableElementLocationBefore.X, XAxisDraggableElementLocationAfter.X);
            Assert.AreEqual(XAxisDraggableElementLocationBefore.Y, XAxisDraggableElementLocationAfter.Y);
        }

        public void AssertIsYAxisDraggableElementIsMovedOnlyByYAxis()
        {
            Assert.AreEqual(YAxisDraggableElementLocationBefore.X, YAxisDraggableElementLocationAfter.X);
            Assert.AreNotEqual(YAxisDraggableElementLocationBefore.Y, YAxisDraggableElementLocationAfter.Y);
        }

    }
}
