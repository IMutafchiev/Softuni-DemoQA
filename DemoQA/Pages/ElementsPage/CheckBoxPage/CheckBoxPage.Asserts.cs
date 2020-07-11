using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.ElementsPage.CheckBoxPage
{
    public partial class CheckBoxPage : BasePage
    {

        public void AssertIsAllFieldsChecked()
        {
            Assert.IsTrue(results.Count == 17);
            Assert.AreEqual("home", results[0].Text);
        }

        public void AssertIsAllFieldsFromDesktopChecked()
        {
            Assert.IsTrue(results.Count == 3);
            Assert.AreEqual("desktop", results[0].Text);
        }

        public void AssertIsAllFieldsFromDocumentsCheced()
        {
            Assert.IsTrue(results.Count == 10);
            Assert.AreEqual("documents", results[0].Text);
        }

        public void AssertIsAllFieldsFromWorkSpaceChecked()
        {
            Assert.IsTrue(results.Count == 4);
            Assert.AreEqual("workspace", results[0].Text);
        }

        public void AssertIsOnlyNotesChecked()
        {
            Assert.IsTrue(results.Count == 1);
            Assert.AreEqual("notes", results[0].Text);
        }
    }
}
