using DemoQA.Pages.Interactions.DroppablePage;
using DemoQA.Pages.Interactions.DroppablePage.AcceptDroppableSection;
using DemoQA.Pages.Interactions.DroppablePage.PreventPropogationDroppableSection;
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
    public class DroppableTests : BaseTest
    {
        private DroppablePage _droppablePage;
        private AcceptDroppableSection _acceptableDroppableSection;
        private PreventPropogationDroppableSection _preventPropogationDroppableSection;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/droppable");
            _droppablePage = new DroppablePage(Driver);
            _acceptableDroppableSection = new AcceptDroppableSection(Driver);
            _preventPropogationDroppableSection = new PreventPropogationDroppableSection(Driver);
        }

        [Test]
        public void DropElementChangeColorWhenDragableElementIsDropped()
        {
            _droppablePage.DragAndDropElement();

            _droppablePage.AssertIsColorOfDroppableElementChange();
        }

        [Test]
        public void DropElementChangeColorWhenAcceptableDragElementIsDropped()
        {
            _acceptableDroppableSection.DragAndDropAcceptableElement();

            _acceptableDroppableSection.AssertIsColorOfAcceptableDroppableElementChange();
        }

        [Test]
        public void InnerDropElementOnlyChangeColorWhenDragableElementIsDropped()
        {
            _preventPropogationDroppableSection.DragAndDropElementToInnerDroppableElement();

            _preventPropogationDroppableSection.AssertIsOnlyColorOfInnerDroppableElementChange();
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
