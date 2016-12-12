@TestDILATO
Feature: login


@TestCaseZenni-1
@ForgotPassword 
Scenario: Verify the workflow of forgot password
	Given To the My account page
	When I click the forgot your password button
	And I fill in valid email address and reset password
	Then The Prompt message appears 

@TestCaseZenni-2
@ForgotPassword 
Scenario: Verify the error email address of forgot password 
	Given I forward to the My account page
	When I click the forgot your password button
	And I fill in error email address and reset password 
	Then The error popup occurred and reset password failed

@TestCaseZenni-3
@Logout
Scenario: Verify the workflow of logout
	Given I forward to the My account page 
	And  log in my account
	When I click the my account button
	And I click the sign out button
	Then The account sign out successful

@TestCaseZenni-4
@Logout
Scenario: Verify no login account click Account Overview the jump to the login page
	Given I forward to the My account page
	When I click the my account button
	And I click the Account Overview button
	Then The jump to login page


@Selenium-Remote
Scenario Outline: Test Saucelabs login
	Given I connect saucelabs and choose <Browser> of <Version> at <Platform> 
	And   Forward to the My account page
	When  I fill in all the necessary value on the screen and login
	Then  The account Login successful
Examples: 
	| Browser | Version | Platform   |
	| Firefox | 47.0    | Windows 7  |
	| Chrome  | 50.0    | Windows 10 |


@Selenium-Remote-logfail
Scenario Outline: Test Saucelabs logfail
	Given I connect saucelabs and choose <Browser> of <Version> at <Platform> 
	And   Forward to the My account page
	When I fill in all the error value on the screen and login
	Then The error popup occurred and login failed
Examples: 
	| Browser | Version | Platform   |
	| Firefox | 47.0    | Windows 7  |
	| Chrome  | 50.0    | Windows 10 |