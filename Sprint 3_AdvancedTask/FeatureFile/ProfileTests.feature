Feature: ProfileTests
	In order to update my profile details
	As a valid user
	I want to login and update my details successfully

@ProfileDetails
Scenario: As a valid user I check my profile details
	Given I have logged into the website
	And I am able to check my profile details under Profile Tab

Scenario: As a valid user I check and edit my availability details
	Given I have logged into the website
	And I am able to check, edit and remove my availability details under Profile Tab

Scenario: As a valid user I check and edit my Hours details
	Given I have logged into the website
	And I am able to check, edit and remove my Hours details under Profile Tab

Scenario: As a valid user I check and edit my Earn Target details
	Given I have logged into the website
	And I am able to check, edit and remove my Earn Target details under Profile Tab
	
