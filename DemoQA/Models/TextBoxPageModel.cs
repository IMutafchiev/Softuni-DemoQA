using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoQA.Models
{
    public class TextBoxPageModel
    {

        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string CurrentAddress { get; set; }

        public string PermamentAddress { get; set; }
    }
}
