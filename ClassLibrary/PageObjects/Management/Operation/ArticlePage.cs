using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary.PageObjects.Management.Operation
{
    public class ArticlePage
    {
        private IWebElement webElement = null;

        public void ClickSearch()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/button"));
            webElement.Click();
        }

        public void SelectCategory(string text)
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[1]/div/a/span[1]"));
            webElement.Click();
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[7]/div/input"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys(text);
            webElement.SendKeys(Keys.Enter);
        }

        public void InputKeyword(string text)
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/input"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys(text);
        }

        public void ClearKeyword()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/input"));
            webElement.Click();
            webElement.Clear();
        }

        public void SelectAttribute(string text)
        {
            var dropdownlist = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[3]/select"));
            var selectElement = new SelectElement(dropdownlist);
            selectElement.SelectByText(text);
        }

        public void SelectStatus(string text)
        {
            var dropdownlist = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[4]/select"));
            var selectElement = new SelectElement(dropdownlist);
            selectElement.SelectByText(text);
        }
    }
}