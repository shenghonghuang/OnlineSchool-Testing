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

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}