using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PageObjects
{
    public class HomePage
    {
        static string Url = "http://lyratesting2.co.nz/";

        private IWebElement webElement = null;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public void ClickLogin()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[2]/a"));
            webElement.Click();
        }

        public void CheckAvatar()
        {
            // Check avatar
            try
            {
                IWebElement imgAvatar = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img"));
            }
            catch (Exception e)
            {
            }
        }

        public void MouseMoveToAvatar()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img"));
            Actions action = new Actions(Browser.Driver_Web);
            action.MoveToElement(webElement).Perform();
        }

        public void ClickLogout()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[9]/a"));
            webElement.Click();
        }

        public void ClickPersonalSettings()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[3]/a"));
            webElement.Click();
        }
    }
}
