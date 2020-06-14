using AutoFixture;
using AutomationPractise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractise.Factories
{
    public static class RegistrationFormFactory
    {
        
        public static RegistrationFormModel Create()
        {
            Fixture fixture = new Fixture();
            return new RegistrationFormModel
            {
                Title = "Mr.",
                FirstName = "Gosho",
                LastName = "Goshev",
                Email = fixture.Create<string>() + "@gmail.com",
                Password = "Password",
                Date = new DateTime(1991, 8, 23),
                Address = fixture.Create<string>(),
                City = fixture.Create<string>(),
                State = "Kansas",
                ZipCode = "12344",
                MobilePhone = "8823158439"
            };
        }

    }
}
