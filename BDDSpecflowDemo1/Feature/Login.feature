Feature: Login
	Login to VLCSManager web app

	# Best Practice is creating Independent test scenarios
Background: 
@smoke
Scenario: Check Super User Login of VLCSManager with valid credentials
#we can add multiple scenarios in a single feature file(like User stories mapped to EPIC)
	Given I launch the application
	And I enter the following details
		| UserName | Password |
		| 654321   | 654321   |
	When I click login button
	Then I should see WV Logo
	#Then I see a gamerevenue of "3000"

	
	Scenario: Check Super User Login of VLCSManager with incorrect login credentials
	Given I launch the application
	And I enter the following details
		| UserName | Password |
		| PAUL     | PAUL   |
	When I click login button
	Then I should see an error message




	Scenario Outline: Check if an Internal user can login to both the VLCSManager and Portal with valid credentials
	Given I launch the application with <url>
	And I enter the following details
		| UserName | Password |
		| 654321   | 654321   |
	When I click login button
	Then I should see WV Logo
		

	Examples:
		| Url                                          |
		| http://172.30.209.32/VLCSManager/Portal.aspx |
		| http://172.30.209.147/WebPortal/Login.aspx |