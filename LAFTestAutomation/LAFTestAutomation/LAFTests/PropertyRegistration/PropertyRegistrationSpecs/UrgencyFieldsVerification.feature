Feature: UrgencyFieldsVerification
		In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting valid option for Agent Quality

@mytag
	Scenario: PropReg_Urgency001_Verify the Question for Urgency
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Q "When are you looking to Sell your Property?" should be displayed for Urgency selection 

	Scenario: PropReg_Urgency002_Verify that option "Immediately" should be available
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Option Immediately with text "IMMEDIATELY" should be available

	Scenario: PropReg_Urgency003_Verify that option "0To3Months" should be available
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Option ZeroToThreeMonths with text "0-3 MONTHS" should be available

	Scenario: PropReg_Urgency004_Verify that option "3To6Months" should be available
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Option ThreeToSixMonths with text "3-6 MONTHS" should be available

	Scenario: PropReg_Urgency005_Verify that option "6+Months" should be available
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Option SixPlusMonths with text "6+ MONTHS" should be available

	Scenario: PropReg_Urgency006_Verify that link for Moving Forward should be disabled by default
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Moving Fwd Link is displayed disabled

	Scenario: PropReg_Urgency007_Verify that Customer Details question should be displayed when user selects "Immediately" option
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "Immediately"
	Then Customer Details Entry question is displayed
	
	Scenario: PropReg_Urgency008_Verify that Customer Details question should be displayed when user selects "0To3Months" option
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "ZeroToThreeMonths"
	Then Customer Details Entry question is displayed

	Scenario: PropReg_Urgency009_Verify that Customer Details question should be displayed when user selects "3To6Months" option
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "ThreeToSixMonths"
	Then Customer Details Entry question is displayed

	Scenario: PropReg_Urgency010_Verify that Customer Details question should be displayed when user selects "SixPlusMonths" option
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "SixPlusMonths"
	Then Customer Details Entry question is displayed

	Scenario: PropReg_Urgency011_Verify the color of option "Immediately" when it is not selected
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Color of the Immediately option should be "#00AEFF"

	Scenario: PropReg_Urgency012_Verify that color of the option "Immediately" changes on selection.
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "Immediately"
	And I move back to Urgency  Question
	Then Color of the Immediately option should be "#14B24B"

	Scenario: PropReg_Urgency013_Verify the color of option "0To3Months" when it is not selected
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Color of the ZeroToThreeMonths option should be "#00AEFF"

	Scenario: PropReg_Urgency014_Verify that color of the option "0To3Months" changes on selection.
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "ZeroToThreeMonths"
	And I move back to Urgency  Question
	Then Color of the ZeroToThreeMonths option should be "#14B24B"

	Scenario: PropReg_Urgency015_Verify the color of option "3To6Months" when it is not selected
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Color of the ThreeToSixMonths option should be "#00AEFF"

	Scenario: PropReg_Urgency016_Verify that color of the option "3To6Months" changes on selection.
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "ThreeToSixMonths"
	And I move back to Urgency  Question
	Then Color of the ThreeToSixMonths option should be "#14B24B"

	Scenario: PropReg_Urgency017_Verify the color of option "6+Months" when it is not selected
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	Then Color of the SixPlusMonths option should be "#00AEFF"

	Scenario: PropReg_Urgency018_Verify that color of the option "6+Months" changes on selection.
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "SixPlusMonths"
	And I move back to Urgency  Question
	Then Color of the SixPlusMonths option should be "#14B24B"

	Scenario: PropReg_Urgency019_Verify that link for Moving forward is displayed as enabled when user moves back to Urgency selection from Customer Details
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "SixPlusMonths"
	And I move back to Urgency  Question
	Then Link for Moving fwd is enabled

	Scenario: PropReg_Urgency020_Verify that Specific Agencies question is displayed on clicking Forward link
	Given I am on Prop_Rego_Page
	And I navigate to Urgency selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          |
	When I Select Urgency option as "SixPlusMonths"
	And I move back to Urgency  Question
	And I click on Fwd 
	Then Customer Details Entry question is displayed