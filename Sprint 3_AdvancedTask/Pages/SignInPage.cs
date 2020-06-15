using OpenQA.Selenium;
using System;

namespace Sprint_3_AdvancedTask.Tests
{
    internal class SignInPage
    {

        private IWebDriver driver;

        public SignInPage()
        {
        }

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement SignIn => driver.FindElement(By.XPath("//a[@class='item']"));
        IWebElement EmailID => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement LoginBtn => driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
        IWebElement LogoutBtn => driver.FindElement(By.XPath("//button[@class='ui green basic button']"));
        IWebElement SendVerification => driver.FindElement(By.XPath("//button[@id='submit-btn']"));
        IWebElement PasswordReset => driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[1]/a[1]"));
        IWebElement SendVerificationEmail => driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/div[1]/div[2]/div[1]"));
        IWebElement RememberYourPassword => driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/a[1]"));
        IWebElement CheckBox => driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/input[1]"));
        internal void SignInSuccess(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            LogoutBtn.Click();
            System.Threading.Thread.Sleep(4000);
        }
        internal void LoginFailed_EmailID()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("sldkfjaldfkja");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
        }
        internal void VerifyEmailLink()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("NewTester@gmail.com");
            password.SendKeys("mother");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            SendVerification.Click();
            System.Threading.Thread.Sleep(2000);
        }
        internal void ResetPassword()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            PasswordReset.Click();
            EmailID.SendKeys("NewTester@gmail.com");
            SendVerificationEmail.Click();
            System.Threading.Thread.Sleep(2000);
        }
        internal void RememberPassword()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            PasswordReset.Click();
            RememberYourPassword.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            CheckBox.Click();
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            LogoutBtn.Click();
            System.Threading.Thread.Sleep(4000);
        }
    }
}