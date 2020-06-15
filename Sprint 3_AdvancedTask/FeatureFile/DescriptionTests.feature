Feature: DescriptionTests
	In order to update my profile details
	As a valid user
	I want to login and update my Description details successfully

@ProfileDetails @Description
Scenario: As a valid user I check my Description details
	Given I have logged into the website
	And I am able to check my Description details under Description Tab

Scenario: As a valid user I add a Description under Description tab
	Given I have logged into the website
	And I am able to Add Description details under Description Tab

Scenario: As a valid user I update or cancel a Description details under Description tab
	Given I have logged into the website
	And I am able to update or cancel Description details under Description Tab
