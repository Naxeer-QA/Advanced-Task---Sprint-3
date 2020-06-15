using OpenQA.Selenium;
using Sprint_3_AdvancedTask.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sprint_3_AdvancedTask.HookUp
{
    [Binding]
    public class ProfileTestsSteps
    {
        IWebDriver driver;

        [Given(@"I have logged into the website")]
        public void GivenIHaveLoggedIntoTheWebsite()
        {
            ProfileTab profile = new ProfileTab(driver);
            profile.VerifyCopies(driver);
        }
        
        [Given(@"I am able to check my profile details under Profile Tab")]
        public void GivenIAmAbleToCheckMyProfileDetailsUnderProfileTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am able to check, edit and remove my availability details under Profile Tab")]
        public void GivenIAmAbleToCheckEditAndRemoveMyAvailabilityDetailsUnderProfileTab()
        {
            ProfileTab profile = new ProfileTab(driver);
            profile.EditAvailability();
        }
        
        [Given(@"I am able to check, edit and remove my Hours details under Profile Tab")]
        public void GivenIAmAbleToCheckEditAndRemoveMyHoursDetailsUnderProfileTab()
        {
            ProfileTab profile = new ProfileTab(driver);
            profile.EditHours();
        }
        
        [Given(@"I am able to check, edit and remove my Earn Target details under Profile Tab")]
        public void GivenIAmAbleToCheckEditAndRemoveMyEarnTargetDetailsUnderProfileTab()
        {
            ProfileTab profile = new ProfileTab(driver);
            profile.EditEarnTarget();
        }
    }
}
