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
    class DescriptionTests
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
            driver.Navigate().Refresh();
            driver.Close();
        }
        [Test,Order(1)]
        public void Description_CopyVerfication()
        {
            DescriptionTab Description = new DescriptionTab(driver);
            Description.VerifyCopies();
        }
        [Test,Order(2)]
        public void Description_AddDescription()
        {
            DescriptionTab Description = new DescriptionTab(driver);
            Description.AddDescription();
        }
        [Test, Order(3)]
        public void Description_UpdateDescription()
        {
            DescriptionTab Description = new DescriptionTab(driver);
            Description.UpdateDescription();
        }
        //[Test,Order(4)]
        //public void Description_DeleteDescription()
        //{
        //    DescriptionTab Description = new DescriptionTab(driver);
        //    Description.DeleteDescription();
        //}
    }
}
