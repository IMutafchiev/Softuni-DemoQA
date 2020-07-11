using DemoQA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.ElementsPage.TextBoxPage
{
    public partial class TextBoxPage : BasePage
    {

        public void FillTextBox(TextBoxPageModel model)
        {
            fullNameField.SendKeys(model.FullName);
            emailField.SendKeys(model.Email);
            currentAddressField.SendKeys(model.CurrentAddress);
            permamentAddressField.SendKeys(model.PermamentAddress);
            ScrollTo(submitButton).Click();
            ScrollTo(outputFields[0]);
        }

    }
}
