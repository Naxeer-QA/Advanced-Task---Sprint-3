using OpenQA.Selenium;
using Sprint_3_AdvancedTask.Tests;
using System;
using TechTalk.SpecFlow;

namespace Sprint_3_AdvancedTask.HookUp
{
    [Binding]
    public class CertificationTestsSteps
    {
        IWebDriver driver;

        [Given(@"I am able to check my Certification details under Certification Tab")]
        public void GivenIAmAbleToCheckMyCertificationDetailsUnderCertificationTab()
        {
            CertificationTab Certification = new CertificationTab(driver);
            Certification.VerifyCopies();
        }
        
        [Given(@"I am able to Add Certification details under Certification Tab")]
        public void GivenIAmAbleToAddCertificationDetailsUnderCertificationTab()
        {
            CertificationTab Certification = new CertificationTab(driver);
            Certification.AddCertification();
        }
        
        [Given(@"I am able to update or cancel Certification details under Certification Tab")]
        public void GivenIAmAbleToUpdateOrCancelCertificationDetailsUnderCertificationTab()
        {
            CertificationTab Certification = new CertificationTab(driver);
            Certification.UpdateOrCancel();
        }
        
        [Given(@"I am able to delete my Certification details")]
        public void GivenIAmAbleToDeleteMyCertificationDetails()
        {
            CertificationTab Certification = new CertificationTab(driver);
            Certification.DeleteCertification();
        }
    }
}
