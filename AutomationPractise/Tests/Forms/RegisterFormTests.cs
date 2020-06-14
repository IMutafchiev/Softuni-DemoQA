using AutomationPractise.Factories;
using AutomationPractise.Models;
using AutomationPractise.Pages.NavigationToRegisterPage;
using AutomationPractise.Pages.RegisterForm;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractise.Tests.Forms
{
    [TestFixture]
    public class RegisterFormTests : BaseTest
    {
        private RegisterFormPage _registerFormPage;
        private NavigationToRegisterPage _navigationToRegisterPage;
        private RegistrationFormModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _registerFormPage = new RegisterFormPage(Driver);
            _navigationToRegisterPage = new NavigationToRegisterPage(Driver);
            _user = RegistrationFormFactory.Create();
        }

        [Test]
        public void RegisterUser_WithValidData()
        {
            _navigationToRegisterPage.NavigateToRegister(_user);

            _registerFormPage.FillForm(_user);

            _registerFormPage.AssertSuccessRegistration();
        }

        [Test]
        public void RegisterUser_WithoutFirstName()
        {
            _navigationToRegisterPage.NavigateToRegister(_user);

            _user.FirstName = string.Empty;

            _registerFormPage.FillForm(_user);

            _registerFormPage.AsserErrorMessageFirstNameIsRequired();
        }

        [Test]
        public void RegisterUser_WithoutLastName()
        {
            _navigationToRegisterPage.NavigateToRegister(_user);

            _user.LastName = string.Empty;

            _registerFormPage.FillForm(_user);

            _registerFormPage.AsserErrorMessageLastNameIsRequired();
        }

        [Test]
        public void RegisterUser_WithoutPassword()
        {
            _navigationToRegisterPage.NavigateToRegister(_user);

            _user.Password = string.Empty;

            _registerFormPage.FillForm(_user);

            _registerFormPage.AsserErrorMessagePasswordIsRequired();
        }

        [Test]
        public void RegisterUserWithoutMobilePhone()
        {
            _navigationToRegisterPage.NavigateToRegister(_user);

            _user.MobilePhone = string.Empty;

            _registerFormPage.FillForm(_user);

            _registerFormPage.AsserErrorMessagePhoneNumberIsRequired();
        }

        [Test]
        public void RegisterUserWithoutCity()
        {
            _navigationToRegisterPage.NavigateToRegister(_user);

            _user.City = string.Empty;

            _registerFormPage.FillForm(_user);

            _registerFormPage.AsserErrorMessageCityIsRequired();
        }


        [Test]
        public void RegisterUserWith_PasswordWith3Characters()
        {
            _navigationToRegisterPage.NavigateToRegister(_user);

            _user.Password = "123";

            _registerFormPage.FillForm(_user);

            _registerFormPage.AsserErrorMessagePasswordIsInvalid();
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
