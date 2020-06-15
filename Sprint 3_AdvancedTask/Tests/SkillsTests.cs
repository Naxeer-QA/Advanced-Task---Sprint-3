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
    class SkillsTests
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
        public void Skills_CopyVerification()
        {
            SkillsTab Skills = new SkillsTab(driver);
            Skills.VerifyCopies(driver);
        }
        [Test,Order(2)]
        public void Skills_AddSkill()
        {
            SkillsTab Skills = new SkillsTab(driver);
            Skills.AddSkill();
        }
        [Test, Order(3)]
        public void Skills_UpdateOrCancelLanguage()
        {
            SkillsTab Skills = new SkillsTab(driver);
            Skills.UpdateOrCancel();
        }
        [Test,Order(4)]
        public void Skill_Delete()
        {
            SkillsTab Skills = new SkillsTab(driver);
            Skills.DeleteSkill();
        }
    }
}
