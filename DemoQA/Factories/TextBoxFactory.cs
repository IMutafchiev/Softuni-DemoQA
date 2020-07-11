using AutoFixture;
using DemoQA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Factories
{
    public static class TextBoxFactory
    {
        
        public static TextBoxPageModel CreateTextBox()
        {
            Fixture fixture = new Fixture();

            var textBox = new TextBoxPageModel()
            {
                FullName = fixture.Create<string>(),
                Email = fixture.Create<string>() + "@gmail.com",
                CurrentAddress = fixture.Create<string>(),
                PermamentAddress = fixture.Create<string>()
            };

            return textBox;
        }

    }
}
