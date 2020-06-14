using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractise.Pages.RegisterForm
{
    public partial class RegisterFormPage : BasePage
    {

        public void AssertSuccessRegistration()
        {
            this.WaitForLoad();
            Assert.AreEqual("MY ACCOUNT", section.Message.Text);
        }

        public void AsserErrorMessageFirstNameIsRequired()
        {
            this.WaitForLoad();
            Assert.AreEqual("firstname is required.", ErrorSection.ErrorMessage[0].Text);
        }

        public void AsserErrorMessageLastNameIsRequired()
        {
            this.WaitForLoad();
            Assert.AreEqual("lastname is required.", ErrorSection.ErrorMessage[0].Text);
        }

        public void AsserErrorMessagePasswordIsRequired()
        {
            this.WaitForLoad();
            Assert.AreEqual("passwd is required.", ErrorSection.ErrorMessage[0].Text);
        }

        public void AsserErrorMessagePhoneNumberIsRequired()
        {
            this.WaitForLoad();
            Assert.AreEqual("You must register at least one phone number.", ErrorSection.ErrorMessage[0].Text);
        }
        public void AsserErrorMessageCityIsRequired()
        {
            this.WaitForLoad();
            Assert.AreEqual("city is required.", ErrorSection.ErrorMessage[0].Text);
        }
        public void AsserErrorMessagePasswordIsInvalid()
        {
            this.WaitForLoad();
            Assert.AreEqual("passwd is invalid.", ErrorSection.ErrorMessage[0].Text);
        }
    }
}
