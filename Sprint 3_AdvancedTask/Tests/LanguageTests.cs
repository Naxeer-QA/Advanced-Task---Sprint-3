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
    class LanguageTests
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
        public void Language_CopyVerification()
        {
            LanguageTab language = new LanguageTab(driver);
            language.VerifyCopies(driver);
        }
        [Test,Order(2)]
        public void Language_AddLanguage()
        {
            LanguageTab language = new LanguageTab(driver);
            language.AddLanguage();
        }
        [Test,Order(3)]
        public void Language_UpdateOrCancelLanguage()
        {
            LanguageTab language = new LanguageTab(driver);
            language.UpdateOrCancel();
        }
        [Test,Order(4)]
        public void Language_Delete()
        {
            LanguageTab language = new LanguageTab(driver);
            language.DeleteLanguage();
        }
    }
}
