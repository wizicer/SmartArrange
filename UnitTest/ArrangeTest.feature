Feature: ArrangeTest
	In order to avoid silly mistakes
	As a user
	I want to be told the result of smart arrange.

Scenario: Standard example
	Given I have following files to be arranged
	| Filename                     |
	| E:\aa\sp1                    |
	| E:\aa\sp-23412.231.txt       |
	| E:\aa\sp-23412.231(1).txt    |
	| E:\aa\sp-23412.231(1)(1).cmd |
	| E:\aa\sp2                    |
	When I start smart arrange
	Then the result should be `E:\aa\sp`
