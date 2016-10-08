Feature: YourPreferencesAndContactDetails
	
	In this feature entering all the preferences and contact details and clicking on go to prices button

@PreferencesAndContactDetails
@Browser:Chrome
Scenario: As a user I want to enter the preferences and contact details in your details page and clicking on go to prices button
	Given As a user I am in your details page
	When I enter preferences and contact details in your details page
	And I click on the go to prices button
	Then I should navigate to the your results page 
	

