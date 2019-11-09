Feature: SpecflowWithExcel
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers
	Given I have entered <num1> into the calculator
	And I have entered <num2> into the calculator
	When I press add
	Then the result should be <result> on the screen


	@source: SpecFlowInputDataExcelSheet.xlsx
Examples: 
	| num1 | num2 | result |
	| 1    | 2    | 3      |



