using DemoQA.Factories;
using DemoQA.Pages.ElementsPage.TextBoxPage;
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
    public class TextBoxTests : BaseTest
    {
        TextBoxPage _textBoxPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            _textBoxPage = new TextBoxPage(Driver);
        }

        [Test]
        public void IsAllTextFieldsFilled()
        {
            var textBoxModel = TextBoxFactory.CreateTextBox();

            _textBoxPage.FillTextBox(textBoxModel);

            _textBoxPage.AssertIsAllTextFieldsFilled();
        }

        [Test]
        public void IsAllTextFieldsFilledCorrect()
        {
            var textBoxModel = TextBoxFactory.CreateTextBox();

            _textBoxPage.FillTextBox(textBoxModel);

            _textBoxPage.AssertIsAllTextFieldsFilledCorrectly(textBoxModel);
        }

        [TearDown]
        public void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var dir = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile
                    ($"{dir}\\Screenshots\\Elements\\{TestContext.CurrentContext.Test.FullName.Replace('"', ' ')}.png",
                    ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }
    }
}
