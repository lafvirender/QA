Feature: KeyInfoFieldsVerification
	In order to submit the proposal
	As an Agent
	I want to be able to accept the Key Information
	
	@mytag
	Scenario: AgentSignUp_KeyInfo001_Verify the heading on KeyInfo section
	Given User navigates to Agent_SignUp Page
	And User navigates to Key Information section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail          |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing1676587567.com |
	Then Heading "Fees" is displayed

	Scenario: AgentSignUp_KeyInfo002_Verify the Key Information section for both Sales and Rentals
	Given User navigates to Agent_SignUp Page
	And User navigates to Key Information section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail          |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing1676587567.com |
	Then Key Information section for both Sales and Rentals should be displayed

	Scenario: AgentSignUp_KeyInfo003_Verify the Key Information section for Sales is displayed
	Given User navigates to Agent_SignUp Page
	And User navigates to Key Information section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail          |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing1676587567.com |
	Then Key Information section for Sales should be displayed

	Scenario: AgentSignUp_KeyInfo004_Verify the Key Information section for Rentals is displayed
	Given User navigates to Agent_SignUp Page
	And User navigates to Key Information section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail          |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing1676587567.com |
	Then Key Information section for Rentals should be displayed

	Scenario: AgentSignUp_KeyInfo005_Verify that user navigates to Terms And Conditions on clicking Accept and Continue
	Given User navigates to Agent_SignUp Page
	And User navigates to Key Information section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail     | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail          |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing1676587567.com |
	And User clicks on Accept & Continue button
	Then Terms and Conditions section should be displayed

