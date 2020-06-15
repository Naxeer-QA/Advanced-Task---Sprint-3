using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_3_AdvancedTask.Tests
{
    class SignInTests
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void AfterEachTest()
        {
            driver.Close();
        }

        [Test,Order(1)]
        public void LoginSuccessfull()
        {
            SignInPage signin = new SignInPage(driver);
            signin.SignInSuccess(driver);
        }
        [Test, Order(2)]
        public void LoginFailed_InvalidEmailID()
        {
            SignInPage signin = new SignInPage(driver);
            signin.LoginFailed_EmailID();
        }
        [Test,Order(3)]
        public void Login_EmailLinkVerify()
        {
            SignInPage signin = new SignInPage(driver);
            signin.VerifyEmailLink();
        }
        [Test,Order(4)]
        public void Login_ForgotPassward()
        {
            SignInPage signin = new SignInPage(driver);
            signin.ResetPassword();
        }
        [Test,Order(5)]
        public void Login_RememberPassword()
        {
            SignInPage signin = new SignInPage(driver);
            signin.RememberPassword();
        }
    }
}
