using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DroppablePage.PreventPropogationDroppableSection
{
    public partial class PreventPropogationDroppableSection : BasePage
    {

        public void AssertIsOnlyColorOfInnerDroppableElementChange()
        {
            Assert.AreNotEqual(DroppableElementColorAfter, InnerDroppableElementColorAfter);

            Assert.AreEqual(DroppableElementColorBefore, DroppableElementColorAfter);
        }

    }
}
