using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.Management
{
    [Binding]
    public class ManagementMenuSteps
    {
        [Then(@"I click \[MENU\|ORDER] ON \[PAGE\|MANAGEMENT]")]
        public void ThenIClickMENUORDERONPAGEMANAGEMENT()
        {
            Pages.ManagementPage.ClickOrder();
        }

        [Then(@"I click \[MENU\|OPERATION] on \[PAGE\|MANAGEMENT]")]
        public void ThenIClickMENUOPERATIONOnPAGEMANAGEMENT()
        {
            Pages.ManagementPage.ClickOperation();
        }
    }
}
