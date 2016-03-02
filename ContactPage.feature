Feature: Contact Us Page 2
  As an end user
  I want a contact us page
  So that I can find out more about QAWorks exciting services

 Scenario: Valid Submission
	Given I am on the QAWorks Staging Site
	Then I should be able to contact QAWorks with the following information 
	| name      | email                | message                                    |
	| j.Bloggs6 | j.Bloggs@qaworks.com | 'please contact me I want to find out more'|

 Scenario: Invalid EmailSubmission
	Given I am on the QAWorks Staging Site
	When I Send message with invalid email
	| name      | email                | message                                    |
	| j.Bloggs6 | invalidemail | 'please contact me I want to find out more'|
	Then Invalid email error message is displayed 
	
	
	 