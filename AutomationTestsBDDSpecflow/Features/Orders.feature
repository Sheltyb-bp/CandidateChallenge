Feature: Orders - Orders Worklist Features

As an Administrator of Medical worklist applciation for Clients 
I would like to View, create and cancel Orders from the Application Orders worklist 
So that I can maintain Client orders for their patients

@Web
@Orders
Scenario: Orders - Navigate to Orders Worklist using URL
	Given I am an Authorised Administrator of the Worklist Orders portal
	When I navigate to the Orders page via the Orders URL
	Then I expect to see the Orders Worklist with the Orders table visible

@Web
@API
@Orders
Scenario: Orders - View Orders Worklist refreshed containing New Orders
	Given I am an Authorised Administrator of the Worklist Orders portal
	When I navigate to the Orders page via the Orders URL
	When I create a New Order via API
	Then I expect to see the Orders Worklist updated with the New Order

@Web
@Orders
Scenario: Orders - View Orders Worklist refreshed after recent Orders have been Cancelled
	Given I am an Authorised Administrator of the Worklist Orders portal
	When I navigate to the Orders page via the Orders URL
	When I create a New Order
	And I cancel an existing Order
	Then I expect to see the Orders Worklist updated excluding cancelled Orders




	
	

