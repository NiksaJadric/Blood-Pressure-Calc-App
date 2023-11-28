Feature: Return Value of Blood Pressure

A short summary of the feature

@tag2
Scenario Outline: Blood Pressure
	Given Systolic Pressure is <systolic> and Diastolic pressure is <diastolic>
	When I click to calculate Blood Pressure
	Then response should be <bpcategory>
	Examples: 
	| systolic | diastolic | bpcategory					|
	| 80       | 50        | Low Blood Pressure			|
	| 110      | 70        | Ideal Blood Pressure		|
	| 130      | 85        | Pre-High Blood Pressure	|
	| 170      | 95        | High Blood Pressure		|