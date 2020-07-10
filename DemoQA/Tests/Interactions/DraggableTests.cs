using DemoQA.Pages.Interactions.DraggablePage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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
            Driver.Quit();
        }
    }
}
