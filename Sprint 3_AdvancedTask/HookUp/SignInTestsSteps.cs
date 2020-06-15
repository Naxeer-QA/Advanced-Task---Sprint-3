using OpenQA.Selenium;
using Sprint_3_AdvancedTask.Tests;
using System;
using TechTalk.SpecFlow;

namespace Sprint_3_AdvancedTask.HookUp
{
    [Binding]
    public class SignInTestsSteps
    {
        IWebDriver driver;

        [Given(@"I have logged in successfully using valid credentials")]
        public void GivenIHaveLoggedInSuccessfullyUsingValidCredentials()
        {
            SignInPage signin = new SignInPage(driver);
            signin.SignInSuccess(driver);
        }
        
        [Given(@"I have failed to login successfully using invalid Email ID")]
        public void GivenIHaveFailedToLoginSuccessfullyUsingInvalidEmailID()
        {
            SignInPage signin = new SignInPage(driver);
            signin.LoginFailed_EmailID();
        }
        
        [Given(@"I am sent an email verification link")]
        public void GivenIAmSentAnEmailVerificationLink()
        {
            SignInPage signin = new SignInPage(driver);
            signin.VerifyEmailLink();
        }
        
        [Given(@"I have entered valid Email ID using forgot password link")]
        public void GivenIHaveEnteredValidEmailIDUsingForgotPasswordLink()
        {
            SignInPage signin = new SignInPage(driver);
            signin.ResetPassword();
        }
        
        [Given(@"I am able to login successfully using Remember password link")]
        public void GivenIAmAbleToLoginSuccessfullyUsingRememberPasswordLink()
        {
            SignInPage signin = new SignInPage(driver);
            signin.RememberPassword();
        }
    }
}
