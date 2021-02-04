using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDSpecflowDemo1
{
   public class CustomControl : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            //Driver.Navigate().GoToUrl("http://10.166.7.149/#/login");
            //Driver.FindElement(By.Name("login_username")).SendKeys("parumugam");
            //Driver.FindElement(By.Name("login_password")).SendKeys("qc123!@#");
            //Driver.FindElement(By.Id("login-button")).Click();
        }
    }
}
