Feature: SalesTeamSizeSelectionFieldsVerification
	In order to submit the proposal for Vendors
	As an Agent
	I want to be able to select Sales Team Size

@mytag
	Scenario: AgentProposalForSell_SalesTeamSelection001_Verify the Question for Sales Team Size selection
	Given User navigates to Agent_Reg_Page
	And User navigates to Begin Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Sales Team Size Selection after selecting details as
	| SaleMethods | Languages | SaleAuthoritySize |
	| Auctions    | Arabic    | 1 month           |
	Then Question "How many people are in your sales team?" is displayed for Sales Team Size selection

	Scenario: AgentProposalForSell_SalesTeamSelection002_Verify that Postcode selection question is displayed when user clicks Next after selecting Sales Team Size
	Given User navigates to Agent_Reg_Page
	And User navigates to Begin Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	And User navigates to Sales Team Size Selection after selecting details as
	| SaleMethods | Languages | SaleAuthoritySize |
	| Auctions    | Arabic    | 1 month           |
	When User clicks Next after selecting Sales Team Size As
	| SaleTeamSize |
	| 1            |
	Then Postcode selection question is displayed

	Scenario: AgentProposalForSell_SalesTeamSelection003_Verify that under Progress section, Team Size circle should be displayed as Active
	Given User navigates to Agent_Reg_Page
	And User navigates to Begin Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	And User navigates to Sales Team Size Selection after selecting details as
	| SaleMethods | Languages | SaleAuthoritySize |
	| Auctions    | Arabic    | 1 month           |
	Then Team Size circle should be displayed as Active

	Scenario: AgentProposalForSell_SalesTeamSelection004_Verify that under Progress section, Team Size circle should be displayed as Checked on navigating to next section
	Given User navigates to Agent_Reg_Page
	And User navigates to Begin Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	And User navigates to Sales Team Size Selection after selecting details as
	| SaleMethods | Languages | SaleAuthoritySize |
	| Auctions    | Arabic    | 1 month           |
	When User clicks Next after selecting Sales Team Size As
	| SaleTeamSize |
	| 1            |
	Then Team Size circle should be displayed as Checked