using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LoginPage
    {
        private IWebElement webElement = null;
        static string PageUrl = "http://lyratesting2.co.nz/login";
        static string Title = "登录 - EduSoho网络课堂 - 三分钟帮助您建设功能完备的网校！ - Powered By EduSoho";

        public void LoginWithAccount(string username, string password)
        {
            // Username
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("login_username"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys(username);
            // Password
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("login_password"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys(password);
            // Checkbox
            IWebElement ckRemeberMe = Browser.Driver_SearchContext.FindElement(By.Name("_remember_me"));
            Boolean vCheckedRemeberMe = false;
            vCheckedRemeberMe = ckRemeberMe.Selected;
            if (vCheckedRemeberMe == false)
            {
                webElement = Browser.Driver_SearchContext.FindElement(By.Name("_remember_me"));
                webElement.Click();
            }
            // Click Login
            webElement = Browser.Driver_SearchContext.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button"));
            webElement.Click();
        }

        public void CheckErrorText()
        {
            try
            {
                IWebElement imgAvatar = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("用户名或密码错误"));
            }
            catch (Exception e)
            {
            }
        }

        public void CheckTitleAndUrl()
        {
            if (Title == Browser.Driver_Web.Title && PageUrl == Browser.Driver_Web.Url)
            {
                Console.WriteLine("Successful");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
    }
}