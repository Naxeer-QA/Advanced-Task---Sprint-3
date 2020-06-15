using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Sprint_3_AdvancedTask.HookUp
{
    [Binding]
    public class RegistrationPageSteps
    {
        IWebDriver driver;

        [Given(@"I have launched the website URL\.")]
        public void GivenIHaveLaunchedTheWebsiteURL_()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should be registered successfully entering all the valid personal inputs\.")]
        public void GivenIShouldBeRegisteredSuccessfullyEnteringAllTheValidPersonalInputs_()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpSuccess(driver);
        }
        
        [Given(@"I launched the website URL")]
        public void GivenILaunchedTheWebsiteURL()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should not be registered successfully due to missing First Name")]
        public void GivenIShouldNotBeRegisteredSuccessfullyDueToMissingFirstName()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_Fname(driver);
        }
        
        [Given(@"I navigated to the website using valid URL")]
        public void GivenINavigatedToTheWebsiteUsingValidURL()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should not be registered successfully due to missing Last Name")]
        public void GivenIShouldNotBeRegisteredSuccessfullyDueToMissingLastName()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_Lname(driver);
        }
        
        [Given(@"I have navigated to the website using valid URL")]
        public void GivenIHaveNavigatedToTheWebsiteUsingValidURL()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should not be registered successfully due to missing EmailID")]
        public void GivenIShouldNotBeRegisteredSuccessfullyDueToMissingEmailID()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_NoEmailID(driver);
        }
        
        [Given(@"I have launched the website")]
        public void GivenIHaveLaunchedTheWebsite()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should not be registered successfully due to missing Password")]
        public void GivenIShouldNotBeRegisteredSuccessfullyDueToMissingPassword()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_NoPassword(driver);
        }
        
        [Given(@"I have opened the website using URL")]
        public void GivenIHaveOpenedTheWebsiteUsingURL()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should not be registered successfully due to missing Confirm Password")]
        public void GivenIShouldNotBeRegisteredSuccessfullyDueToMissingConfirmPassword()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_NoCPassword(driver);
        }
        
        [Given(@"I have opened the website")]
        public void GivenIHaveOpenedTheWebsite()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should not be registered successfully due to missing the TnC Check box")]
        public void GivenIShouldNotBeRegisteredSuccessfullyDueToMissingTheTnCCheckBox()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_BoxUnchecked(driver);
        }
        
        [Given(@"I have launched the SkillSwap URL")]
        public void GivenIHaveLaunchedTheSkillSwapURL()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should not be registered successfully due to using known EmailID")]
        public void GivenIShouldNotBeRegisteredSuccessfullyDueToUsingKnownEmailID()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpFailed_EmailID(driver);
        }
        
        [Given(@"I have opened the Skillswap website")]
        public void GivenIHaveOpenedTheSkillswapWebsite()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should be able to navigate to the login page successfully using login link")]
        public void GivenIShouldBeAbleToNavigateToTheLoginPageSuccessfullyUsingLoginLink()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUp_Login(driver);
        }
        
        [Given(@"I have opened the Skillswap website using URL")]
        public void GivenIHaveOpenedTheSkillswapWebsiteUsingURL()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I should be able to navigate to the Terms and Conditions page successfully using the Terms and Conditions link")]
        public void GivenIShouldBeAbleToNavigateToTheTermsAndConditionsPageSuccessfullyUsingTheTermsAndConditionsLink()
        {
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUp_TnC(driver);
        }
    }
}
