using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.Management.Order
{
    [Binding]
    public class ClassOrderSteps
    {
        [Then(@"I click \[BUTTON\|SEARCH] ON \[PAGE\|CLASS ORDER]")]
        public void ThenIClickBUTTONSEARCHONPAGECLASSORDER()
        {
            Pages.ClassOrderPage.ClickSearch();
        }

        [Then(@"I select (.*)(.*):(.*) on \[DATETIMEPICKER\|START DATE TIME] on \[PAGE\|CLASS ORDER]")]
        public void ThenISelectOnDATETIMEPICKERSTARTDATETIMEOnPAGECLASSORDER(string p0, string p1, int p2)
        {
            Pages.ClassOrderPage.SelectStartDateTime();
        }

        [Then(@"I select (.*)(.*):(.*) on \[DATETIMEPICKER\|END DATE TIME] on \[PAGE\|CLASS ORDER]")]
        public void ThenISelectOnDATETIMEPICKERENDDATETIMEOnPAGECLASSORDER(string p0, string p1, int p2)
        {
            Pages.ClassOrderPage.SelectEndDateTime();
        }

        [Then(@"I select PAID on \[DROPDOWNLIST\|STATUS] on \[PAGE\|CLASS ORDER]")]
        public void ThenISelectPAIDOnDROPDOWNLISTSTATUSOnPAGECLASSORDER()
        {
            Pages.ClassOrderPage.SelectOrderStatus();
        }

        [Then(@"I select ALIPAY on \[DROPDOWNLIST\|PAYMENT METHOD] on \[PAGE\|CLASS ORDER]")]
        public void ThenISelectALIPAYOnDROPDOWNLISTPAYMENTMETHODOnPAGECLASSORDER()
        {
            Pages.ClassOrderPage.SelectPaymentMethod();
        }

        [Then(@"I select CLASS NUMBER on \[TEXTBOX\|KEYWORD TYPE] on \[PAGE\|CLASS ORDER]")]
        public void ThenISelectCLASSNUMBEROnTEXTBOXKEYWORDTYPEOnPAGECLASSORDER()
        {
            Pages.ClassOrderPage.SelectKeyWordType();
        }
    }
}
