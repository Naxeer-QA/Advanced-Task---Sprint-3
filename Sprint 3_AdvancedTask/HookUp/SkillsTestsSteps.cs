using OpenQA.Selenium;
using Sprint_3_AdvancedTask.Tests;
using System;
using TechTalk.SpecFlow;

namespace Sprint_3_AdvancedTask.HookUp
{
    [Binding]
    public class SkillsTestsSteps
    {
        IWebDriver driver;

        [Given(@"I am able to check my Skills details under Skills Tab")]
        public void GivenIAmAbleToCheckMySkillsDetailsUnderSkillsTab()
        {
            SkillsTab Skills = new SkillsTab(driver);
            Skills.VerifyCopies(driver);
        }
        
        [Given(@"I am able to Add Skill details under Skills Tab")]
        public void GivenIAmAbleToAddSkillDetailsUnderSkillsTab()
        {
            SkillsTab Skills = new SkillsTab(driver);
            Skills.AddSkill();
        }
        
        [Given(@"I am able to update or cancel Skills details under Skills Tab")]
        public void GivenIAmAbleToUpdateOrCancelSkillsDetailsUnderSkillsTab()
        {
            SkillsTab Skills = new SkillsTab(driver);
            Skills.UpdateOrCancel();
        }
        
        [Given(@"I am able to delete my Skills details")]
        public void GivenIAmAbleToDeleteMySkillsDetails()
        {
            SkillsTab Skills = new SkillsTab(driver);
            Skills.DeleteSkill();
        }
    }
}
