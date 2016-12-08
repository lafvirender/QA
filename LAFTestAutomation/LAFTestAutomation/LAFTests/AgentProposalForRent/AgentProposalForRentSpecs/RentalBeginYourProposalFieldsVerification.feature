Feature: RentalBeginYourProposalFieldsVerification
	In order to submit the proposal for Vendors
	As an Agent
	I want to be able to Begin Proposal


@mytag
	Scenario: AgentProposalForRent_BeginProposal001_Verify the Heading Text for Begin Proposal
	Given User navigates to Agent_Reg Page
	And User navigates to Begin_Proposal after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail  | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Heading Text "Complete your Proposal" should be displayed

	Scenario: AgentProposalForRent_BeginProposal002_Verify that Property Managment Team Size selection section is dislayed on clicking Begin
	Given User navigates to Agent_Reg Page
	And User navigates to Begin_Proposal after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	And User clicks on Begin
	Then Property Managment Team Size selection section is dislayed