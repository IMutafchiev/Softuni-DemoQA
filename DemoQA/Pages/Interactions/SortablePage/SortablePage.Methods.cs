using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.Interactions.SortablePage
{
    public partial class SortablePage : BasePage
    {

        public void MoveTwoElementsAndCheckIsOthersSorted(string firstElement, string secondElement)
        {
            Builder
                .DragAndDrop(FirstSortableElement(firstElement), SecondSortableElement(secondElement))
                .Perform();
        }

    }
}
