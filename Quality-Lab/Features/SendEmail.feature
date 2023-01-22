Feature: SendEmail
     As user
	 I want to send yourself an email 
	 To check sending service


Background:
    Given I open mail.ru home page
	And click on enter button 
	When enter email "test_email_sending_feature@mail.ru"
	And enter password "APLODISMENTY567"
	And click on submit button
  

@sendEmail@positive
Scenario: Send email
	Given I open mail.ru inbox page
	And click on button write message
	When I enter the addressee "test_email_sending_feature@mail.ru"
	And write a message "Hello" 
	And click on send button 
	Then I can see the notification with text "Письмо отправлено"
