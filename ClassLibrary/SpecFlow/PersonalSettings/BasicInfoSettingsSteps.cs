using ClassLibrary.PageObjects;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.PersonalSettings
{
    [Binding]
    public class BasicInfoSettingsSteps
    {
        [Then(@"I fill valid info in \[TEXTBOX \| REALNAME, ID, PHONE, TITLE, WEBSITE, QQ] on \[PAGE \| BASIC INFO SETTINGS]")]
        public void ThenIFillValidInfoInTEXTBOXREALNAMEIDPHONETITLEWEBSITEQQOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.FillBasicInfoWithValidInfo();
        }

        [Then(@"I click \[BUTTON \| SAVE] on \[PAGE \| BASIC INFO SETTINGS]")]
        public void ThenIClickBUTTONSAVEOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.ClickSave();
        }

        [Then(@"I can see \[MESSAGE \| BASIC INFORMATION SAVED SUCCESSFULLY] on \[PAGE \| BASIC INFO SETTINGS]")]
        public void ThenICanSeeMESSAGEBASICINFORMATIONSAVEDSUCCESSFULLYOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.CheckMessageOfSavedSuccessfully();
        }

        [Then(@"I fill invalid info in \[TEXTBOX \| REALNAME, ID, PHONE, TITLE, WEBSITE, QQ] on \[PAGE \| BASIC INFO SETTINGS]")]
        public void ThenIFillInvalidInfoInTEXTBOXREALNAMEIDPHONETITLEWEBSITEQQOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.FillBasicInfoWithInvalidInfo();
        }


        [Then(@"I can see \[MESSAGE \| ERROR : INVALID REALNAME, ID, PHONE, TITLE, WEBSITE, QQ] on \[PAGE \| BASIC INFO SETTINGS]")]
        public void ThenICanSeeMESSAGEERRORINVALIDREALNAMEIDPHONETITLEWEBSITEQQOnPAGEBASICINFOSETTINGS()
        {
            Pages.BasicInfoSettingsPage.CheckErrorMessageOfInvalidInfo();
        }

    }
}
