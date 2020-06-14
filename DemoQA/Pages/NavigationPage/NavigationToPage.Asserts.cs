using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.NavigationPage
{
    public partial class NavigationToPage : BasePage
    {

        public void AssertIsThisCorrectPage(string sectionName)
        {
            Assert.AreEqual(sectionName, pageHeader.Text);
        }

    }
}
