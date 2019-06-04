using ClassLibrary.PageObjects;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow
{
    [Binding]
    public class LogoutSteps
    {
        [Then(@"I move mouse on the avatar")]
        public void ThenIMoveMouseOnTheAvatar()
        {
            Pages.HomePage.MouseMoveToAvatar();
        }

        [Then(@"I click Logout")]
        public void ThenIClickLogout()
        {
            Pages.HomePage.ClickLogout();
        }

        [Then(@"I can see the login page")]
        public void ThenICanSeeTheLoginPage()
        {
            Pages.LoginPage.CheckTitleAndUrl();
        }
    }
}
