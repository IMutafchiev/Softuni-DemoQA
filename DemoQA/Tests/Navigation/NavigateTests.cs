using DemoQA.Pages.NavigationPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Tests.Navigation
{
    [TestFixture]
    public class NavigateTests : BaseTest
    {
        private NavigationToPage _navigationToPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");
            _navigationToPage = new NavigationToPage(Driver);
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void NavigateTo(string sectionName)
        {

            _navigationToPage.NavigateTo(sectionName);

            _navigationToPage.AssertIsThisCorrectPage(sectionName);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
