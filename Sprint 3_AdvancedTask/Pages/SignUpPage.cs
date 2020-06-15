using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_3_AdvancedTask
{
    class SignUpPage
    {
        public IWebDriver driver;

        public SignUpPage()
        {
        }

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement JoinPage => driver.FindElement(By.XPath("//button[@class='ui green basic button']"));
        IWebElement FirstName => driver.FindElement(By.XPath("//input[@placeholder='First name']"));
        IWebElement LastName => driver.FindElement(By.XPath("//input[@placeholder='Last name']"));
        IWebElement EmailID => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement confirmpassword => driver.FindElement(By.XPath("//input[@placeholder='Confirm Password']"));
        IWebElement TnCcheckbox => driver.FindElement(By.XPath("//input[@name='terms']"));
        IWebElement JoinBtn => driver.FindElement(By.XPath("//div[@id='submit-btn']"));

        //Creating a method
        public void SignUpSuccess(IWebDriver driver)
        {
            //System.Threading.Thread.Sleep(7000);
            //Utilities.ExcelLibHelpers.PopulateInCollection(@"D:\IndustryConnect\Automation\MVP_MARSproject\Sprint_3\Sprint 3_AdvancedTask\Sprint 3_AdvancedTask\TestData\TestData.xlsx","SignUpPage");

            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");

            JoinPage.Click();

            //FirstName.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "FirstName"));
            FirstName.SendKeys("Bumble");

            //LastName.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "LastName"));
            LastName.SendKeys("Bee");

            //EmailID.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "EmailAddress"));
            EmailID.SendKeys("BumbleBee@gmail.com");

            //password.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "Password"));
            password.SendKeys("mother");

            //confirmpassword.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "ConfirmPassword"));
            confirmpassword.SendKeys("mother");
            TnCcheckbox.Click();
            //JoinBtn.Click();
        }
        public void SignUpFailed_Fname(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            JoinPage.Click();
            FirstName.SendKeys("");
            LastName.SendKeys("Bee");
            EmailID.SendKeys("BumbleBee@gmail.com");
            password.SendKeys("mother");
            confirmpassword.SendKeys("mother");
            TnCcheckbox.Click();
            JoinBtn.Click();
        }
        internal void SignUpFailed_Lname(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            JoinPage.Click();
            FirstName.SendKeys("Bumble");
            LastName.SendKeys("");
            EmailID.SendKeys("BumbleBee@gmail.com");
            password.SendKeys("mother");
            confirmpassword.SendKeys("mother");
            TnCcheckbox.Click();
            JoinBtn.Click();
        }
        internal void SignUpFailed_NoEmailID(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            JoinPage.Click();
            FirstName.SendKeys("Bumble");
            LastName.SendKeys("Bee");
            EmailID.SendKeys("");
            password.SendKeys("mother");
            confirmpassword.SendKeys("mother");
            TnCcheckbox.Click();
            JoinBtn.Click();
        }
        internal void SignUpFailed_NoPassword(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            JoinPage.Click();
            FirstName.SendKeys("Bumble");
            LastName.SendKeys("Bee");
            EmailID.SendKeys("BumbleBee@gmail.com");
            password.SendKeys("");
            confirmpassword.SendKeys("mother");
            TnCcheckbox.Click();
            JoinBtn.Click();
        }
        internal void SignUpFailed_NoCPassword(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            JoinPage.Click();
            FirstName.SendKeys("Bumble");
            LastName.SendKeys("Bee");
            EmailID.SendKeys("BumbleBee@gmail.com");
            password.SendKeys("mother");
            confirmpassword.SendKeys("");
            TnCcheckbox.Click();
            JoinBtn.Click();
        }
        internal void SignUpFailed_BoxUnchecked(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            JoinPage.Click();
            FirstName.SendKeys("Bumble");
            LastName.SendKeys("Bee");
            EmailID.SendKeys("BumbleBee@gmail.com");
            password.SendKeys("mother");
            confirmpassword.SendKeys("mother");
            JoinBtn.Click();
        }
        internal void SignUpFailed_EmailID(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            JoinPage.Click();
            FirstName.SendKeys("Bumble");
            LastName.SendKeys("Bee");
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            System.Threading.Thread.Sleep(2000);
            password.SendKeys("mother");
            confirmpassword.SendKeys("mother");
            TnCcheckbox.Click();
            JoinBtn.Click();
            System.Threading.Thread.Sleep(2000);
        }
        internal void SignUp_Login(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            JoinPage.Click();
            IWebElement LoginLink = driver.FindElement(By.XPath("//a[@class='pointerCursor']"));
            LoginLink.Click();
            System.Threading.Thread.Sleep(2000);
        }
        internal void SignUp_TnC(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            JoinPage.Click();
            IWebElement TnCLink = driver.FindElement(By.XPath("//a[contains(text(),'terms and conditions')]"));
            TnCLink.Click();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
