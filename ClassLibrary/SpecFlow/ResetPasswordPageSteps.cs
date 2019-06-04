using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow
{
    [Binding]
    public class ResetPasswordPageSteps
    {
        [Then(@"I click LINK of RESET PASSWORD")]
        public void ThenIClickLINKOfRESETPASSWORD()
        {
            Pages.LoginPage.ClickResetPassword();
        }

        [Then(@"I input a error format Email")]
        public void ThenIInputAErrorFormatEmail()
        {
            Pages.ResetPasswordPage.InputErrorFormatEmail();
        }

        [Then(@"I click BUTTON of RESET PASSWORD button")]
        public void ThenIClickBUTTONOfRESETPASSWORDButton()
        {
            Pages.ResetPasswordPage.ClickResetPassword();
        }

        [Then(@"I can see the error notification for error format Email")]
        public void ThenICanSeeTheErrorNotificationForErrorFormatEmail()
        {
            Pages.ResetPasswordPage.CheckInputErrorFormatEmailNotification();
        }

        [Then(@"I input a nonexistent Email")]
        public void ThenIInputANonexistentEmail()
        {
            Pages.ResetPasswordPage.InputNonexistentEmail();
        }

        [Then(@"I can see the error notification for nonexistent Email")]
        public void ThenICanSeeTheErrorNotificationForNonexistentEmail()
        {
            Pages.ResetPasswordPage.CheckInputNonexistentEmailNotification();
        }
    }
}
