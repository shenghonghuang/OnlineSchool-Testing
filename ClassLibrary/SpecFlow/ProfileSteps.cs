﻿using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow
{
    [Binding]
    public class ProfileSteps
    {
        [Then(@"I click PERSONAL SETTINGS")]
        public void ThenIClickPERSONALSETTINGS()
        {
            Pages.HomePage.ClickPersonalSettings();
        }

        [Then(@"I click AVATAR SETTINGS")]
        public void ThenIClickAVATARSETTINGS()
        {
            Pages.ProfilePage.ClickAvatarSettings();
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
