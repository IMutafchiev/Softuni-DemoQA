using DemoQA.Pages.NavigationPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
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
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var dir = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile
                    ($"{dir}\\Screenshot\\Navigation\\{TestContext.CurrentContext.Test.FullName}.png"
                    , ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }
    }
}
