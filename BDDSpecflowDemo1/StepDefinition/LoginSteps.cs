using BDDSpecflowDemo1.Pages;
using NUnit.Framework;
//using SeleniumCSharpNetCore.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDSpecflowDemo1.StepDefinition
{
    [Binding]
    public sealed class LoginSteps
    {

        LoginPage loginPage = null;

        // STEP DEFINITIONS FOR THE LOGIN FEATURE
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            OpenQA.Selenium.IWebDriver webDriver = new ChromeDriver();

            webDriver.Navigate().GoToUrl("http://172.30.209.32/VLCSManager/Portal.aspx");
            loginPage = new LoginPage(webDriver);
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            string test = data.UserName.GetType().ToString();
            loginPage.Login(data.UserName.ToString(), data.Password.ToString());
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see WV Logo")]
        public void ThenIShouldSeeWVLogo()
        {
            Thread.Sleep(9000);
            //Assert.That(loginPage.IsLogoExist(), Is.True);
            Assert.That(loginPage.IsErrExist(), Is.False);

        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Task.Delay(2000);
            Assert.That(loginPage.IsErrExist(), Is.True);
        }

    }
}
