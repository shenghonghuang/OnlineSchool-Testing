using ClassLibrary.PageObjects;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.PersonalSettings
{
    [Binding]
    public class PersonalSettingsMenuSteps
    {
        [Then(@"I click \[MENU\|BASIC INFO SETTINGS] on \[PAGE\|PERSONAL SETTINGS]")]
        public void ThenIClickMENUBASICINFOSETTINGSOnPAGEPERSONALSETTINGS()
        {
            Pages.PersonalSettingsMenu.ClickBasicInfoSettings();
        }

        [Then(@"I click \[MENU] AVATAR SETTINGS")]
        public void GivenIClickMENUAVATARSETTINGS()
        {
            Pages.PersonalSettingsMenu.ClickAvatarSettings();
        }
    }
}
