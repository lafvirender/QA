Feature: PrincipalDetailsFieldsVerification
	In order to submit the proposal
	As an Agent
	I want to be able to register after selecting valid values in Principal Details

	@mytag
	Scenario: AgentSignUp_PrincipalDetails001_Verify that link for Moving Forward should be disabled by default
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	Then Link for moving Forward is not enabled

	Scenario: AgentSignUp_PrincipalDetails002_Verify the Question for Principal Details on Agent SignUp.
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	Then Question "Are you the Principal?" should be displayed for Principal Details

	Scenario: AgentSignUp_PrincipalDetails003_Verify that Progress line for Principal Details is not filled by default.
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	Then Progress line for Principal Details is not filled by default

	Scenario: AgentSignUp_PrincipalDetails004_Verify that Yes button should be available on Principal Details
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	Then Yes button should be available on Principal Details

	Scenario: AgentSignUp_PrincipalDetails005_Verify that No button should be available on Principal Details
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	Then No button should be available on Principal Details

	Scenario: AgentSignUp_PrincipalDetails006_Verify that on selecting the option No on Principal Details, fields Principal First Name, Principal Last Nam and Principal Email Address should be displayed
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	When I select option No on Principal Details
	Then Fields Principal First Name, Principal Last Name, Principal Email Address should be displayed

	Scenario: AgentSignUp_PrincipalDetails007_Verify that error is displayed for empty Principal First Name field
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	When I Enter values in Principal Details as
		| PrincipalFirstName | PrincipalLastName | PrincipalEmail |
		|                    | PLast             | a@bcde.com     |
	Then Error "Your principal's name" should be displayed for empty Principal First Name field

	Scenario: AgentSignUp_PrincipalDetails008_Verify that error is displayed for empty Principal Last Name field
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	When I Enter values in Principal Details as
		| PrincipalFirstName | PrincipalLastName | PrincipalEmail |
		| PFirst             |                   | a@bcde.com     |
	Then Error "Your principal's last name" should be displayed for empty Principal Last Name field

	Scenario: AgentSignUp_PrincipalDetails009_Verify that error is displayed for empty Principal EMail Address field
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	When I Enter values in Principal Details as
		| PrincipalFirstName | PrincipalLastName | PrincipalEmail |
		| PFirst             | PLast             |                |
	Then Error "Your principal's email address" should be displayed for empty Principal Email Address field

	Scenario: AgentSignUp_PrincipalDetails010_Verify that on selecting the option Yes on Principal Details, Key Information section is displayed
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	When I select option Yes on Principal Details
	Then Key Information section is displayed

	Scenario: AgentSignUp_PrincipalDetails011_Verify that after enter Principal FirstName, LastName and Email address, Key Information section is displayed
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	When I Enter values in Principal Details as
		| PrincipalFirstName | PrincipalLastName | PrincipalEmail |
		| PFirst             | PLast             | a@bcde.com     |
	Then Key Information section is displayed

	Scenario: AgentSignUp_PrincipalDetails012_Verify that Progress line for Principal Details is displayed as filled on navigating to next section
	Given User is on Agent_Registration Page
	And User navigates to Principal Details section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       |
	When I Enter values in Principal Details as
		| PrincipalFirstName | PrincipalLastName | PrincipalEmail |
		| PFirst             | PLast             | a@bcde.com     |
	Then Progress line for Principal Details is displayed as filled