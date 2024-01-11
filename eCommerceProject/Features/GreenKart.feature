Feature: GreenKart

As a user on GreenKart
I should be able to buy Cucumber

@tag1
Scenario: Verify I am able to buy cucumber
	Given I navigate the GreenKart Url "https://rahulshettyacademy.com/seleniumPractise/#/"
	When I click on search bar
	And I enter vegetable "cucumber"
	And I add to cart
	And I click on cart
	And I proceed to checkout
	Then I am able to place order
