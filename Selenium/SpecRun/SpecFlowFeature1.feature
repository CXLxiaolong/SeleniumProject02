@TestDILATO
Feature: login


@TestCaseZenni-1
@ForgotPassword 
Scenario: Verify the workflow of forgot password
	Given forward to the My account page
	When I click the forgot your password button
	And I fill in valid email address and reset password
	Then The Prompt message appears 

@TestCaseZenni-2
@Logout
Scenario: Verify the workflow of logout
	Given forward to the My account page
	And  log in my account
	When I click the my account button
	And I click the sign out button
	Then The account sign out successful

@Selenium-Remote
Scenario Outline: Test Saucelabs login
	Given I connect saucelabs and choose <Browser> of <Version> at <Platform> 
	And   I Forward to the My account page
	When  I fill in all the necessary value on the screen and login
	Then  The account Login successful
Examples: 
	| Browser | Version | Platform   |
	| Firefox | 47.0    | Windows 7  |
