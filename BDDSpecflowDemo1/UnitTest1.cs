using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BDDSpecflowDemo1
{
    public class Tests : DriverHelper
    {
       // public static IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            //Driver.Navigate().GoToUrl("http://10.166.7.149/#/login");
            //Driver.FindElement(By.Name("login_username")).SendKeys("parumugam");
            //Driver.FindElement(By.Name("login_password")).SendKeys("qc123!@#");
            //Driver.FindElement(By.Id("login-button")).Click();
            Driver.Navigate().GoToUrl("http://172.30.209.135/ConnexusUI");
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("//*[@placeholder='Username']")).SendKeys("654321");
            IWebElement pass = Driver.FindElement(By.XPath("//*[@placeholder='Password']"));
            pass.SendKeys("654321");
            Driver.FindElement(By.XPath("//button[contains (text(),'SIGN IN')]")).Click();
            Console.WriteLine("Connexus BDD Test ");
            //Assert.Pass();
        }
    }
}