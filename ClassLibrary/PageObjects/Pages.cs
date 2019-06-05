﻿using ClassLibrary.PageObjects.PersonalSettings;
using OpenQA.Selenium.Support.PageObjects;

namespace ClassLibrary.PageObjects
{
    public class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver_SearchContext, homePage);
                return homePage;
            }
        }

        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                PageFactory.InitElements(Browser.Driver_SearchContext, loginPage);
                return loginPage;
            }
        }

        public static PersonalSettingsMenu PersonalSettingsMenu
        {
            get
            {
                var personalSettingsMenu = new PersonalSettingsMenu();
                PageFactory.InitElements(Browser.Driver_SearchContext, personalSettingsMenu);
                return personalSettingsMenu;
            }
        }

        public static BasicInfoSettingsPage BasicInfoSettingsPage
        {
            get
            {
                var basicInfoSettingsPage = new BasicInfoSettingsPage();
                PageFactory.InitElements(Browser.Driver_SearchContext, basicInfoSettingsPage);
                return basicInfoSettingsPage;
            }
        }

        public static AvatarSettingsPage ProfilePage
        {
            get
            {
                var profilePage = new AvatarSettingsPage();
                PageFactory.InitElements(Browser.Driver_SearchContext, profilePage);
                return profilePage;
            }
        }

        public static RegisterPage RegisterPage
        {
            get
            {
                var registerPage = new RegisterPage();
                PageFactory.InitElements(Browser.Driver_SearchContext, registerPage);
                return registerPage;
            }
        }

        public static ResetPasswordPage ResetPasswordPage
        {
            get
            {
                var resetPasswordPage = new ResetPasswordPage();
                PageFactory.InitElements(Browser.Driver_SearchContext, resetPasswordPage);
                return resetPasswordPage;
            }
        }
    }
}