using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Sprint_3_AdvancedTask.Tests
{
    internal class SkillsTab
    {
        private IWebDriver driver;

        public SkillsTab(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement SignIn => driver.FindElement(By.XPath("//a[@class='item']"));
        IWebElement EmailID => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement LoginBtn => driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
        IWebElement SkillTab => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

        internal void VerifyCopies(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            SkillTab.Click();
            System.Threading.Thread.Sleep(2000);
        }
        internal void AddSkill()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            SkillTab.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement AddNewBtn = driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]"));
            AddNewBtn.Click();

            IWebElement AddNewSkill = driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));
            AddNewSkill.SendKeys("Cypress");

            System.Threading.Thread.Sleep(3000);
            IWebElement AddLevel = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            AddLevel.Click();

            IWebElement AddBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
            AddBtn.Click();
            System.Threading.Thread.Sleep(3000);
        }
        internal void UpdateOrCancel()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            SkillTab.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement SkillsEditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[1]/i[1]"));
            SkillsEditIcon.Click();

            IWebElement SkillsCancelBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[1]/div[1]/span[1]/input[2]"));
            SkillsCancelBtn.Click();

            IWebElement SkillsEdit = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[1]/i[1]"));
            SkillsEdit.Click();

            IWebElement SkillsDropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[4]/tr/td/div/div[2]/select"));
            SkillsDropdown.Click();

            IWebElement SkillsSelectLevel = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[4]/tr/td/div/div[2]/select/option[3]"));
            SkillsSelectLevel.Click();

            IWebElement SkillsUpdateBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            SkillsUpdateBtn.Click();
            System.Threading.Thread.Sleep(4000);
        }
        internal void DeleteSkill()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            SkillTab.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement SkillDeleteIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[2]/i[1]"));
            SkillDeleteIcon.Click();
            System.Threading.Thread.Sleep(4000);
        }
    }
}