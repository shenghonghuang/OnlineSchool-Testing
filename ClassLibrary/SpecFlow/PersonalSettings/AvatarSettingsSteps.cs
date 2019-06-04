using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.PersonalSettings
{
    [Binding]
    public class AvatarSettingsSteps
    {
        [Then(@"I click PERSONAL SETTINGS")]
        public void ThenIClickPERSONALSETTINGS()
        {
            Pages.HomePage.ClickPersonalSettings();
        }

        [Then(@"I click UPLOAD NEW AVATAR")]
        public void ThenIClickUPLOADNEWAVATAR()
        {
            Pages.ProfilePage.ClickUploadNewAvatar();
        }

        [Then(@"I click a picture and click open")]
        public void ThenIClickAPictureAndClickOpen()
        {
            Pages.ProfilePage.ChoosePictureAndClickOpen();
        }

        [Then(@"I click SAVE")]
        public void ThenIClickSAVE()
        {
            Pages.ProfilePage.ClicSaveNewAvatar();
        }
    }
}
