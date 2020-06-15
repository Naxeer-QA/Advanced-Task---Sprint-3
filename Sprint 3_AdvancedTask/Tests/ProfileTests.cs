using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sprint_3_AdvancedTask.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_3_AdvancedTask.Tests
{
    class ProfileTests
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
        public void Profile_CopyVerification()
        {
            ProfileTab profile = new ProfileTab(driver);
            profile.VerifyCopies(driver);
        }
        [Test,Order(2)]
        public void Profile_EditAvailability()
        {
            ProfileTab profile = new ProfileTab(driver);
            profile.EditAvailability();
        }
        [Test, Order(3)]
        public void Profile_EditHours()
        {
            ProfileTab profile = new ProfileTab(driver);
            profile.EditHours();
        }
        [Test,Order(4)]
        public void Profile_EditEarnTarget()
        {
            ProfileTab profile = new ProfileTab(driver);
            profile.EditEarnTarget();
        }
    }
}
