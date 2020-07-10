using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.SelectablePage
{
    public partial class SelectablePage : BasePage
    {

        public void SelectOneElement()
        {
            firstElementColorBefore = AllSelectableElements[2].GetCssValue("background-color");
            AllSelectableElements[2].Click();
            firstElementColorAfter = AllSelectableElements[2].GetCssValue("background-color");
        }

        public void SelectThreeElements()
        {
            firstElementColorBefore = AllSelectableElements[0].GetCssValue("background-color");
            secondElementColorBefore = AllSelectableElements[1].GetCssValue("background-color");
            thirdElementColorBefore = AllSelectableElements[2].GetCssValue("background-color");
            AllSelectableElements[0].Click();
            AllSelectableElements[1].Click();
            AllSelectableElements[2].Click();
            firstElementColorAfter = AllSelectableElements[0].GetCssValue("background-color");
            secondElementColorAfter = AllSelectableElements[1].GetCssValue("background-color");
            thirdElementColorAfter = AllSelectableElements[2].GetCssValue("background-color");
        }
    }
}
