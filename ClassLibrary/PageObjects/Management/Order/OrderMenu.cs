using OpenQA.Selenium;

namespace ClassLibrary.PageObjects.Management.Order
{
    public class OrderMenu
    {
        private IWebElement webElement = null;

        public void ClickCourseOrder()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/a[1]"));
            webElement.Click();
        }

        public void ClickClassOrder()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/a[2]"));
            webElement.Click();
        }
    }
}