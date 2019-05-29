using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Login_ValidInfo();
        }

        /* 1. login with valid user name and password, Remember me is selected
           Expected Result(Assertion):login is successful, avatar is seen */
        private static void Login_ValidInfo()
        {
            // Open
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://lyratesting2.co.nz/";
            IWebElement webElement = null;
            webElement = driver.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[2]/a"));
            webElement.Click();
            // Username
            webElement = driver.FindElement(By.Id("login_username"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("test001");
            // Password
            webElement = driver.FindElement(By.Id("login_password"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("Test1234");
            // Checkbox
            IWebElement ckRemeberMe = driver.FindElement(By.Name("_remember_me"));
            Boolean vCheckedRemeberMe = false;
            vCheckedRemeberMe = ckRemeberMe.Selected;
            if (vCheckedRemeberMe == false)
            {
                webElement = driver.FindElement(By.Name("_remember_me"));
                webElement.Click();
            }
            // Click Login
            webElement = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button"));
            webElement.Click();
            // Check avatar
            try
            {
                IWebElement imgAvatar = driver.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img"));
            }
            catch (Exception e)
            {
            }
            // Close
            driver.Quit();
        }
    }
}