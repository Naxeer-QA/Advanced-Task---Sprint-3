Feature: LanguageTests
	In order to update my profile details
	As a valid user
	I want to login and update my language details successfully

@ProfileDetails @Language
Scenario: As a valid user I check my Language details
	Given I have logged into the website
	And I am able to check my Language details under Language Tab

Scenario: As a valid user I add a language under language tab
	Given I have logged into the website
	And I am able to Add Language details under Language Tab

Scenario: As a valid user I update or cancel a language details under language tab
	Given I have logged into the website
	And I am able to update or cancel language details under Language Tab

Scenario: As a valid user I delete my language details
	Given I have logged into the website
	And I am able to delete my language details
