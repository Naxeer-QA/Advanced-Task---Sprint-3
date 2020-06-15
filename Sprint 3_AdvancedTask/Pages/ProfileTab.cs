using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Sprint_3_AdvancedTask.Pages
{
    class ProfileTab
    {
        private IWebDriver driver;

        public ProfileTab(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement SignIn => driver.FindElement(By.XPath("//a[@class='item']"));
        IWebElement EmailID => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement LoginBtn => driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
        IWebElement VerifyLocation => driver.FindElement(By.XPath("//strong[contains(text(),'Location')]"));
        IWebElement VerifyAvailability => driver.FindElement(By.XPath("//strong[contains(text(),'Availability')]"));
        IWebElement VerifyHours => driver.FindElement(By.XPath("//strong[contains(text(),'Hours')]"));
        IWebElement VerifyTarget => driver.FindElement(By.XPath("//strong[contains(text(),'Earn Target')]"));
        IWebElement ChangeAvailability => driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/span[1]/i[1]"));
        IWebElement SelectAvailability => driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/span[1]"));
        IWebElement SelectRemoveIcon => driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/span[1]/i[1]"));

        internal void VerifyCopies(IWebDriver driver)
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(2000);
            VerifyLocation.GetAttribute("Location");
            System.Threading.Thread.Sleep(2000);
            VerifyAvailability.GetAttribute("Availability");
            System.Threading.Thread.Sleep(2000);
            VerifyHours.GetAttribute("Hours");
            System.Threading.Thread.Sleep(2000);
            VerifyTarget.GetAttribute("Earn Target");
            System.Threading.Thread.Sleep(2000);
        }
        internal void EditAvailability()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300)");
            ChangeAvailability.Click();
            System.Threading.Thread.Sleep(2000);
            SelectAvailability.Click();
            System.Threading.Thread.Sleep(2000);
            SelectRemoveIcon.Click();
            System.Threading.Thread.Sleep(2000);
        }
        internal void EditHours()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300)");
            IWebElement ChangeHours = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]/i[1]"));
            ChangeHours.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement SelectHours = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]"));
            SelectHours.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement RemoveIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]/i[1]"));
            RemoveIcon.Click();
            System.Threading.Thread.Sleep(2000);
        }
        internal void EditEarnTarget()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();
            System.Threading.Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300)");
            IWebElement ChangeEarnTarget = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[4]/div[1]/span[1]/i[1]"));
            ChangeEarnTarget.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement SelectEarnTarget = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[4]/div[1]/span[1]"));
            SelectEarnTarget.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement ClickCross = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[4]/div[1]/span[1]/i[1]"));
            ClickCross.Click();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
