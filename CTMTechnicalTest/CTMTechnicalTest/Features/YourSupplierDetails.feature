Feature: YourSupplierDetails

	In this feature entering all the supplier details and clicking next button

@SupplierDetails
@Browser:Chrome
Scenario: As a user I want to enter all the supplier details and click next
		Given As a user I am in your supplier page
		When I have entered the supplier postcode 	
		And I Click on find postcode button
		And I select yes I have my bill option
		And I click on next button
		Then I should navigate to your energy screen
	
