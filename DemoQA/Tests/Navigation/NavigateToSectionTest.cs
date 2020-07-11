using DemoQA.Pages.NavigateToSectionsPage;
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
    public class NavigateToSectionTest : BaseTest
    {
        NavigateToSectionsPage _navigateToSectionPage;
        NavigationToPage _navigationToPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("https://demoqa.com");
            _navigationToPage = new NavigationToPage(Driver);
            _navigateToSectionPage = new NavigateToSectionsPage(Driver);
        }


        [Test]
        [TestCase("Text Box")]
        [TestCase("Check Box")]
        [TestCase("Radio Button")]
        [TestCase("Web Tables")]
        [TestCase("Buttons")]
        [TestCase("Links")]
        [TestCase("Upload and Download")]
        [TestCase("Dynamic Properties")]
        public void NavigateToSectionInElements(string sectionName)
        {
            _navigationToPage.NavigateTo("Elements");
            _navigateToSectionPage.NavigateTo(sectionName);

            _navigateToSectionPage.AssertIsThisCorrectSection(sectionName);
        }

        [Test]
        [TestCase("Practice Form")]
        public void NavigateToSectionInForms(string sectionName)
        {
            _navigationToPage.NavigateTo("Forms");
            _navigateToSectionPage.NavigateTo(sectionName);

            _navigateToSectionPage.AssertIsThisCorrectSection(sectionName);
        }

        [Test]
        [TestCase("Browser Windows")]
        [TestCase("Alerts")]
        [TestCase("Frames")]
        [TestCase("Modal Dialogs")]
        public void NavigateToSectionInAlertsFramesAndWindows(string sectionName)
        {
            _navigationToPage.NavigateTo("Alerts, Frame & Windows");
            _navigateToSectionPage.NavigateTo(sectionName);

            _navigateToSectionPage.AssertIsThisCorrectSection(sectionName);
        }

        [Test]
        [TestCase("Accordian")]
        [TestCase("Auto Complete")]
        [TestCase("Date Picker")]
        [TestCase("Slider")]
        [TestCase("Progress Bar")]
        [TestCase("Tabs")]
        [TestCase("Tool Tips")]
        [TestCase("Menu")]
        [TestCase("Select Menu")]
        public void NavigateToSectionInWidgets(string sectionName)
        {
            _navigationToPage.NavigateTo("Widgets");
            _navigateToSectionPage.NavigateTo(sectionName);

            _navigateToSectionPage.AssertIsThisCorrectSection(sectionName);
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void NavigateToSectionInInteractions(string sectionName)
        {
            _navigationToPage.NavigateTo("Interactions");
            _navigateToSectionPage.NavigateTo(sectionName);

            _navigateToSectionPage.AssertIsThisCorrectSection(sectionName);
        }

        [Test]
        [TestCase("Login")]
        [TestCase("Book Store")]
        [TestCase("Profile")]
        public void NavigateToSectionInBookStoreApplication(string sectionName)
        {
            _navigationToPage.NavigateTo("Book Store Application");
            _navigateToSectionPage.NavigateTo(sectionName);

            _navigateToSectionPage.AssertIsThisCorrectSection(sectionName);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var dir = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile
                    ($"{dir}\\Screenshots\\Navigation\\{TestContext.CurrentContext.Test.FullName.Replace('"', ' ')}.png"
                    , ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }
    }
}
