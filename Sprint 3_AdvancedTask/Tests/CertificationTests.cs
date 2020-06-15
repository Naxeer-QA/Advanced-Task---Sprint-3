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
    class CertificationTests
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
        public void Certification_CopyVerification()
        {
            CertificationTab Certification = new CertificationTab(driver);
            Certification.VerifyCopies();
        }
        [Test,Order(2)]
        public void Certification_AddCertification()
        {
            CertificationTab Certification = new CertificationTab(driver);
            Certification.AddCertification();
        }
        [Test,Order(3)]
        public void Certification_UpdateOrCancelLanguage()
        {
            CertificationTab Certification = new CertificationTab(driver);
            Certification.UpdateOrCancel();
        }
        [Test,Order(4)]
        public void Certification_DeleteCertificate()
        {
            CertificationTab Certification = new CertificationTab(driver);
            Certification.DeleteCertification();
        }
    }
}
