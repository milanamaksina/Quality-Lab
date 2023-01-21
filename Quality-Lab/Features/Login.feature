Feature: Login

@login@positive
Scenario: Login
	Given registered user
	When open mail.ru home page
	And click on enter button 
	And enter email "test_email_sending_feature@mail.ru"
	And enter password "APLODISMENTY567"
	Then can open inbox page
	And label account name must be "test_email_sending_feature@mail.ru"
