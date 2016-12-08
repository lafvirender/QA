Feature: AgentWelcomeFieldsVerification
	In order to submit the proposal
	As an Agent
	I want to be able to navigate to Complete Proposal from Agent Welcome section
	
	@mytag
	Scenario: AgentSignUp_AgentWelcome001_Verify the heading on Agent Welcome section
	Given User is on AgentSignUp Page
	And User navigates to Agent Welcome section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Heading Text "Your registration is complete!" is displayed

	@mytag
	Scenario: AgentSignUp_AgentWelcome002_Verify that user navigates to  Complete your Proposal section on clicking Create My Profile
	Given User is on AgentSignUp Page
	And User navigates to Agent Welcome section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	And User clicks Create My Profile
	Then Complete your Proposal section should be displayed

	Scenario: AgentSignUp_AgentWelcome003_Verify that correct user first name is displayed on Welcome Page
	Given User is on AgentSignUp Page
	And User navigates to Agent Welcome section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Text "Thanks for signing up, First. Your principal will receive an email shortly asking them to accept the T&Cs. This will need to occur before your proposal can be made active." should be displayed