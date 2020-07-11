using DemoQA.Pages.ElementsPage.CheckBoxPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoQA.Tests.Elements
{
    [TestFixture]
    public class CheckBoxTests : BaseTest
    {
        CheckBoxPage _checkBoxPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            _checkBoxPage = new CheckBoxPage(Driver);
        }

        [Test]
        public void IsAllFieldsChecked()
        {

            _checkBoxPage.CheckHomeCheckBox();

            _checkBoxPage.AssertIsAllFieldsChecked();
        }


        [Test]
        public void IsAllFieldsFromDesktopChecked()
        {
            _checkBoxPage.CheckDesktopCheckBox();

            _checkBoxPage.AssertIsAllFieldsFromDesktopChecked();
        }

        [Test]
        public void IsAllFieldsFromDocumentsChecked()
        {
            _checkBoxPage.CheckDocumentsCheckBox();

            _checkBoxPage.AssertIsAllFieldsFromDocumentsCheced();
        }

        [Test]
        public void IsAllFieldsFromWorkSpaceChecked()
        {
            _checkBoxPage.CheckWorkSpaceCheckBox();

            _checkBoxPage.AssertIsAllFieldsFromWorkSpaceChecked();
        }

        [Test]
        public void IsOnlyNotesChecked()
        {
            _checkBoxPage.CheckNotesCheckBox();

            _checkBoxPage.AssertIsOnlyNotesChecked();
        }


        [TearDown]
        public void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var dir = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile
                    ($"{dir}\\Screenshots\\CheckBox\\{TestContext.CurrentContext.Test.FullName.Replace('"', ' ')}.png"
                    , ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }

    }
}
