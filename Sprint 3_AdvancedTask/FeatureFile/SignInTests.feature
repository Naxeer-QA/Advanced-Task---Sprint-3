Feature: SignInTests
	In order to use skillswap website
	As a valid user
	I want to be logged in to the website successfully

@LoginTests
Scenario: User is able to Login Successfully
	Given I have opened the website
	And I have logged in successfully using valid credentials

Scenario: User failed to Login Successfully
	Given I have opened the website
	And I have failed to login successfully using invalid Email ID

Scenario: User receives an email verification link
	Given I have opened the website
	And I am sent an email verification link

Scenario: User clicks on Forgot password link
	Given I have opened the website
	And I have entered valid Email ID using forgot password link

Scenario: User is navigated to the login using using Remember password link
	Given I have opened the website
	And I am able to login successfully using Remember password link

