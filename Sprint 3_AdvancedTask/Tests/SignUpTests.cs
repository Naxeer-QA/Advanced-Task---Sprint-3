using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_3_AdvancedTask
{
    class SignUpTests
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            //Initiating Web driver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEachTest()
        {
            driver.Navigate().Refresh();
            //Close browser
            driver.Close();
        }

        [Test,Order(1)]
        public void SignUpSuccessfull()
        {
            //Creating an instance of a class to access the same and it's method
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpSuccess(driver);
        }

        [Test,Order(2)]
        public void SignUpFailureMissingFName()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_Fname(driver);
        }

        [Test,Order(3)]
        public void SignUpFailureMissingLName()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_Lname(driver);
        }

        [Test,Order(4)]
        public void SignUpFailureMissingEmailID()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_NoEmailID(driver);
        }
        [Test,Order(5)]
        public void SignUpFailureMissingPassword()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_NoPassword(driver);
        }
        [Test,Order(6)]
        public void SignUpFailureMissingCPassword()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_NoCPassword(driver);
        }
        [Test, Order(7)]
        public void SignUpFailureMissingCheckBox()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_BoxUnchecked(driver);
        }
        [Test, Order(8)]
        public void SignUpFailure_KnownEmailID()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_EmailID(driver);
        }
        [Test, Order(9)]
        public void SignUp_LoginLink()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUp_Login(driver);
        }
        [Test, Order(10)]
        public void SignUp_TnCLink()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUp_TnC(driver);
        }
    }
}
