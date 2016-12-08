Feature: AgencyDetailsFieldsVerification
	In order to submit the proposal
	As an Agent
	I want to be able to register after selecting valid values in Agency Details
	

@mytag
	Scenario: AgentSignUp_AgencyDetails001_Verify that link for Moving Forward should be disabled by default
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	Then Link for Moving Forward is Disabled

	Scenario: AgentSignUp_AgencyDetails002_Verify that Heading "About Your agency" should be displayed for About your Agency section
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	Then Question "About your agency" should be displayed for About your Agency section


	Scenario: AgentSignUp_AgencyDetails003_Verify that Progress circle for Agency is displayed as not filled by default
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	Then Progress circle for Agency is displayed as not filled by default

	Scenario: AgentSignUp_AgencyDetails004_Verify that option for entering the address manually should be available.
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	Then Option for entering the address manually with text "Enter address manually" is displayed

	Scenario: AgentSignUp_AgencyDetails005_Verify that field for searching address should be available
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	Then Search field is available for searching the address

	Scenario: AgentSignUp_AgencyDetails006_Verify that Next button is available 
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	Then Next button is available on Agency Details section

	Scenario: AgentSignUp_AgencyDetails007_Verify that on selecting the option for entering the address manually, UnitNo, StreetNo, Street, Suburb, State, and PostCode field should be displayed
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I select option Enter your address manually
	Then Fields Unit/App No., StreetNo., Street, Suburb, State and PostCode are displayed

	Scenario: AgentSignUp_AgencyDetails008_Verify that error is displayed for empty Address Search field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Click on Next button
	Then Error should be displayed for empty Address Search field

	Scenario: AgentSignUp_AgencyDetails009_Verify that error is displayed for empty Street No field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           |                | Street       | Suburb       | VIC         | 3081           | testAgency       | St Kilda     |
	Then Error should be displayed for empty  Street No field

	Scenario: AgentSignUp_AgencyDetails010_Verify that error is displayed for empty Street field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     |              | Suburb       | VIC         | 3081           | testAgency       | St Kilda     |
	Then Error "Street name for your business" should be displayed for empty  Street field

	Scenario: AgentSignUp_AgencyDetails011_Verify that error is displayed for empty Suburb field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   |              | VIC         | 3081           | testAgency       | St Kilda     |
	Then Error "Suburb for your business" should be displayed for empty  Suburb field

	Scenario: AgentSignUp_AgencyDetails012_Verify that error is displayed for empty State field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   | testSuburb   |             | 3081           | testAgency       | St Kilda     |
	Then Error should be displayed for empty  State field
	
	Scenario: AgentSignUp_AgencyDetails013_Verify that error is displayed for empty Postcode field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   | testSuburb   | VIC         |                | testAgency       | St Kilda     |
	Then Error "Postcode for your business" should be displayed for empty  Postcode field

	Scenario: AgentSignUp_AgencyDetails014_Verify that error is displayed for empty Agency Name field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           |                  | St Kilda     |
	Then Error "Your agency name" should be displayed for empty  Agency Name field

	Scenario: AgentSignUp_AgencyDetails015_Verify that error is displayed for empty Branch field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency       |              |
	Then Error "Your branch name" should be displayed for empty  Branch field

	Scenario: AgentSignUp_AgencyDetails016_Verify that Principal Details section is displayed after entering details in Agency Details section
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	Then Principal Details section is displayed

	Scenario: AgentSignUp_AgencyDetails017_Verify that Progress circle for Agency is displayed as filled on navigating to next section after entering Agency Details
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	Then Progress circle for Agency is displayed as filled

	Scenario: AgentSignUp_AgencyDetails018_Verify that error is displayed on entering more than 50 characters in Street No field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo                                      | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | thisisaveryveryverylooooooooooooooooooooooongstring | Street       | Suburb       | VIC         | 3081           | testAgency | St Kilda     |
	Then Error "Error Text" should be displayed for Street No field

	Scenario: AgentSignUp_AgencyDetails019_Verify that Principal Details section is displayed after entering 50 characters in Street No field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo                                     | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | thisisaveryveryveryloooooooooooooooooooooongstring | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	Then Principal Details section is displayed

	Scenario: AgentSignUp_AgencyDetails020_Verify that error is displayed on entering more than 60 characters in State field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState                                                   | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   | testSuburb   | thisisaveryveryverylooooooooooooooooooooooooooooooooongstring | 3081           | testAgency | St Kilda     |
	Then Error "Error Text" should be displayed for State field

	Scenario: AgentSignUp_AgencyDetails021_Verify that Principal Details section is displayed after entering 60 characters in State field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState                                                  | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   | testSuburb   | thisisaveryveryveryloooooooooooooooooooooooooooooooongstring | 3081           | testAgency | branch       |
	Then Principal Details section is displayed

	Scenario: AgentSignUp_AgencyDetails022_Verify that error is displayed on entering more than 50 characters in Suburb field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb                                                  | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | testStreet     | streetname   | thisisaveryveryveryloooooooooooooooooooooongstringo | VIC         | 3081           | testAgency | St Kilda     |
	Then Error "Error Text" should be displayed for Suburb field

	Scenario: AgentSignUp_AgencyDetails023_Verify that Principal Details section is displayed after entering 50 characters in Suburb field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo                                               | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
		| Unit1           | thisisaveryveryveryloooooooooooooooooooooongstring | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	Then Principal Details section is displayed

	
	Scenario: AgentSignUp_AgencyDetails024_Verify that error is displayed on entering more than 200 characters in Agency Name field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb     | AgencyState | AgencyPostCode | AgencyName                                                                                                                                                                                                | AgencyBranch |
		| Unit1           | testStreet     | streetname   | Hoppers Crossing | VIC         | 3081           | This string consists of more than 200 characters. The purpose of the string is to test the fields for any errors. This string consists of more than 200 characters. The purpose of the string is to test. | St Kilda     |
	Then Error "Error Text" should be displayed for Agency Name field

	Scenario: AgentSignUp_AgencyDetails025_Verify that Principal Details section is displayed after entering 200 characters in Agency Name field
	Given User is on Agent Registration Page
	And User navigates to About Your Agency section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant |
	When I Enter values in Agency Details as
		| AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb     | AgencyState | AgencyPostCode | AgencyName                                                                                                                                                                                                | AgencyBranch |
		| Unit1           | testStreet     | streetname   | Hoppers Crossing | VIC         | 3081           | This string consists of more than 200 characters. The purpose of the string is to test the fields for any errors. This string consists of more than 200 characters. The purpose of the string is to test | St Kilda     |
	Then Principal Details section is displayed