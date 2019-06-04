using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace ClassLibrary.PageObjects
{
    public class RegisterPage
    {
        private IWebElement webElement = null;

        public void InputInvalidEmail()
        {
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("register_email"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("A");
            Actions actions = new Actions(Browser.Driver_Web);
            actions.MoveByOffset(0, 0).Click().Build().Perform();
        }

        public void InputInvalidNickName()
        {
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("register_nickname"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("A");
            Actions actions = new Actions(Browser.Driver_Web);
            actions.MoveByOffset(0, 0).Click().Build().Perform();
        }

        public void InputInvalidPassword()
        {
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("register_password"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("A");
            Actions actions = new Actions(Browser.Driver_Web);
            actions.MoveByOffset(0, 0).Click().Build().Perform();
        }

        public void InputInvalidCaptchaCode()
        {
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("captcha_code"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("A");
            Actions actions = new Actions(Browser.Driver_Web);
            actions.MoveByOffset(0, 0).Click().Build().Perform();
        }

        public void CheckInputInvalidEmailNotification()
        {
            try
            {
                IWebElement textError = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("请输入有效的电子邮件地址"));
            }
            catch (Exception e)
            {
            }
        }

        public void CheckInputInvalidUsernameNotificatio()
        {
            try
            {
                IWebElement textError = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("字符长度必须大于等于4，一个中文字算2个字符"));
            }
            catch (Exception e)
            {
            }
        }

        public void CheckInputInvalidPasswordNotificatio()
        {
            try
            {
                IWebElement textError = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("最少需要输入 5 个字符"));
            }
            catch (Exception e)
            {
            }
        }

        public void CheckInputInvalidCaptchaCodeNotification()
        {
            try
            {
                IWebElement textError = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("最少需要输入 5 个字符"));
            }
            catch (Exception e)
            {
            }
        }
    }
}