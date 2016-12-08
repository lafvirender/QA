Feature: BedroomsFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting valid number of Bedrooms.

@mytag
	Scenario: PropReg_Bedrooms001_Verify the Question for Bedrooms options on Registration Page.
	Given I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Q "How many bedrooms does the house you're selling have?" should be displayed for Bedrooms selection options

	Scenario: PropReg_Bedrooms002_Verify that Progress line indicates selection of Property Type.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Progress line indicates selection of Property Type

	Scenario: PropReg_Bedrooms003_Verify that option "1" should be available for Bedrooms.
	Given I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Option for selection of one Bedrooms with text "1" should be displayed

	Scenario: PropReg_Bedrooms004_Verify that option "2" should be available for Bedrooms.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Option for selection of two Bedrooms with text "2" should be displayed

    Scenario: PropReg_Bedrooms005_Verify that option "3" should be available for Bedrooms.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Option for selection of three Bedrooms with text "3" should be displayed

    Scenario: PropReg_Bedrooms006_Verify that option "4+" should be available for Bedrooms.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Option for selection of four plus Bedrooms with text 4+ should be displayed

	Scenario: PropReg_Bedrooms007_Verify that link for Moving Forward should be disabled by default
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Icon Link for Moving forward is displayed as Disabled

	Scenario: PropReg_Bedrooms008_Verify that Property Value selection question should be displayed when user selects "1" Bedroom.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "One"
	Then Question for selecting Approximate Value should be displayed

	Scenario: PropReg_Bedrooms009_Verify that Progress line indicates selection of Bedrooms.
	Given I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "One"
	And I move back to Bedrooms Selection from Property Value Selection
	Then Progress line indicates selection of Bedrooms

	Scenario: PropReg_Bedrooms010_Verify that Property Value selection question should be displayed when user selects "2" Bedroom.
	Given I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "Two"
	Then  Question for selecting Approximate Value should be displayed

	Scenario: PropReg_Bedrooms011_Verify that Property Value selection question should be displayed when user selects "3" Bedroom.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "Three"
	Then Question for selecting Approximate Value should be displayed

	Scenario: PropReg_Bedrooms012_Verify that Property Value selection question should be displayed when user selects "4+" Bedroom.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "Four"
	Then Question for selecting Approximate Value should be displayed

	Scenario: PropReg_Bedrooms013_Verify the color of option for one bedroom when it is not selected
	Given I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Color of the one bedroom option should be "#00AEFF"

	
	Scenario: PropReg_Bedrooms014_Verify that color of the option for One Bedroom changes on selection.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "One"
	And I move back to Bedrooms Selection from Property Value Selection
	Then Color of the one bedroom option should be "#16B24D"

	Scenario: PropReg_Bedrooms015_Verify the color of option for two bedroom when it is not selected
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Color of the two bedroom option should be "#00AEFF"

	
	Scenario: PropReg_Bedrooms016_Verify that color of the option for Two Bedroom changes on selection.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "Two"
	And I move back to Bedrooms Selection from Property Value Selection
	Then Color of the two bedroom option should be "#16B24D"


	Scenario: PropReg_Bedrooms017_Verify the color of option for three bedroom when it is not selected
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Color of the three bedroom option should be "#00AEFF"

	
	Scenario: PropReg_Bedrooms018_Verify that color of the option for Three Bedroom changes on selection.
	Given I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "Three"
	And I move back to Bedrooms Selection from Property Value Selection
	Then Color of the three bedroom option should be "#16B24D"

	Scenario: PropReg_Bedrooms019_Verify the color of option for four plus bedroom when it is not selected
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	Then Color of the four plus bedroom option should be "#00AEFF"

	
	Scenario: PropReg_Bedrooms020_Verify that color of the option for Four Plus Bedroom changes on selection.
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "Four"
	And I move back to Bedrooms Selection from Property Value Selection
	Then Color of the four plus bedroom option should be "#16B24D"

	Scenario: PropReg_Bedrooms021_Verify that link for Moving forward is displayed as enabled when user moves back to Bedrooms selection from Property Value Selection
	Given  I am on Property Reg Page
	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "Three"
	And I move back to Bedrooms Selection from Property Value Selection
	Then Icon Link for Moving forward is displayed as enabled

	Scenario: PropReg_Bedrooms022_Verify that Property Value selection question is displayed on clicking Forward link on Bedrooms selection
	Given  I am on Property Reg Page
 	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | House    |
	When I Select Bedroom as "Three"
	And I move back to Bedrooms Selection from Property Value Selection
	And Click to Move Forward
	Then  Question for selecting Approximate Value should be displayed

	Scenario: PropReg_Bedrooms023_Verify the Question for Bedroom selection for a Unit Property Type with Listing Category as Sell.
	Given  I am on Property Reg Page
 	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Sell     | Unit    |
	Then Q "How many bedrooms does the unit you're selling have?" should be displayed for Bedrooms selection options

	Scenario: PropReg_Bedrooms024_Verify the Question for Bedroom selection for a Apartment Property Type with Listing Category as Sell.
	Given  I am on Property Reg Page
 	And I navigate to Bedroom selection after entering details
	| Category | PropType  |
	| Sell     | Apartment |
	Then Q "How many bedrooms does the apartment you're selling have?" should be displayed for Bedrooms selection options

	Scenario: PropReg_Bedrooms025_Verify the Question for Bedroom selection for a Townhouse Property Type with Listing Category as Sell.
	Given  I am on Property Reg Page
 	And I navigate to Bedroom selection after entering details
	| Category | PropType  |
	| Sell     | Townhouse |
	Then Q "How many bedrooms does the townhouse you're selling have?" should be displayed for Bedrooms selection options

	Scenario: PropReg_Bedrooms026_Verify the Question for Bedroom selection for a Villa Property Type with Listing Category as Sell.
	Given  I am on Property Reg Page
 	And I navigate to Bedroom selection after entering details
	| Category | PropType  |
	| Sell     | Villa |
	Then Q "How many bedrooms does the villa you're selling have?" should be displayed for Bedrooms selection options

	Scenario: PropReg_Bedrooms027_Verify the Question for Bedroom selection for a Villa Property Type with Listing Category as Rent.
	Given  I am on Property Reg Page
 	And I navigate to Bedroom selection after entering details
	| Category | PropType |
	| Rent     | Villa    |
	Then Q "How many bedrooms does the villa you're renting have?" should be displayed for Bedrooms selection options