using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow
{
    [Binding]
    public class RegisterSteps
    {
        [Then(@"I input invalid Email")]
        public void ThenIInputInvalidEmail()
        {
            Pages.RegisterPage.InputInvalidEmail();
        }

        [Then(@"I can see error text about invalid Email")]
        public void ThenICanSeeErrorTextAboutInvalidEmail()
        {
            Pages.RegisterPage.CheckInputInvalidEmailNotification();
        }

        [Then(@"I input invalid nick name")]
        public void ThenIInputInvalidNickName()
        {
            Pages.RegisterPage.InputInvalidNickName();
        }

        [Then(@"I can see error text about nick name")]
        public void ThenICanSeeErrorTextAboutNickName()
        {
            Pages.RegisterPage.CheckInputInvalidUsernameNotificatio();
        }

        [Then(@"I input invalid password")]
        public void ThenIInputInvalidPassword()
        {
            Pages.RegisterPage.InputInvalidPassword();
        }

        [Then(@"I can see error text about password")]
        public void ThenICanSeeErrorTextAboutPassword()
        {
            Pages.RegisterPage.CheckInputInvalidPasswordNotificatio();
        }

        [Then(@"I input invalid captcha code")]
        public void ThenIInputInvalidCaptchaCode()
        {
            Pages.RegisterPage.InputInvalidCaptchaCode();
        }

        [Then(@"I can see error text about aptcha code")]
        public void ThenICanSeeErrorTextAboutAptchaCode()
        {
            Pages.RegisterPage.CheckInputInvalidCaptchaCodeNotification();
        }
    }
}
