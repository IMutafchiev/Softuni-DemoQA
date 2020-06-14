using DemoQA.Pages.SortablePage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    public class SortableTests : BaseTest
    {
        private SortablePage _sortablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/sortable");
            _sortablePage = new SortablePage(Driver);
        }

        [Test]
        [TestCase("One", "Four")]
        public void SortElements(string firstElement, string secondElement)
        {
            _sortablePage.MoveTwoElementsAndCheckIsOthersSorted(firstElement, secondElement);

            _sortablePage.AssertAreElementsSortedAfterMoveTwoElements();
        }

        [Test]
        [TestCase("Three", "Five")]
        public void SortOtherElements(string firstElement, string secondElement)
        {
            _sortablePage.MoveTwoElementsAndCheckIsOthersSorted(firstElement, secondElement);

            _sortablePage.AssertAreElementsSortedAfterMoveOtherTwoElements();
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
