using OpenQA.Selenium;
using System.Threading;
using System.Windows.Forms;

namespace ClassLibrary.PageObjects.Management
{
    public class ManagementPage
    {
        private IWebElement webElement = null;

        public void ClickOrder()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[4]/a"));
            webElement.Click();
        }

        public void ClickOperation()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[3]/a"));
            webElement.Click();
        }
    }
}