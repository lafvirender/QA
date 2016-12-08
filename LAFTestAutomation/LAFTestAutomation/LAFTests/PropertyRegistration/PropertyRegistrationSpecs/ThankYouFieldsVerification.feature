Feature: ThankYouFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to view correct messages and field values on Thank You page after property registration.


@mytag
	Scenario: PropReg_ThankYouPage001_Verify that message "All set <FirstName>!" should be displayed on Thank You page
	Given I am on Prop_Listing Page
	And I navigate to Thank You page after registering property with details
		| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo | Street    | Suburb   | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgencyDetails | ContactedAgency | ContactedAgenciesDetails | Urgency     | FirstName | LastName | Email   | Phone      | customerDirectConnectAnswer | DirectConnectDetails |
		| Sell     | House    | One  | LessThanTwoHunderedK | Unit 1    | myStreet | Notlen St | Ringwood | VIC   | 3134     | MyHome |                | AbilityToGetBestOutcome | No             |                       | No              |                          | Immediately | First     | Last     | a@b.com | 0412213456 | No                          |                      |
	
	Then Message "All set First!" should be displayed on Thank You page with correct First Name.

	Scenario: PropReg_ThankYouPage002_Verify that message "Your details are being reviewed now." should be displayed on Thank You page
	Given I am on Prop_Listing Page
	And I navigate to Thank You page after registering property with details
		| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo | Street    | Suburb   | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgencyDetails | ContactedAgency | ContactedAgenciesDetails | Urgency     | FirstName | LastName | Email   | Phone      | customerDirectConnectAnswer | DirectConnectDetails |
		| Sell     | House    | One  | LessThanTwoHunderedK | Unit 1    | myStreet | Notlen St | Ringwood | VIC   | 3134     | MyHome |                | AbilityToGetBestOutcome | No             |                       | No              |                          | Immediately | First     | Last     | a@b.com | 0412213456 | No                          |                      |
	
	Then Message for customer details to be reviewed "Your details are being reviewed now." should be displayed on Thank You page

	Scenario: PropReg_ThankYouPage003_Verify that message "This usually takes just a few minutes. We'll send you an email when your results are ready." should be displayed on Thank You page
	Given I am on Prop_Listing Page
	And I navigate to Thank You page after registering property with details
		| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo | Street    | Suburb   | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgencyDetails | ContactedAgency | ContactedAgenciesDetails | Urgency     | FirstName | LastName | Email   | Phone      | customerDirectConnectAnswer | DirectConnectDetails |
		| Sell     | House    | One  | LessThanTwoHunderedK | Unit 1    | myStreet | Notlen St | Ringwood | VIC   | 3134     | MyHome |                | AbilityToGetBestOutcome | No             |                       | No              |                          | Immediately | First     | Last     | a@b.com | 0412213456 | No                          |                      |
	
	Then Message for sending results to customer email "This usually takes just a few minutes. We'll send you an email when your results are ready." should be displayed on Thank You page

Scenario: PropReg_ThankYouPage004_Verify Email Message on thank You Page.
	Given I am on Prop_Listing Page
	And I navigate to Thank You page after registering property with details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo | Street    | Suburb   | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgencyDetails | ContactedAgency | ContactedAgenciesDetails | Urgency     | FirstName | LastName | Email           | Phone      | customerDirectConnectAnswer | DirectConnectDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 1    | myStreet | Notlen St | Ringwood | VIC   | 3134     | MyHome |                | AbilityToGetBestOutcome | No             |                       | No              |                          | Immediately | First     | Last     | a@testpqrst.com | 0412213456 | No                          |                      |
	Then Message for customer to expect email "EXPECT ANEMAIL SENT TOa@testpqrst.com" should be displayed


Scenario: PropReg_ThankYouPage005_Verify Estimate Time Message on thank You Page.
	Given I am on Prop_Listing Page
	And I navigate to Thank You page after registering property with details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo | Street    | Suburb   | State | PostCode | Leased | LeasingDetails | AgentQuality            | SpecificAgency | SpecificAgencyDetails | ContactedAgency | ContactedAgenciesDetails | Urgency     | FirstName | LastName | Email           | Phone      | customerDirectConnectAnswer | DirectConnectDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 1    | myStreet | Notlen St | Ringwood | VIC   | 3134     | MyHome |                | AbilityToGetBestOutcome | No             |                       | No              |                          | Immediately | First     | Last     | a@testpqrst.com | 0412213456 | No                          |                      |                   
	Then Message for time estimate "AVERAGETIME:14 MINUTES" should be displayed
