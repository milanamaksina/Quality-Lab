Feature: Login

@login@positive
Scenario: Login
	Given registered user
	When open mail.ru home page
	And click on enter button 
	And enter email "test_email_sending_feature@mail.ru"
	And enter password "aplodismenty567"
	Then inbox page should opened 
	And user name must be "test test"
