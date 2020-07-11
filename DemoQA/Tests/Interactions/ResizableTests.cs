using DemoQA.Pages.Interactions.ResizablePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
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
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var dir = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile
                    ($"{dir}\\Screenshots\\Interactions\\{TestContext.CurrentContext.Test.FullName.Replace('"', ' ')}.png"
                    , ScreenshotImageFormat.Png);
            }
            Driver.Quit();
        }

    }
}
