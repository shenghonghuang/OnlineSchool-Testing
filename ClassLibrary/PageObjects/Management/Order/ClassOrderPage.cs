using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary.PageObjects.Management.Order
{
    public class ClassOrderPage
    {
        private IWebElement webElement = null;

        public void ClickSearch()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/button"));
            webElement.Click();
        }

        public void SelectStartDateTime()
        {
            webElement = Browser.Driver_Web.FindElement(By.Id("startDate"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("2017-12-14 22:51");
        }

        public void SelectEndDateTime()
        {
            webElement = Browser.Driver_Web.FindElement(By.Id("endDate"));
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys("2017-12-14 22:51");
        }

        public void SelectOrderStatus()
        {
            var status = Browser.Driver_Web.FindElement(By.Name("status"));
            var selectElement = new SelectElement(status);
            selectElement.SelectByText("已付款");
        }

        public void SelectPaymentMethod()
        {
            var payment = Browser.Driver_Web.FindElement(By.Name("payment"));
            var selectElement = new SelectElement(payment);
            selectElement.SelectByText("支付宝");
        }

        public void SelectKeyWordType()
        {
            var type = Browser.Driver_Web.FindElement(By.Name("keywordType"));
            var selectElement = new SelectElement(type);
            selectElement.SelectByText("班级编号");
        }
    }
}