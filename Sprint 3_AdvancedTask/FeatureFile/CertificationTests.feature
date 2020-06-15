Feature: CertificationTests
	In order to update my profile details
	As a valid user
	I want to login and update my Certification details successfully

@ProfileDetails @Certification
Scenario: As a valid user I check my Certification details
	Given I have logged into the website
	And I am able to check my Certification details under Certification Tab

Scenario: As a valid user I add a Certification under Certification tab
	Given I have logged into the website
	And I am able to Add Certification details under Certification Tab

Scenario: As a valid user I update or cancel a Certification details under Certification tab
	Given I have logged into the website
	And I am able to update or cancel Certification details under Certification Tab

Scenario: As a valid user I delete my Certification details
	Given I have logged into the website
	And I am able to delete my Certification details
