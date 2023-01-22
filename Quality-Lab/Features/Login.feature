Feature: Login
    As a registered user 
	I want to login on mail.ru web site
	To be able to send messages

@login@positive
Scenario: Login
	Given I open mail.ru home page
	And click on enter button 
	When enter email "test_email_sending_feature@mail.ru"
	And enter password "APLODISMENTY567"
	And click on submit button
	Then can open inbox page
	And label account name is "test_email_sending_feature@mail.ru"
