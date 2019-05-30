using System;
using ClassLibrary_PO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void CanLoginWithValidInfo()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.ClickLogin();
            Pages.LoginPage.LoginWithAccount("test001", "Test1234");
            Pages.HomePage.CheckAvatar();
        }

        [TestMethod]
        public void CannotLoginWithInvalidInfo()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.ClickLogin();
            Pages.LoginPage.LoginWithAccount("test", "Test");
            Pages.LoginPage.CheckErrorText();
        }

        [TestMethod]
        public void CanLogoutWhenLogined()
        {
            CanLoginWithValidInfo();
            Pages.HomePage.MouseMoveToAvatar();
            Pages.HomePage.ClickLogout();
            Pages.LoginPage.CheckTitleAndUrl();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}