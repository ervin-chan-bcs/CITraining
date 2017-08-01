Feature: MultiplyTwoNumbers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the product of two numbers

@mytag
Scenario: Multiply two numbers
	Given I have entered 2 into the calculator
	And I have entered 2 into the calculator
	When I press multiply
	Then the result should be 4 on the screen
