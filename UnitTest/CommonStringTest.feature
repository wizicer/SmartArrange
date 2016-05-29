Feature: CommonStringTest
	In order to avoid silly mistakes
	As a user
	I want to be told the result of common string.

Scenario Outline: basic common string
	Given I have following strings: <strings>
	When I start to find common string
	Then the result should be `<result>`

	Examples: 
	| strings                                                             | result |
	| sp1^sp-23412.231.txt^sp-23412.231(1).txt^sp-23412.231(1)(1).cmd^sp2 | sp     |