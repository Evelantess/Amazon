Feature: CartCheck
	In order to be able to order a product
	As a non-registered user
	I want to be able to add an item to the cart

Scenario: CheckCart
	Given the https://www.amazon.com/ site is opened	
	When I search for "iphone 12 pro max"
	And I add the first found item to cart
	And I navigate to cart
	Then Item is present in cart with correct name
	And The price of the item i cart is correct