using DemoQA.Pages.SelectablePage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    public class SelectableTests : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/selectable");
            _selectablePage = new SelectablePage(Driver);
        }

        [Test]
        public void SelectOneElement()
        {
            _selectablePage.SelectOneElement();

            _selectablePage.AssertIsElementSelected();
        }

        [Test]
        public void SelectThreeElements()
        {
            _selectablePage.SelectThreeElements();

            _selectablePage.AssertAreElementsSelected();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
