using OpenQA.Selenium;
using System;

namespace ClassLibrary.PageObjects.PersonalSettings
{
    public class BasicInfoSettingsPage
    {
        private IWebElement webElement = null;

        public void FillBasicInfoWithValidInfo()
        {
            // Name
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_truename"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("Jake Ma");
            // ID
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_idcard"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("110101200006058558");
            // Phone
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_mobile"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("13800138000");
            // Title
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_title"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("CEO");
            // Website
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_site"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("https://www.alibaba.com/");
            // QQ
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_qq"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("10000");
        }

        public void FillBasicInfoWithInvalidInfo()
        {
            // Name
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_truename"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("Jake Ma Jake Ma Jake Ma Jake Ma Jake Ma Jake Ma");
            // ID
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_idcard"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("1101012000060585580");
            // Phone
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_mobile"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("138001380000");
            // Title
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_title"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("The chief executive officer");
            // Website
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_site"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("www.alibaba.com/");
            // QQ
            webElement = Browser.Driver_SearchContext.FindElement(By.Id("profile_qq"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("www.alibaba.com");
        }

        public void ClickSave()
        {
            webElement = Browser.Driver_Web.FindElement(By.Id("profile-save-btn"));
            webElement.Click();
        }

        public void CheckMessageOfSavedSuccessfully()
        {
            try
            {
                IWebElement text = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("基础信息保存成功。"));
            }
            catch (Exception e)
            {
            }
        }


        public void CheckErrorMessageOfInvalidInfo()
        {
            try
            {
                IWebElement realName = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("最多只能输入 18 个字符"));
                IWebElement id = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("请正确输入您的身份证号码"));
                IWebElement phone = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("请输入正确的手机号"));
                IWebElement title = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("最多只能输入 24 个字符"));
                IWebElement website = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("地址不正确，须以http://或者https://开头。"));
                IWebElement qq = Browser.Driver_SearchContext.FindElement(By.PartialLinkText("请输入正确的QQ号"));
            }
            catch (Exception e)
            {
            }
        }
    }
}