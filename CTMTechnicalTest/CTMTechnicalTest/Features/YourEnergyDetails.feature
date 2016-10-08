Feature: YourEnergyDetails
	
	In this feature enetering all the energy details

@EnteringEnergyDetails
@Browser:Chrome
Scenario: As a user I want enter all the energy details in your energy screen and click next button
	Given As a user I am in your energy page
	When I enter all the energy details in your energy screen
	And I click on the next button
	Then I should navigate to the your details page
