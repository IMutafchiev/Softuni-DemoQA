using DemoQA.Pages.Interactions.DraggablePage;
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
    public class DraggableTests: BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/dragabble");
            _draggablePage = new DraggablePage(Driver);
        }

        [Test]
        public void DragElementAndMoves()
        {
            _draggablePage.DragElement();

            _draggablePage.AssertIsDraggableElementMoved();
        }

        [Test]
        public void DragXAxisDraggableElementAndMovesOnlyByXAxis()
        {
            _draggablePage.DragElementByXAxis();

            _draggablePage.AssertIsXAxisDraggableElementIsMovedOnlyByXAxis();
        }

        [Test]
        public void DragYAxisDraggableElementAndMovesOnlyByYAxis()
        {
            _draggablePage.DragElementByYAxis();

            _draggablePage.AssertIsYAxisDraggableElementIsMovedOnlyByYAxis();
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
