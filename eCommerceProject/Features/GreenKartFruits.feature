Feature: GreenKartFruits

As user on GreenKart webiste
I want to be able to buy 10 different items of my choice

@tag1
Scenario: Verify I am able to buy different fruit items
	Given that I navigate GreenKart url "https://rahulshettyacademy.com/seleniumPractise/#/"
	And I add all friuts to cart
	When I click on the basket to view all added items
	And I click on proceed to checkout
	And I place order for all items
	And I select country "Australia"
	And I click the check box to agree terms and conditions
	And I click proceed button
	Then I am able to buy different fruits items successfully.

	