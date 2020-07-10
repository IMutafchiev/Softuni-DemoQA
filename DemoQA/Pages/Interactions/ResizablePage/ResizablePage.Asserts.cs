using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DemoQA.Pages.Interactions.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver) : base(driver)
        {

        }

        public void AssertAreElementResizeByX()
        {
            Assert.AreNotEqual(ResizableElementWidhtBefore, ResizableElementWidthAfter);
        }

        public void AssertAreElementResizeByY()
        {
            Assert.AreNotEqual(ResizableElementHeightBefore, ResizableElementHeightAfter);
        }
    }
}
