Feature: PropertyTypeFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting valid Property Type.

@mytag
Scenario: PropReg_PropType001_Verify the Question for Property type options on Registration Page for Sell Listing.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Q "What type of property are you selling?" should be displayed for Property Type options

Scenario: PropReg_PropType002_Verify that Property Type "HOUSE" should be available on Registration Page.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Property Type House with Text "HOUSE" should be available

Scenario: PropReg_PropType003_Verify that Property Type "UNIT" should be available on Registration Page.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Property Type Unit with Text "UNIT" should be available

Scenario: PropReg_PropType004_Verify that Property Type "LAND" should be available on Registration Page.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Property Type Land with Text "LAND" should be available

Scenario: PropReg_PropType005_Verify that Property Type "APARTMENT" should be available on Registration Page.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Property Type Apartment with Text "APARTMENT" should be available

Scenario: PropReg_PropType006_Verify that Property Type "TOWNHOUSE" should be available on Registration Page.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Property Type Townhouse with Text "TOWNHOUSE" should be available

Scenario: PropReg_PropType007_Verify that Property Type "VILLA" should be available on Registration Page.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Property Type Villa with Text "VILLA" should be available

Scenario: PropReg_PropType008_Verify that Property Circle in the Progress section should be displayed as Filled.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Property Circle in the Progress is displayed as Filled

Scenario: PropReg_PropType009_Verify that link for Moving Forward should be disabled by default
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Moving Forward Link is disabled

Scenario: PropReg_PropType010_Verify that Bedroom selection question should be displayed when user selects "House" Property Type.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "House"
	Then Bedroom selection question should be displayed

Scenario: PropReg_PropType011_Verify that Bedroom selection question should be displayed when user selects "Unit" Property Type.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Unit"
	Then Bedroom selection question should be displayed

Scenario: PropReg_PropType012_Verify that Bedroom selection question should be displayed when user selects "Apartment" Property Type.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Apartment"
	Then Bedroom selection question should be displayed

Scenario: PropReg_PropType013_Verify that Bedroom selection question should be displayed when user selects "Townhouse" Property Type.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Townhouse"
	Then Bedroom selection question should be displayed

Scenario: PropReg_PropType014_Verify that Bedroom selection question should be displayed when user selects "Villa" Property Type.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Villa"
	Then Bedroom selection question should be displayed

Scenario: PropReg_PropType015_Verify that Approximate Value Selection question should be displayed when user selects "Land" Property Type.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Land"
	Then Approximate Value Selection question should be displayed

Scenario: PropReg_PropType016_Verify the color of option House when it is not selected
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Color of the House option should be "#00AEFF"

Scenario: PropReg_PropType017_Verify that color of the option House changes on selection.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "House"
	And I move back to Property Type Selection from Bedrooms Selection
	Then Color of the House option should be "#16B24D"

Scenario: PropReg_PropType018_Verify that Progress line indicates selection of Property Type.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "House"
	And I move back to Property Type Selection from Bedrooms Selection
	Then Progress line shows the selection of Property Type

Scenario: PropReg_PropType019_Verify the color of option Unit when it is not selected
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Color of the Unit option should be "#00AEFF"

Scenario: PropReg_PropType020_Verify that color of the option Unit changes on selection.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Unit"
	And I move back to Property Type Selection from Bedrooms Selection
	Then Color of the Unit option should be "#16B24D"

Scenario: PropReg_PropType021_Verify the color of option Land when it is not selected
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Color of the Land option should be "#00AEFF"

Scenario: PropReg_PropType022_Verify that color of the option Land changes on selection.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Land"
	And I move back to Property Type Selection from Property Value Selection
	Then Color of the Land option should be "#16B24D"

Scenario: PropReg_PropType023_Verify the color of option Apartment when it is not selected
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Color of the Apartment option should be "#00AEFF"

Scenario: PropReg_PropType024_Verify that color of the option Apartment changes on selection.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Apartment"
	And I move back to Property Type Selection from Bedrooms Selection
	Then Color of the Apartment option should be "#16B24D"

Scenario: PropReg_PropType025_Verify the color of option Townhouse when it is not selected
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Color of the Townhouse option should be "#00AEFF"

Scenario: PropReg_PropType026_Verify that color of the option Townhouse changes on selection.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Townhouse"
	And I move back to Property Type Selection from Bedrooms Selection
	Then Color of the Townhouse option should be "#16B24D"

Scenario: PropReg_PropType027_Verify the color of option Villa when it is not selected
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	Then Color of the Villa option should be "#00AEFF"

Scenario: PropReg_PropType028_Verify that color of the option Villa changes on selection.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Villa"
	And I move back to Property Type Selection from Bedrooms Selection
	Then Color of the Villa option should be "#16B24D"

Scenario: PropReg_PropType029_Verify that link for Moving forward is displayed as enabled when user moves back to Property type selection from Bedrooms selection.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "House"
	And I move back to Property Type Selection from Bedrooms Selection
	Then Link for Moving forward is displayed as enabled

Scenario: PropReg_PropType030_Verify that Bedroom selection question is displayed on clicking Forward link on Property Type.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "House"
	And I move back to Property Type Selection from Bedrooms Selection
	And I click on Forward Link
	Then  Bedroom selection question should be displayed

Scenario: PropReg_PropType031_Verify that Property Value selection question is displayed on clicking Forward link on Property Type when Property Type selected was Land
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Sell     |
	When I Select Property Type as "Land"
	And I move back to Property Type Selection from Property Value Selection
	And I click on Forward Link
	Then  Approximate Value Selection question should be displayed

	Scenario: PropReg_PropType032_Verify the Question for Property type options on Registration Page for Rent Listing.
	Given I am on Property Registration Page
	And I navigate to Property Type Selection after selection option
		| Category |
		| Rent     |
	Then Q "What type of property are you renting?" should be displayed for Property Type options