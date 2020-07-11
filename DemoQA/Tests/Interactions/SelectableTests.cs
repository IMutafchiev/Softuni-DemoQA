using DemoQA.Pages.Interactions.SelectablePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    public class SelectableTests : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/selectable");
            _selectablePage = new SelectablePage(Driver);
        }

        [Test]
        public void SelectOneElement()
        {
            _selectablePage.SelectOneElement();

            _selectablePage.AssertIsElementSelected();
        }

        [Test]
        public void SelectThreeElements()
        {
            _selectablePage.SelectThreeElements();

            _selectablePage.AssertAreElementsSelected();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var dir = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile
                    ($"{dir}\\Screenshots\\Interactions\\{TestContext.CurrentContext.Test.FullName.Replace('"', ' ')}.png"
                    , ScreenshotImageFormat.Jpeg);
            }

            Driver.Quit();
        }
    }
}
