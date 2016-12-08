Feature: PropertyListingFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting/entering valid data in different fields and proper error messages should be displayed on entering invalid data.

@mytag
Scenario: PropReg_PropListing001_Verify the Question for Property Listing options on Registration Page.
	Given User is on Property Registration Page
	Then Question "Are you looking to sell or rent your property?" should be displayed for Property Listing options

Scenario: PropReg_PropListing002_Verify that Property Listing category "Rent" should be available on Registration Page.
	Given User is on Property Registration Page
	Then Listing category Rent with Text "RENT" should be available

Scenario: PropReg_PropListing003_Verify that links for Moving Back and Forward should be disabled by default
	Given User is on Property Registration Page
	Then Links for Moving Back and Forward should be disabled

Scenario: PropReg_PropListing004_Verify that under Progress section, Property should be displayed as activated by default.
	Given User is on Property Registration Page
	Then Property Details Progress should be displayed as activated

Scenario: PropReg_PropListing005_Verify that under Progress section, Property Circle should not be displayed as Filled by default.
	Given User is on Property Registration Page
	Then Property Details Progress Circle should be displayed as not filled

Scenario: PropReg_PropListing006_Verify that under Progress section, Label "Property" should be displayed for Property Details progress.
	Given User is on Property Registration Page
	Then Label "PROPERTY" should be displayed for Property Details progress.

Scenario: PropReg_PropListing007_Verify that under Progress section, no progress should be displayed for Agent details by default.
	Given User is on Property Registration Page
	Then No progress should be displayed for Agent details by default.

Scenario: PropReg_PropListing008_Verify that under Progress section, Label "AGENT" should be displayed for Agent Details progress.
	Given User is on Property Registration Page
	Then Label "AGENT" should be displayed for Agent Details progress.

Scenario: PropReg_PropListing009_Verify that under Progress section, no progress should be displayed for Your Details by default.
	Given User is on Property Registration Page
	Then No progress should be displayed for Your details by default

Scenario: PropReg_PropListing010_Verify that under Progress section, Label "YOU" should be displayed for Your Details progress.
	Given User is on Property Registration Page
	Then Label "You" should be displayed for Your Details progress.

Scenario: PropReg_PropListing011_Verify that Property Type selection question should be displayed when user selects "Sell" Category.
	Given User is on Property Registration Page
	When I Select Sell category
	Then Property Type selection question should be displayed.

Scenario: PropReg_PropListing012_Verify that Property Type selection question should be displayed when user selects "Rent" Category.
	Given User is on Property Registration Page
	When I Select Rent category
	Then Property Type selection question should be displayed.

Scenario: PropReg_PropListing013_Verify that link for Moving forward is displayed as enabled when user moves back to Property Listing from Property Type selection.
	Given User is on Property Registration Page
	When I Select Rent category
	And I move back to Property Listing question
	Then Link for navigating forward is enabled

Scenario: PropReg_PropListing014_Verify that Property Type selection question is displayed on clicking Forward link on Property Listing..
	Given User is on Property Registration Page
	And I Select Rent category
	And I move back to Property Listing question
	When Click on Forward
	Then  Property Type selection question should be displayed.

Scenario: PropReg_PropListing015_Verify that Correct Approximate Value options should be displayed on Registration Page for Rent.
	Given User is on Property Registration Page
	And I navigate to Approximate Value selection question for Renting property
	Then Below options should be available under Approximate Values
		| ApproximateValues |
		| LESS THAN $200    |
		| $200 TO $300      |
		| $300 TO $400      |
		| $400 TO $500      |
		| $500 TO $700      |
		| $700 TO $1000     |
		| $1000 TO $1500    |
		| $1500+            |

Scenario: PropReg_PropListing016_Verify that Correct Approximate Value options should be displayed on Registration Page for Sell.
	Given User is on Property Registration Page
	And I navigate to Approximate Value selection question for Selling property
	Then Below options should be available under Approximate Values.
		| ApproximateValues |
		| LESS THAN $200K   |
		| $200K TO $400K    |
		| $400K TO $600K    |
		| $600K TO $800K    |
		| $800K TO $1M      |
		| $1M TO $1.5M      |
		| $1.5M TO $2M      |
		| $2M+              |

Scenario: PropReg_PropListing017_Verify the color of option Sell when it is not selected
	Given User is on Property Registration Page
	Then Color of the Sell option should be "#00AEFF"

Scenario: PropReg_PropListing018_Verify that color of the option Sell changes on selection.
	Given User is on Property Registration Page
	And I Select Sell category
	And I move back to Property Listing question
	Then Color of the Sell option should be "#16B24D"

Scenario: PropReg_PropListing019_Verify the color of option Rent when it is not selected
	Given User is on Property Registration Page
	Then Color of the Rent option should be "#00AEFF"

Scenario: PropReg_PropListing020_Verify that color of the option Rent changes on selection.
	Given User is on Property Registration Page
	And I Select Rent category
	And I move back to Property Listing question
	Then Color of the Rent option should be "#16B24D"

Scenario: PropReg_PropListing021_Verify that Listing category "Sell" should be available on Registration Page.
	Given User is on Property Registration Page
	Then Listing category Sell with Text "SELL" should be available
