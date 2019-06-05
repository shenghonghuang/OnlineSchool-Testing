using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.Management.Order
{
    [Binding]
    public class CourseOrderSteps
    {
        [Then(@"I click \[BUTTON\|SEARCH] ON \[PAGE\|COURSE ORDER]")]
        public void ThenIClickBUTTONSEARCHONPAGECOURSEORDER()
        {
            Pages.CourseOrderPage.ClickSearch();
        }

        [Then(@"I select (.*)(.*):(.*) on \[DATETIMEPICKER\|START DATE TIME] on \[PAGE\|COURSE ORDER]")]
        public void ThenISelectOnDATETIMEPICKERSTARTDATETIMEOnPAGECOURSEORDER(string p0, string p1, int p2)
        {
            Pages.CourseOrderPage.SelectStartDateTime();
        }

        [Then(@"I select (.*)(.*):(.*) on \[DATETIMEPICKER\|END DATE TIME] on \[PAGE\|COURSE ORDER]")]
        public void ThenISelectOnDATETIMEPICKERENDDATETIMEOnPAGECOURSEORDER(string p0, string p1, int p2)
        {
            Pages.CourseOrderPage.SelectEndDateTime();
        }

        [Then(@"I select PAID on \[DROPDOWNLIST\|STATUS] on \[PAGE\|COURSE ORDER]")]
        public void ThenISelectPAIDOnDROPDOWNLISTSTATUSOnPAGECOURSEORDER()
        {
            Pages.CourseOrderPage.SelectOrderStatus();
        }

        [Then(@"I select ALIPAY on \[DROPDOWNLIST\|PAYMENT METHOD] on \[PAGE\|COURSE ORDER]")]
        public void ThenISelectALIPAYOnDROPDOWNLISTPAYMENTMETHODOnPAGECOURSEORDER()
        {
            Pages.CourseOrderPage.SelectPaymentMethod();
        }

        [Then(@"I select COURSE NAME on \[TEXTBOX\|KEYWORD TYPE] on \[PAGE\|COURSE ORDER]")]
        public void ThenISelectCOURSENAMEOnTEXTBOXKEYWORDTYPEOnPAGECOURSEORDER()
        {
            Pages.CourseOrderPage.SelectKeyWordType();
        }
    }
}