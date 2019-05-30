using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    class Program
    {
        static IWebDriver driver = new FirefoxDriver();
        static IWebElement webElement = null;
        static string Title_LoginPage = "登录 - EduSoho网络课堂 - 三分钟帮助您建设功能完备的网校！ - Powered By EduSoho";
        static string Url_LoginPage = "http://lyratesting2.co.nz/login";

        static void Main(string[] args)
        {
            Logout();
        }

        /* 1. login with valid user name and password, Remember me is selected
           Expected Result(Assertion):login is successful, avatar is seen */
        private static void Login_ValidInfo()
        {
            // Open
            driver.Url = "http://lyratesting2.co.nz/";
            //IWebElement webElement = null;
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
                Console.WriteLine("NNNNNNNN");
            }
        }

        /*2. login with invalid user name and password
          Expected Result(Assertion):login is unsuccessful, error message is seen */
        private static void Login_InvilidInfo()
        {
            // Open
            driver.Url = "http://lyratesting2.co.nz/";
            webElement = driver.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[2]/a"));
            webElement.Click();
            // Username
            webElement = driver.FindElement(By.Id("login_username"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("test");
            // Password
            webElement = driver.FindElement(By.Id("login_password"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("Test");
            // Click Login
            webElement = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button"));
            webElement.Click();
            // Check Error Notification
            // Check avatar
            try
            {
                IWebElement imgAvatar = driver.FindElement(By.PartialLinkText("用户名或密码错误"));
            }
            catch (Exception e)
            {
            }
            // Close
            driver.Quit();
        }

        private static void Logout()
        {
            Actions action = new Actions(driver);
            Login_ValidInfo();
            webElement = driver.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img"));
            action.MoveToElement(webElement).Perform();
            webElement = driver.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[9]/a"));
            webElement.Click();
            if (Title_LoginPage == driver.Title && Url_LoginPage == driver.Url)
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