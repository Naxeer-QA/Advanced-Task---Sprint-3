Feature: EducationTests
	In order to update my profile details
	As a valid user
	I want to login and update my Education details successfully

@ProfileDetails @Education
Scenario: As a valid user I check my Education details
	Given I have logged into the website
	And I am able to check my Education details under Education Tab

Scenario: As a valid user I add a Education under Education tab
	Given I have logged into the website
	And I am able to Add Education details under Education Tab

Scenario: As a valid user I update or cancel a Education details under Education tab
	Given I have logged into the website
	And I am able to update or cancel Education details under Education Tab

Scenario: As a valid user I delete my Education details
	Given I have logged into the website
	And I am able to delete my Education details
