using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.PageObjects.PersonalSettings
{
    public class PersonalSettingsMenu
    {
        private IWebElement webElement = null;

        public void ClickAvatarSettings()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[1]/div/ul/li[3]/a"));
            webElement.Click();
        }
    }
}