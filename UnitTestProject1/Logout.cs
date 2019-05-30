using ClassLibrary_PO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class Logout
    {
        public void Login()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.ClickLogin();
            Pages.LoginPage.LoginWithAccount("test001", "Test1234");
            Pages.HomePage.CheckAvatar();
        }

        [TestMethod]
        public void CanLogoutWhenLogined()
        {
            Login();
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
