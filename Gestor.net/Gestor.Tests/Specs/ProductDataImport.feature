Feature: Product data import
	In order to administrate my products
	As a Gestor User
	I want to import all the products from an excel file

Scenario: The user imports the excel content on screen
	Given I have the excel file "example.xls"
	When I import the file
	Then the file content appears on screen
