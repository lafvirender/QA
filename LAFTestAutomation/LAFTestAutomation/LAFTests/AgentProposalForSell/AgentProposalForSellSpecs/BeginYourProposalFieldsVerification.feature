Feature: BeginYourProposalFieldsVerification
	In order to submit the proposal for Vendors
	As an Agent
	I want to be able to Begin Proposal
	Given

@mytag
	Scenario: AgentProposalForSell_BeginProposal001_Verify the Heading Text for Begin Proposal
	Given User navigates to Agent Registration Page
	And User navigates to Begin Proposal after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then HeadingText "Complete your Proposal" is displayed

	Scenario: AgentProposalForSell_BeginProposal002_Verify that Sales Method selection section is dislayed on clicking Begin
	Given User navigates to Agent Registration Page
	And User navigates to Begin Proposal after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	And User clicks Begin
	Then Sales Method Selection page is displayed 