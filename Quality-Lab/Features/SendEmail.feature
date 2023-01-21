Feature: SendEmail

@mytag
Scenario: Send email
	Given registered user
	| email                              | password        |
	| test_email_sending_feature@mail.ru | aplodismenty567 |
	When open home page 
	And click on enter button 
	And Enter email "test_email_sending_feature@mail.ru"
	And Enter password "aplodismenty567"
	Then the result should be 120
