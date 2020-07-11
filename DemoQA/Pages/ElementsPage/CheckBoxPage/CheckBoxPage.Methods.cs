using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.ElementsPage.CheckBoxPage
{
    public partial class CheckBoxPage : BasePage
    {

        public void CheckHomeCheckBox()
        {
            homeCheckBox.Click();
            ScrollTo(results[0]);
        }


        public void CheckDesktopCheckBox()
        {
            homeCheckBoxPath.Click();
            desktopCheckBox.Click();
            ScrollTo(results[0]);
        }

        public void CheckDocumentsCheckBox()
        {
            homeCheckBoxPath.Click();
            documentsCheckBox.Click();
            ScrollTo(results[0]);
        }

        public void CheckWorkSpaceCheckBox()
        {
            homeCheckBoxPath.Click();
            documentsCheckBoxPath.Click();
            workSpaceCheckBox.Click();
            ScrollTo(results[0]);
        }

        public void CheckNotesCheckBox()
        {
            homeCheckBoxPath.Click();
            desktopCheckBoxPath.Click();
            notesCheckBox.Click();
            ScrollTo(results[0]);
        }
    }
}
