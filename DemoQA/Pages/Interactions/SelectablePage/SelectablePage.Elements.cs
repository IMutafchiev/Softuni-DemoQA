using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQA.Pages.Interactions.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver) : base(driver)
        {
        }

        public List<IWebElement> AllSelectableElements => Driver.FindElements(By.XPath("//div[@class='fade tab-pane active show']//ul[@class='vertical-list-container mt-4 list-group']//li")).ToList();

        public string firstElementColorBefore { get; set; }

        public string firstElementColorAfter { get; set; }

        public string secondElementColorBefore { get; set; }

        public string secondElementColorAfter { get; set; }

        public string thirdElementColorBefore { get; set; }

        public string thirdElementColorAfter { get; set; }
    }
}
