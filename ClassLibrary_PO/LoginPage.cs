﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_PO
{
    public class LoginPage
    {
        private IWebElement webElement = null;
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
    }
}