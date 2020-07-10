using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.SortablePage
{
    public partial class SortablePage
    {

        public void AssertAreElementsSortedAfterMoveTwoElements()
        {
            Assert.AreEqual("T", AllSortableElements[0].Text);
        }

        public void AssertAreElementsSortedAfterMoveOtherTwoElements()
        {
            Assert.AreEqual("Four", AllSortableElements[2].Text);
        }

    }
}
