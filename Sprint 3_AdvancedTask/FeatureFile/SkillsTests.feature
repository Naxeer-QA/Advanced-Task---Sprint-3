Feature: SkillsTests
	In order to update my profile details
	As a valid user
	I want to login and update my Skills details successfully

@ProfileDetails @Skills
Scenario: As a valid user I check my Skills details
	Given I have logged into the website
	And I am able to check my Skills details under Skills Tab

Scenario: As a valid user I add a Skills under Skills tab
	Given I have logged into the website
	And I am able to Add Skill details under Skills Tab

Scenario: As a valid user I update or cancel a Skills details under Skills tab
	Given I have logged into the website
	And I am able to update or cancel Skills details under Skills Tab

Scenario: As a valid user I delete my Skills details
	Given I have logged into the website
	And I am able to delete my Skills details
