using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.NavigateToSectionsPage
{
    public partial class NavigateToSectionsPage : BasePage
    {

        public void AssertIsThisCorrectSection(string sectionName)
        {
            Assert.AreEqual(sectionName, pageHeader.Text);
        }

    }
}
