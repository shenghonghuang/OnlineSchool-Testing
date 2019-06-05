using OpenQA.Selenium;

namespace ClassLibrary.PageObjects.PersonalSettings
{
    public class PersonalSettingsMenu
    {
        private IWebElement webElement = null;

        public void ClickBasicInfoSettings()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[1]/div/ul/li[2]/a"));
            webElement.Click();
        }

        public void ClickAvatarSettings()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[1]/div/ul/li[3]/a"));
            webElement.Click();
        }
    }
}