﻿using OpenQA.Selenium;
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

namespace ClassLibrary.PageObjects
{
    public class ProfilePage
    {
        private IWebElement webElement = null;

        public void ClickAvatarSettings()
        {
            webElement = Browser.Driver_Web.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[1]/div/ul/li[3]/a"));
            webElement.Click();
        }

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