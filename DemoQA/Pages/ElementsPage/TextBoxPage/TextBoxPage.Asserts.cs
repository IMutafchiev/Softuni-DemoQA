using DemoQA.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.ElementsPage.TextBoxPage
{
    public partial class TextBoxPage : BasePage
    {

        public void AssertIsAllTextFieldsFilled()
        {
            Assert.IsTrue(outputFields.Count == 4);
        }

        public void AssertIsAllTextFieldsFilledCorrectly(TextBoxPageModel model)
        {
            Assert.AreEqual($"Name:{model.FullName}", outputFields[0].Text);
            Assert.AreEqual($"Email:{model.Email}", outputFields[1].Text);
            Assert.AreEqual($"Current Address :{model.CurrentAddress}", outputFields[2].Text);
            Assert.AreEqual($"Permananet Address :{model.PermamentAddress}", outputFields[3].Text);
        }
    }
}
