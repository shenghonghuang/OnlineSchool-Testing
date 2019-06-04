using OpenQA.Selenium;
using System.Threading;
using System.Windows.Forms;

namespace ClassLibrary.PageObjects.PersonalSettings
{
    public class AvatarSettingsPage
    {
        private IWebElement webElement = null;

        public void ClickUploadNewAvatar()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div/div[2]/form/div[3]/div[2]/a/div[2]/label"));
            webElement.Click();
        }

        public void ChoosePictureAndClickOpen()
        {
            SendKeys.SendWait(@"d:\5.jpg");
            Thread.Sleep(1000);
            SendKeys.SendWait(@"{Enter}");
        }

        public void ClicSaveNewAvatar()
        {
            Thread.Sleep(5000);
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div/div[2]/form/div[2]/div/a[1]"));
            webElement.Click();
        }
    }
}