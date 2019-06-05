using ClassLibrary.PageObjects;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.PersonalSettings
{
    [Binding]
    public class BasicInfoSettingsSteps
    {
        [Then(@"I fill valid info in \[TEXTBOX\|REAL_NAME], \[TEXTBOX\|ID_CARD], \[TEXTBOX\|PHONE], \[TEXTBOX\|TITLE], \[TEXTBOX\|WEBSITE], \[TEXTBOX\|QQ] on \[PAGE\|BASIC INFO SETTINGS]")]
        public void ThenIFillValidInfoInTEXTBOXREAL_NAMETEXTBOXID_CARDTEXTBOXPHONETEXTBOXTITLETEXTBOXWEBSITETEXTBOXQQOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.FillBasicInfoWithValidInfo();
        }

        [Then(@"I click \[BUTTON\|SAVE] on \[PAGE\|BASIC INFO SETTINGS]")]
        public void ThenIClickBUTTONSAVEOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.ClickSave();
        }

        [Then(@"I can see \[MESSAGE\|BASIC INFORMATION SAVED SUCCESSFULLY] on \[PAGE\|BASIC INFO SETTINGS]")]
        public void ThenICanSeeMESSAGEBASICINFORMATIONSAVEDSUCCESSFULLYOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.CheckMessageOfSavedSuccessfully();
        }

        [Then(@"I fill invalid info in \[TEXTBOX\|REAL_NAME], \[TEXTBOX\|ID_CARD], \[TEXTBOX\|PHONE], \[TEXTBOX\|TITLE], \[TEXTBOX\|WEBSITE], \[TEXTBOX\|QQ] on \[PAGE\|BASIC INFO SETTINGS]")]
        public void ThenIFillInvalidInfoInTEXTBOXREAL_NAMETEXTBOXID_CARDTEXTBOXPHONETEXTBOXTITLETEXTBOXWEBSITETEXTBOXQQOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.FillBasicInfoWithInvalidInfo();
        }

        [Then(@"I can see \[ERROR MESSAGE\|REAL_NAME], \[ERROR MESSAGE\|ID_CARD], \[ERROR MESSAGE\|PHONE], \[ERROR MESSAGE\|TITLE], \[ERROR MESSAGE\|WEBSITE], \[ERROR MESSAGE\|QQ] on \[PAGE\|BASIC INFO SETTINGS]")]
        public void ThenICanSeeERRORMESSAGEREAL_NAMEERRORMESSAGEID_CARDERRORMESSAGEPHONEERRORMESSAGETITLEERRORMESSAGEWEBSITEERRORMESSAGEQQOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.CheckErrorMessageOfInvalidInfo();
        }


    }
}
