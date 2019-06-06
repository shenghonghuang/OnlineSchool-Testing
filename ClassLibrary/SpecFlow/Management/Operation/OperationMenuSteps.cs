using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.Management.Operation
{
    [Binding]
    public class OperationMenuSteps
    {
        [Then(@"I click \[MENU\|ARTICLE] on \[PAGE\|OPERATION]")]
        public void ThenIClickMENUARTICLEOnPAGEOPERATION()
        {
            Pages.OperationMenu.ClickArticle();
        }
    }
}
