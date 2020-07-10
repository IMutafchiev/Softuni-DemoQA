using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.DroppablePage
{
    public partial class DroppablePage : BasePage
    {

        public void AssertIsColorOfDroppableElementChange()
        {
            Assert.AreNotEqual(DroppableElementColorBefore, DroppableElementColorAfter);
        }

    }

}
