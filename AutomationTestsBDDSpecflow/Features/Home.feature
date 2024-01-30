Feature: Worklist Orders Portal - Home Features

As an Administrator of the worklist Orders portal for Clients 
I would like to launch the Portal Application
So that I can manage orders for Clients and their patients 

@Web
@WorklistPortal_Home
Scenario: Launch the Web Portal via the browser url to verify the WorkList Orders application is active
	Given I am an Authorised Administrator of the Worklist Orders portal
	When I navigate to the base website URL
	Then I should see the Home page by default
	And I should see the Home menu option
	And I should see the Orders menu option

@Web
@WorklistPortal_Orders
Scenario: Access the Orders Worklist from the Home page and return back to Home
	Given I am an Authorised Administrator of the Worklist Orders portal
	When I navigate to the base website URL
	And I navigate to the Orders page via the Orders menu option
	And I select the Home Menu option
	Then I should see the Home page by default