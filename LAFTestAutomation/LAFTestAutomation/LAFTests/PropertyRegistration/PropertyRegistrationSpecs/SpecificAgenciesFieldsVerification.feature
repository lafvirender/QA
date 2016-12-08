Feature: SpecificAgenciesFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting valid values in Specific Agencies details.

@mytag
	Scenario: PropReg_SpecificAgencies001_Verify the Question for Specific Agencies
	Given I am on Property_reg Page
	And I navigate to Specific Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome |
	Then Q "Are there any agencies you're considering that you'd like included in your comparison?" should be displayed for Specific Agencies

	Scenario: PropReg_SpecificAgencies002_Verify that link for Moving Forward should be disabled by default
	Given I am on Property_reg Page
	And I navigate to Specific Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome |
	Then Moving Forward should not be enabled

	Scenario: PropReg_SpecificAgencies003_Verify that Agent Circle in the Progress section should be displayed as Filled.
	Given I am on Property_reg Page
	And I navigate to Specific Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome |
	Then Agent Circle in the Progress is displayed as Filled

	Scenario: PropReg_SpecificAgencies004_Verify that option "YES" should be available for Specific Agencies.
	Given I am on Property_reg Page
	And I navigate to Specific Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome |
	Then Option Yes  with text "YES" should be displayed

	Scenario: PropReg_SpecificAgencies005_Verify that option "NO" should be available for Specific Agencies.
	Given I am on Property_reg Page
	And I navigate to Specific Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome |
	Then Option No  with text "NO" should be displayed

	Scenario: PropReg_SpecificAgencies006_Verify that Contacted Agencies question should be displayed when user selects "NO" for Specific Agencies
	Given I am on Property_reg Page
	And I navigate to Specific Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome |
	When I Select option as "No" for Specific Agencies
	Then  Contacted Agencies question should be displayed

	Scenario: PropReg_SpecificAgencies007_Verify that field for entering Specific Agencies Details should be available when option Yes is selected
	Given I am on Property_reg Page
	And I navigate to Specific Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | 
	When I Click Option YES for Specific Agencies Details
	Then Field for entering Specific Agencies Details should be available

	Scenario: PropReg_SpecificAgencies008_Verify that error is displayed for empty Specific Agencies Details field
	Given  I am on Property_reg Page
	And I navigate to Specific Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | 
	When I Click Option YES for Specific Agencies Details
	And I Click Next without entering Specific Agencies Details
	Then Error is displayed for empty Specific Agencies Details field