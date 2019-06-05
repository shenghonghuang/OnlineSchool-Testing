using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.Management.Order
{
    [Binding]
    public class OrderSteps
    {
        [Then(@"I click \[MENU\|MANAGEMENT] ON \[PAGE\|HOME]")]
        public void ThenIClickMENUMANAGEMENTONPAGEHOME()
        {
            Pages.HomePage.ClickManagement();
        }

        [Then(@"I click \[MENU\|ORDER] ON \[PAGE\|MANAGEMENT]")]
        public void ThenIClickMENUORDERONPAGEMANAGEMENT()
        {
            Pages.ManagementPage.ClickOrder();
        }

        [Then(@"I click \[MENU\|COURSE ORDER] ON \[MENU\|ORDER]")]
        public void ThenIClickMENUCOURSEORDERONPAGEORDER()
        {
            Pages.OrderMenu.ClickCourseOrder();
        }

        [Then(@"I click \[MENU\|CLASS ORDER] ON \[MENU\|ORDER]")]
        public void ThenIClickMENUCLASSORDERONPAGEORDER()
        {
            Pages.OrderMenu.ClickClassOrder();
        }


    }
}
