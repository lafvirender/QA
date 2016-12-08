Feature: ContactedAgenciesFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting valid values in Contacted Agencies details.

@mytag
	Scenario: PropReg_ContactedAgencies001_Verify the Question for Contacted Agencies
	Given I am on PropertyListing Page
	And I navigate to Contacted Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         |
	Then Q "Have you started speaking to any agents or agencies about your property?" should be displayed for Contacted Agencies

	Scenario: PropReg_ContactedAgencies002_Verify that link for Moving Forward should be disabled by default
	Given I am on PropertyListing Page
	And I navigate to Contacted Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality                | SpecificAgency | SpecificAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | LocalKnowledegeAndExpertise | No             |                         |
	Then Moving Forward Link is not enabled

	Scenario: PropReg_ContactedAgencies003_Verify that Progress section should display filling of Specific Agencies Details
	Given I am on PropertyListing Page
	And I navigate to Contacted Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality                | SpecificAgency | SpecificAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | LocalKnowledegeAndExpertise | No             |                         |
	Then Progress section displays filling of Specific Agencies Details

	Scenario: PropReg_ContactedAgencies004_Verify that option "YES" should be available for Contacted Agencies.
	Given I am on PropertyListing Page
	And I navigate to Contacted Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality                  | SpecificAgency | SpecificAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | TrustworthinessAndReliability | No             |                         |
	Then Option Yes  with text "YES" is displayed

	Scenario: PropReg_ContactedAgencies005_Verify that option "NO" should be available for Contacted Agencies.
	Given I am on PropertyListing Page
	And I navigate to Contacted Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality             | SpecificAgency | SpecificAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | PatienceAndUnderstanding | No             |                         |
	Then Option No  with text "NO" is displayed

	Scenario: PropReg_ContactedAgencies006_Verify that Urgency section should be displayed when user selects "NO" for Contacted Agencies
	Given I am on PropertyListing Page
	And I navigate to Contacted Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality             | SpecificAgency | SpecificAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | PatienceAndUnderstanding | No             |                         |
	When I Select option as "No" for Contacted Agencies
	Then  Urgency section should be displayed

	Scenario: PropReg_ContactedAgencies007_Verify that field for entering Contacted Agencies Details should be available when option Yes is selected
	Given I am on PropertyListing Page
	And I navigate to Contacted Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality             | SpecificAgency | SpecificAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | PatienceAndUnderstanding | No             |                         |
	When I Click Option YES for Contacted Agencies Details
	Then Field for entering Contacted Agencies Details should be available

	Scenario: PropReg_ContactedAgencies008_Verify that error is displayed for empty Contacted Agencies Details field
	Given I am on PropertyListing Page
	And I navigate to Contacted Agencies section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality             | SpecificAgency | SpecificAgenciesDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | PatienceAndUnderstanding | No             |                         |
	When I Click Option YES for Contacted Agencies Details
	And I Click Next without entering Contacted Agencies Details
	Then Error is displayed for empty Contacted Agencies Details field
