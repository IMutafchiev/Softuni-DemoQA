using DemoQA.Pages.ResizablePage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    public class ResizableTests : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/resizable");
            _resizablePage = new ResizablePage(Driver);
        }

        [Test]
        public void ResizeElementByX()
        {
            _resizablePage.ResizeElementByX();

            _resizablePage.AssertAreElementResizeByX();
        }

        [Test]
        public void ResizeElementByY()
        {
            _resizablePage.ResizeElementByY();

            _resizablePage.AssertAreElementResizeByY();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
