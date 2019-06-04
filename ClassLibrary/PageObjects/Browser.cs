using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ClassLibrary.PageObjects
{
    public class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver();

        public static ISearchContext Driver_SearchContext
        {
            get { return webDriver; }
        }

        public static IWebDriver Driver_Web
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver = new FirefoxDriver();
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
