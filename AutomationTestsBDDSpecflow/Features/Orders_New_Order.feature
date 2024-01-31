Feature: Orders - Create New Orders

As an Authorised Administrator of Medical Orders worklist portal for Clients 
I would like to Create New Orders
So that I can generate more Patients Orders for our Clients

@Web
@Orders_New_Order
Scenario: Orders - New Order - Create New Order and Cancel with no details
	Given I am an Authorised Administrator of the Worklist Orders portal
	When I navigate to the Orders page via the Orders URL
	When I Create a New Order 
	And I cancel the New Order before submitting
	Then I expect to see the Orders Worklist page


@Web
@Orders_New_Order
Scenario: Orders - New Order - Fill in New Order Details and Cancel before submit
	Given I am an Authorised Administrator of the Worklist Orders portal
	When I navigate to the Orders page via the Orders URL
	When I Create a New Order 
	And I fill in the New Patient details with valid values
	And I fill in the Study Details valid values
	And I cancel the New Order before submitting
	Then I expect to see the Orders Worklist page


@Web
@Orders_New_Order
Scenario: Orders - New Order - Create New Order using only mandatory fields
	Given I am an Authorised Administrator of the Worklist Orders portal
	When I navigate to the Orders page via the Orders URL
	When I Create a New Order 
	And I submit the New Order with only mandatory fields filled in with valid values
	Then I expect to see the Order successfully created
	And I expect to see the New Order in the Orders Worklist


@Web
@Orders_New_Order
Scenario: Orders - New Order - Attempt to Create New Order while missing all fields
	Given I am an Authorised Administrator of the Worklist Orders portal
	When I navigate to the Orders page via the Orders URL
	When I Create a New Order 
	And I submit the New Order with no fields filled in
	Then I expect to remain on the Create Orders page
	And I expect to see field validation error messages for all mandatory Orders fields



