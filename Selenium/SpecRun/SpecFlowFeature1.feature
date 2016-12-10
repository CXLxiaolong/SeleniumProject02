﻿@TestDILATO
Feature: login


@TestCaseZenni-1
@loginCases
Scenario: Verify the workflow of My account login
	Given I forward to the My account page 
	When I fill in all the necessary value on the screen and login
	Then The account Login successful

@TestCaseZenni-2
@loginCases
Scenario: Verify the workflow of My account login failed
	Given I forward to the My account page
	When I fill in all the error value on the screen and login
	Then The error popup occurred and login failed

@TestCaseZenni-3
@ForgotPassword 
Scenario: Verify the workflow of forgot password
	Given I forward to the My account page
	When I click the forgot your password button
	And I fill in valid email address and reset password
	Then The Prompt message appears 

@TestCaseZenni-4
@ForgotPassword 
Scenario: Verify the error email address of forgot password 
	Given I forward to the My account page
	When I click the forgot your password button
	And I fill in error email address and reset password 
	Then The error popup occurred and reset password failed

@TestCaseZenni-5
@Logout
Scenario: Verify the workflow of logout
	Given I forward to the My account page 
	And  log in my account
	When I click the my account button
	And I click the sign out button
	Then The account sign out successful

@TestCaseZenni-6
@Logout
Scenario: Verify no login account click Account Overview the jump to the login page
	Given I forward to the My account page
	When I click the my account button
	And I click the Account Overview button
	Then The jump to login page


@Selenium-Remote
Scenario Outline: Test Saucelabs
	Given I connect saucelabs and choose <Browser> of <Version> at <Platform> 
	And   Forward to the My account page
	When  I fill in all the necessary value on the screen and login
	Then  The account Login successful
Examples: 
	| Browser | Version | Platform   |
	| Firefox | 47.0    | Windows 7  |
	| Chrome  | 50.0    | Windows 10 |
	| Safari  | 9.0     | OS X 10.11 |