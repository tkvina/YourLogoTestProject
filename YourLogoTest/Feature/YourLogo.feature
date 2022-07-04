Feature: YourLogo
	Simple calculator for adding two numbers

@mytag
Scenario: Adding Printed Summer Dress to Basket
	Given I Navigate to Website "http://automationpractice.com/index.php "
	And I Click on Search
	And I Enter Search for "Printed Summer Dress"
	And I Click on Search Button
	And I Click on Printed Summer Dress $28.98
	And I click on Blue Colour 
	And I Click on Dropdown arrow
	And I Select Medium Size
	And I Click on plus sign to Add Two Quantity to Basket
	When I Click on Add to Cart
	Then I should be able to add to cart successfully
	When I Click On Proceed to Checkout 
	Then I Validate the total value in the basket 
	When I Click on plus sign Button to Add  One more dress to the Basket
	Then I Confirmed the Price in the Basket have Been Updated
	And I Click on Proceed to Checkout Button