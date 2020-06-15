Feature: RegistrationPage
	In order to use the skillswap website
	As a new user
	I want to be registered successfully

@SignUPSuccessfull
Scenario: User is able to sign up successfully
	Given I have launched the website URL.
	And I should be registered successfully entering all the valid personal inputs.

@SignUpFailureMissingFName
Scenario: User is unable to sign up successfully
	Given I launched the website URL
	And I should not be registered successfully due to missing First Name

@SignUpFailureMissingLName
Scenario: User is unable to sign up successfully
	Given I navigated to the website using valid URL
	And I should not be registered successfully due to missing Last Name

@SignUpFailureMissingEmailID
Scenario: User is unable to sign up successfully
	Given I have navigated to the website using valid URL
	And I should not be registered successfully due to missing EmailID

@SignUpFailureMissingPassword
Scenario: User is unable to sign up successfully
	Given I have launched the website 
	And I should not be registered successfully due to missing Password

@SignUpFailureMissingCPassword
Scenario: User is unable to sign up successfully
	Given I have opened the website using URL
	And I should not be registered successfully due to missing Confirm Password

@SignUpFailureMissingCheckBox
Scenario: User is unable to sign up successfully
	Given I have opened the website 
	And I should not be registered successfully due to missing the TnC Check box

@SignUpFailure_KnownEmailID
Scenario: User is unable to sign up successfully
	Given I have launched the SkillSwap URL
	And I should not be registered successfully due to using known EmailID 

@SignUp_LoginLink
Scenario: User navigates to the login page using Login Link
	Given I have opened the Skillswap website
	And I should be able to navigate to the login page successfully using login link

@SignUp_TnCLink
Scenario: User navigates to the TnC page using TnC Link
	Given I have opened the Skillswap website using URL
	And I should be able to navigate to the Terms and Conditions page successfully using the Terms and Conditions link
