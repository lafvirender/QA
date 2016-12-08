Feature: CustomerDetailsFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting valid values in Customer Details.

@mytag
	Scenario: PropReg_CustomerDetails001_Verify that link for Moving Forward should be disabled by default
	Given I am on Property_Listing Page
	And I navigate to Customer Details section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails | Urgency     |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          | Immediately |
	Then Forward Link is not enabled

	Scenario: PropReg_CustomerDetails002_Verify that Progress line indicates selection of Contacted Agencies.
	Given I am on Property_Listing Page
	And I navigate to Customer Details section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails | Urgency           |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | AbilityToGetBestOutcome | No             |                         | No              |                          | ZeroToThreeMonths |
	Then Selection of Contacted Agencies is displayed in Progress section

	Scenario: PropReg_CustomerDetails003_Verify that under Progress section, "You" in the progress section should be displayed as activated by default.
	Given I am on Property_Listing Page
	And I navigate to Customer Details section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality                | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails | Urgency          |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | LocalKnowledegeAndExpertise | No             |                         | No              |                          | ThreeToSixMonths |
	Then You is the progress section is displayed as activated

	Scenario: PropReg_CustomerDetails004_Verify that error is displayed for empty First Name field
	Given I am on Property_Listing Page
	And I navigate to Customer Details section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality             | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails | Urgency       |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | PatienceAndUnderstanding | No             |                         | No              |                          | SixPlusMonths |
	When Enter values in Customer Details Fields as
		| FirstName | LastName | Email   | Mobile  |
		|           | Last     | a@b.com | 0412213456 |
	Then Error is displayed for empty First Name field

	Scenario: PropReg_CustomerDetails005_Verify that error is displayed for empty Last Name field
	Given I am on Property_Listing Page
	And I navigate to Customer Details section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality                  | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails | Urgency          |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | TrustworthinessAndReliability | No             |                         | No              |                          | ThreeToSixMonths |
	When Enter values in Customer Details Fields as
		| FirstName | LastName | Email   | Mobile      |
		| First     |          | a@b.com | 0412213456 |
	Then Error is displayed for empty Last Name field

	Scenario: PropReg_CustomerDetails006_Verify that error is displayed for empty Email field
	Given I am on Property_Listing Page
	And I navigate to Customer Details section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality                  | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails | Urgency          |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | TrustworthinessAndReliability | No             |                         | No              |                          | ThreeToSixMonths |
	When Enter values in Customer Details Fields as
		| FirstName | LastName | Email | Mobile      |
		| First     | Last     |       | 0412213456 |
	Then Error is displayed for empty Email field

	Scenario: PropReg_CustomerDetails007_Verify that error is displayed for empty Mobile Number field
	Given I am on Property_Listing Page
	And I navigate to Customer Details section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails | AgentQuality                  | SpecificAgency | SpecificAgenciesDetails | ContactedAgency | ContactedAgenciesDetails | Urgency          |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                | TrustworthinessAndReliability | No             |                         | No              |                          | ThreeToSixMonths |
	When Enter values in Customer Details Fields as
		| FirstName | LastName | Email   | Mobile |
		| First     | Last     | a@b.com |       |
	Then Error is displayed for empty Mobile Number field

	Scenario: PropReg_CustomerDetails008_Verify that message "Are you serious about selling?" is displayed after submitting the customer details who is selling property.
	Given I am on Property_Listing Page
	And I navigate to Direct Connect section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo | Street    | Suburb   | State | PostCode | Leased | LeasingDetails | AgentQuality                  | SpecificAgency | SpecificAgencyDetails | ContactedAgency | ContactedAgenciesDetails | Urgency          | FirstName | LastName | Email   | Phone      |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 1    | myStreet | Notlen St | Ringwood | VIC   | 3134     | MyHome |                | TrustworthinessAndReliability | No             |                       | No              |                          | ThreeToSixMonths | First     | Last     | a@b.com | 0412213456 |
	Then Message "Are you serious about selling?" is displayed after submitting the customer details who is selling property

	Scenario: PropReg_CustomerDetails009_Verify that message "Are you serious about renting?" is displayed after submitting the customer details who is renting property.
	Given I am on Property_Listing Page
	And I navigate to Direct Connect section after entering details
	| Category | PropType | Beds | ApproxValue         | UnitAppNo | StreetNo | Street    | Suburb   | State | PostCode | Leased | LeasingDetails | AgentQuality                  | SpecificAgency | SpecificAgencyDetails | ContactedAgency | ContactedAgenciesDetails | Urgency          | FirstName | LastName | Email   | Phone      |
	| Rent     | House    | One  | LessThanTwoHundered | Unit 1    | myStreet | Notlen St | Ringwood | VIC   | 3134     | MyHome |                | TrustworthinessAndReliability | No             |                       | No              |                          | ThreeToSixMonths | First     | Last     | a@b.com | 0412213456 |
	Then Message "Are you serious about renting?" is displayed after submitting the customer details who is renting property

	Scenario: PropReg_CustomerDetails010_Verify that field for entering Direct Connect Details is not displayed on selecting No option.
	Given I am on Property_Listing Page
	And I navigate to Direct Connect section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo | Street    | Suburb   | State | PostCode | Leased | LeasingDetails | AgentQuality                  | SpecificAgency | SpecificAgencyDetails | ContactedAgency | ContactedAgenciesDetails | Urgency          | FirstName | LastName | Email   | Phone      |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 1    | myStreet | Notlen St | Ringwood | VIC   | 3134     | MyHome |                | TrustworthinessAndReliability | No             |                       | No              |                          | ThreeToSixMonths | First     | Last     | a@b.com | 0412213456 |
	And I select option No for Direct Connect
	Then Field for entering Direct Connect Details is not displayed

	Scenario: PropReg_CustomerDetails011_Verify that field for entering Direct Connect Details is displayed on selecting Yes option.
	Given I am on Property_Listing Page
	And I navigate to Direct Connect section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo | Street    | Suburb   | State | PostCode | Leased | LeasingDetails | AgentQuality                  | SpecificAgency | SpecificAgencyDetails | ContactedAgency | ContactedAgenciesDetails | Urgency          | FirstName | LastName | Email   | Phone      |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 1    | myStreet | Notlen St | Ringwood | VIC   | 3134     | MyHome |                | TrustworthinessAndReliability | No             |                       | No              |                          | ThreeToSixMonths | First     | Last     | a@b.com | 0412213456 |
	And I select option Yes for Direct Connect
	Then Field for entering Direct Connect Details is displayed