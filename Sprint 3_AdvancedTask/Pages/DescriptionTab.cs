using System;
using OpenQA.Selenium;

namespace Sprint_3_AdvancedTask.Tests
{
    internal class DescriptionTab
    {
        private IWebDriver driver;

        public DescriptionTab(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement SignIn => driver.FindElement(By.XPath("//a[@class='item']"));
        IWebElement EmailID => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement LoginBtn => driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
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
        }

        internal void AddDescription()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();

            System.Threading.Thread.Sleep(4000);
            IWebElement DescEditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]"));
            DescEditIcon.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement DescriptionBox = driver.FindElement(By.XPath("//textarea[@name='value']"));
            DescriptionBox.Clear();
            DescriptionBox.SendKeys("In publishing and graphic design, lorem ipsum is a placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying on meaningful content. Lorem ipsum may be used before final copy is available, but it may also be used to temporarily replace copy in a process called greeking, which allows designers to consider form without the meaning of the text influencing the design. Lorem ipsum is typically a corrupted version of De finibus bonorum et malorum, a first-century BCE text by Cicero, with words altered, added, and removed to make it nonsensical, ");

            IWebElement DescSaveBtn = driver.FindElement(By.XPath("//button[@type='button']"));
            DescSaveBtn.Click();
            System.Threading.Thread.Sleep(2000);
        }
        internal void UpdateDescription()
        {
            //Launching google chrome browser
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn.Click();
            EmailID.SendKeys("nazmohammed.nz@gmail.com");
            password.SendKeys("password2");
            LoginBtn.Click();

            System.Threading.Thread.Sleep(4000);
            IWebElement DescEditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]"));
            DescEditIcon.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement DescriptionBox = driver.FindElement(By.XPath("//textarea[@name='value']"));
            DescriptionBox.Clear();
            DescriptionBox.SendKeys("Testing the update feature of Description");

            IWebElement DescSaveBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/button[1]"));
            DescSaveBtn.Click();
            System.Threading.Thread.Sleep(2000);
            //driver.Navigate().Refresh();
        }
        //internal void DeleteDescription()
        //{
        //    //Launching google chrome browser
        //    System.Threading.Thread.Sleep(2000);
        //    driver.Navigate().GoToUrl("http://localhost:5000/");
        //    SignIn.Click();
        //    EmailID.SendKeys("nazmohammed.nz@gmail.com");
        //    password.SendKeys("password2");
        //    LoginBtn.Click();

        //    System.Threading.Thread.Sleep(4000);
        //    IWebElement DescEditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]"));
        //    DescEditIcon.Click();

        //    System.Threading.Thread.Sleep(2000);
        //    IWebElement DescriptionBox = driver.FindElement(By.XPath("//textarea[@name='value']"));
        //    DescriptionBox.Clear();

        //    IWebElement DescSaveBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/button[1]"));
        //    DescSaveBtn.Click();
        //    System.Threading.Thread.Sleep(2000);

        //    IWebElement SaveErrorCopy = driver.FindElement(By.XPath("/html/body/div[1]"));
        //    DescSaveBtn.GetAttribute("Please, a description is required");
        //    System.Threading.Thread.Sleep(2000);
        //}
    }
}