using System;
using ClassLibrary.PageObjects;
using TechTalk.SpecFlow;

namespace ClassLibrary_Specflow
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am in home page")]
        public void GivenIAmInHomePage()
        {
            Pages.HomePage.Goto();
        }

        [Then(@"I click login")]
        public void ThenIClickLogin()
        {
            Pages.HomePage.ClickLogin();
        }

        [Then(@"I input valid username and password, and make sure i have checked remember me")]
        public void ThenIInputValidUsernameAndPasswordAndMakeSureIHaveCheckedRememberMe()
        {
            Pages.LoginPage.LoginWithAccount("test001", "Test1234");
        }

        [Then(@"I can see the avatar on home page")]
        public void ThenICanSeeTheAvatarOnHomePage()
        {
            Pages.HomePage.CheckAvatar();
        }

        [Then(@"I input invalid username and password")]
        public void ThenIInputInvalidUsernameAndPassword()
        {
            Pages.LoginPage.LoginWithAccount("test", "Test");
        }

        [Then(@"I can see the error notification on login page")]
        public void ThenICanSeeTheErrorNotificationOnLoginPage()
        {
            Pages.LoginPage.CheckErrorText();
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            Browser.Close();
        }

        [Then(@"I click register")]
        public void ThenIClickRegister()
        {
            Pages.HomePage.ClickRegister();
        }
    }
}
