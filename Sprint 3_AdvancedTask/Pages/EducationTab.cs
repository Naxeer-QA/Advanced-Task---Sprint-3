using System;
using OpenQA.Selenium;

namespace Sprint_3_AdvancedTask.Tests
{
    internal class EducationTab
    {
        private IWebDriver driver;

        public EducationTab(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement SignIn => driver.FindElement(By.XPath("//a[@class='item']"));
        IWebElement EmailID => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement LoginBtn => driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
        IWebElement EducationsTab => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
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
            EducationsTab.Click();
            System.Threading.Thread.Sleep(2000);
        }
        internal void AddEducation()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            EducationsTab.Click();
            js.ExecuteScript("window.scrollBy(0,200)");
            System.Threading.Thread.Sleep(2000);
            IWebElement AddNewBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[6]/div[1]"));
            AddNewBtn.Click();

            IWebElement UniName = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            UniName.Click();
            UniName.SendKeys("Auckland Institute Of Studies");

            System.Threading.Thread.Sleep(3000);
            IWebElement CountryDropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            CountryDropdown.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement SelectCountry = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
            SelectCountry.Click();

            IWebElement TitleDrowdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            TitleDrowdown.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement SelectTitle = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[3]"));
            SelectTitle.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement DegreeName = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));
            DegreeName.Click();
            DegreeName.SendKeys("Graduate Diploma in Information Technology");

            System.Threading.Thread.Sleep(3000);
            IWebElement YearDropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            YearDropdown.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement SelectYear = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[4]"));
            SelectYear.Click();

            IWebElement AddBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            AddBtn.Click();
            System.Threading.Thread.Sleep(3000);
        }
        internal void UpdateOrCancel()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            EducationsTab.Click();
            js.ExecuteScript("window.scrollBy(0,200)");
            System.Threading.Thread.Sleep(2000);
            IWebElement EducationEditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[1]/i[1]"));
            EducationEditIcon.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement EducationCancelBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[3]/input[2]"));
            EducationCancelBtn.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement EducationEdit = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[1]/i[1]"));
            EducationEdit.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement TitleDrowdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            TitleDrowdown.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement SelectTitle = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select/option[7]"));
            SelectTitle.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement YearDropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
            YearDropdown.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement SelectYear = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select/option[5]"));
            SelectYear.Click();

            IWebElement EducationUpdateBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[3]/input[1]"));
            EducationUpdateBtn.Click();
            System.Threading.Thread.Sleep(4000);
        }
        internal void DeleteEducation()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            EducationsTab.Click();
            js.ExecuteScript("window.scrollBy(0,200)");
            System.Threading.Thread.Sleep(2000);
            IWebElement DeleteEducation = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[2]/i[1]"));
            DeleteEducation.Click();
            System.Threading.Thread.Sleep(4000);
        }
    }
}