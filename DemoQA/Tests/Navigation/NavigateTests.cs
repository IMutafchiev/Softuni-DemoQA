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
        [TestCase("Elements", "Elements")]
        [TestCase("Forms", "Forms")]
        [TestCase("Alerts, Frame & Windows", "Alerts, Frame & Windows")]
        [TestCase("Widgets", "Widgets")]
        [TestCase("Interactions", "Interactions")]
        [TestCase("Book Store Application", "Book Store")]
        public void NavigateTo(string cardName, string headerName)
        {

            _navigationToPage.NavigateTo(cardName);

            _navigationToPage.AssertIsThisCorrectPage(headerName);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
