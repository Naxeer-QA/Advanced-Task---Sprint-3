using OpenQA.Selenium;
using Sprint_3_AdvancedTask.Tests;
using System;
using TechTalk.SpecFlow;

namespace Sprint_3_AdvancedTask.HookUp
{
    [Binding]
    public class LanguageTestsSteps
    {
        IWebDriver driver;

        [Given(@"I am able to check my Language details under Language Tab")]
        public void GivenIAmAbleToCheckMyLanguageDetailsUnderLanguageTab()
        {
            LanguageTab language = new LanguageTab(driver);
            language.VerifyCopies(driver);
        }
        
        [Given(@"I am able to Add Language details under Language Tab")]
        public void GivenIAmAbleToAddLanguageDetailsUnderLanguageTab()
        {
            LanguageTab language = new LanguageTab(driver);
            language.AddLanguage();
        }
        
        [Given(@"I am able to update or cancel language details under Language Tab")]
        public void GivenIAmAbleToUpdateOrCancelLanguageDetailsUnderLanguageTab()
        {
            LanguageTab language = new LanguageTab(driver);
            language.UpdateOrCancel();
        }
        
        [Given(@"I am able to delete my language details")]
        public void GivenIAmAbleToDeleteMyLanguageDetails()
        {
            LanguageTab language = new LanguageTab(driver);
            language.DeleteLanguage();
        }
    }
}
