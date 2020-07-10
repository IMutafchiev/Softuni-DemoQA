using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.DroppablePage.AcceptDroppableSection
{
    public partial class AcceptDroppableSection : BasePage 
    {
        public void AssertIsColorOfAcceptableDroppableElementChange()
        {
            Assert.AreNotEqual(DroppableColorBefore, DroppableColorAfter);
        }

    }
}
