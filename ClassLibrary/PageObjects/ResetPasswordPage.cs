using OpenQA.Selenium;
using System;

namespace ClassLibrary.PageObjects
{
    public class ResetPasswordPage
    {
        private IWebElement webElement = null;

        public void InputErrorFormatEmail()
        {
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("form_email"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("a");
        }

        public void InputNonexistentEmail()
        {
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("form_email"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("a@a.com");
            
        }

        public void ClickResetPassword()
        {
            webElement = Browser.Driver_SearchContext.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div/form[1]/div[2]/div/button"));
            webElement.Click();
        }

        public void CheckInputErrorFormatEmailNotification()
        {
            try
            {
                IWebElement textError = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("请输入有效的电子邮件地址"));
            }
            catch (Exception e)
            {
            }
        }

        public void CheckInputNonexistentEmailNotification()
        {
            try
            {
                IWebElement textError = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("该邮箱地址没有注册过帐号"));
            }
            catch (Exception e)
            {
            }
        }
    }
}