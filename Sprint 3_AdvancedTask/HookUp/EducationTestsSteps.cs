using OpenQA.Selenium;
using Sprint_3_AdvancedTask.Tests;
using System;
using TechTalk.SpecFlow;

namespace Sprint_3_AdvancedTask.HookUp
{
    [Binding]
    public class EducationTestsSteps
    {
        IWebDriver driver;

        [Given(@"I am able to check my Education details under Education Tab")]
        public void GivenIAmAbleToCheckMyEducationDetailsUnderEducationTab()
        {
            EducationTab Education = new EducationTab(driver);
            Education.VerifyCopies(driver);
        }
        
        [Given(@"I am able to Add Education details under Education Tab")]
        public void GivenIAmAbleToAddEducationDetailsUnderEducationTab()
        {
            EducationTab Education = new EducationTab(driver);
            Education.AddEducation();
        }
        
        [Given(@"I am able to update or cancel Education details under Education Tab")]
        public void GivenIAmAbleToUpdateOrCancelEducationDetailsUnderEducationTab()
        {
            EducationTab Education = new EducationTab(driver);
            Education.UpdateOrCancel();
        }
        
        [Given(@"I am able to delete my Education details")]
        public void GivenIAmAbleToDeleteMyEducationDetails()
        {
            EducationTab Education = new EducationTab(driver);
            Education.DeleteEducation();
        }
    }
}
