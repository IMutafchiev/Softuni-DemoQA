using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.SelectablePage
{
    public partial class SelectablePage : BasePage
    {

        public void AssertIsElementSelected()
        {
            Assert.AreNotEqual(firstElementColorBefore, firstElementColorAfter);
        }

        public void AssertAreElementsSelected()
        {
            Assert.AreNotEqual(firstElementColorBefore, firstElementColorAfter);
            Assert.AreNotEqual(secondElementColorBefore, secondElementColorAfter);
            Assert.AreNotEqual(thirdElementColorBefore, thirdElementColorAfter);
        }
    }
}
