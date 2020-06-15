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
    class EducationTests
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
        public void Education_CopyVerification()
        {
            EducationTab Education = new EducationTab(driver);
            Education.VerifyCopies(driver);
        }
        [Test,Order(2)]
        public void Education_AddEducation()
        {
            EducationTab Education = new EducationTab(driver);
            Education.AddEducation();
        }
        [Test,Order(3)]
        public void Education_UpdateOrCancelLanguage()
        {
            EducationTab Education = new EducationTab(driver);
            Education.UpdateOrCancel();
        }
        [Test,Order(4)]
        public void Education_Delete()
        {
            EducationTab Education = new EducationTab(driver);
            Education.DeleteEducation();
        }
    }
}
