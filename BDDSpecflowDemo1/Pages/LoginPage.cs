using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDSpecflowDemo1.Pages
{
    public class LoginPage
    {
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        // UI Elements ..Page Object Model
        public IWebElement txtUserName => WebDriver.FindElement(By.Name("txtUserid"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Name("txtPassword"));

        public IWebElement btnLogin => WebDriver.FindElement(By.Name("btnLogin"));
        public IWebElement Logo => WebDriver.FindElement(By.Id("id_cphMainContent_ClientLogo"));

        //public IWebElement sToFrame => WebDriver.SwitchTo.sToFrame("")
        public IWebElement txtErrMessage => WebDriver.FindElement(By.Id("cvUserID"));
        public void Login(String userName, String Password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(Password);


        }

        public void ClickLoginButton() => btnLogin.Submit();
        public Boolean IsLogoExist() => Logo.Displayed;
        public Boolean IsErrExist() => txtErrMessage.Displayed;
    }
}
