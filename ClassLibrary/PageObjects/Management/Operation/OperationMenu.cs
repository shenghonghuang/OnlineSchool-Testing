using OpenQA.Selenium;

namespace ClassLibrary.PageObjects.Management.Operation
{
    public class OperationMenu
    {
        private IWebElement webElement = null;

        public void ClickArticle()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[1]/a[1]"));
            webElement.Click();
        }
    }
}