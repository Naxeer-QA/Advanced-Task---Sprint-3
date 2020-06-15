using System;
using OpenQA.Selenium;

namespace Sprint_3_AdvancedTask.Tests
{
    internal class CertificationTab
    {
        private IWebDriver driver;

        public CertificationTab(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement SignIn => driver.FindElement(By.XPath("//a[@class='item']"));
        IWebElement EmailID => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement LoginBtn => driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
        IWebElement CertificationsTab => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        internal void VerifyCopies()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(4000);
            CertificationsTab.Click();
            System.Threading.Thread.Sleep(2000);
        }



        internal void AddCertification()
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
            CertificationsTab.Click();
            js.ExecuteScript("window.scrollBy(0,200)");
            System.Threading.Thread.Sleep(2000);
            IWebElement AddNewBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[4]/div[1]"));
            AddNewBtn.Click();

            IWebElement CertificateName = driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]"));
            CertificateName.Click();
            CertificateName.SendKeys("Internation Software Testing Qualification Board - ISTQB");

            System.Threading.Thread.Sleep(3000);
            IWebElement CertificationSource = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            CertificationSource.Click();
            CertificationSource.SendKeys("ISTQB - India");

            System.Threading.Thread.Sleep(3000);
            IWebElement YearDrowdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            YearDrowdown.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement SelectYear = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[5]"));
            SelectYear.Click();

            IWebElement AddBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
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
            CertificationsTab.Click();
            js.ExecuteScript("window.scrollBy(0,200)");

            System.Threading.Thread.Sleep(2000);
            IWebElement CertificateEditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[4]/span[1]/i[1]"));
            CertificateEditIcon.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement CertificateCancelBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[1]/div[1]/span[1]/input[2]"));
            CertificateCancelBtn.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement CertificateEdit = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[4]/span[1]/i[1]"));
            CertificateEdit.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement CertificateName = driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]"));
            CertificateName.Clear();
            CertificateName.SendKeys("International Software Testing Qualification Board - ISTQB");

            System.Threading.Thread.Sleep(3000);
            IWebElement YearDrowdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td/div/div/div[3]/select"));
            YearDrowdown.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement SelectYear = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td/div/div/div[3]/select/option[6]"));
            SelectYear.Click();

            IWebElement CertificateUpdateBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            CertificateUpdateBtn.Click();
            System.Threading.Thread.Sleep(4000);
        }
        internal void DeleteCertification()
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
            CertificationsTab.Click();
            js.ExecuteScript("window.scrollBy(0,200)");

            IWebElement DeleteCertification = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[4]/span[2]/i[1]"));
            DeleteCertification.Click();
            System.Threading.Thread.Sleep(4000);
            
        }
    }
}