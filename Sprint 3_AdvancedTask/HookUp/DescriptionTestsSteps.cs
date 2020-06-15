using OpenQA.Selenium;
using Sprint_3_AdvancedTask.Tests;
using System;
using TechTalk.SpecFlow;

namespace Sprint_3_AdvancedTask.HookUp
{
    [Binding]
    public class DescriptionTestsSteps
    {
        IWebDriver driver;

        [Given(@"I am able to check my Description details under Description Tab")]
        public void GivenIAmAbleToCheckMyDescriptionDetailsUnderDescriptionTab()
        {
            DescriptionTab Description = new DescriptionTab(driver);
            Description.VerifyCopies();
        }
        
        [Given(@"I am able to Add Description details under Description Tab")]
        public void GivenIAmAbleToAddDescriptionDetailsUnderDescriptionTab()
        {
            DescriptionTab Description = new DescriptionTab(driver);
            Description.AddDescription();
        }
        
        [Given(@"I am able to update or cancel Description details under Description Tab")]
        public void GivenIAmAbleToUpdateOrCancelDescriptionDetailsUnderDescriptionTab()
        {
            DescriptionTab Description = new DescriptionTab(driver);
            Description.UpdateDescription();
        }
    }
}
