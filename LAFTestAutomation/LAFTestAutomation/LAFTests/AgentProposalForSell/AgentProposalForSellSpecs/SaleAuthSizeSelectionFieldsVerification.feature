Feature: SaleAuthSizeSelectionFieldsVerification
	In order to submit the proposal for Vendors
	As an Agent
	I want to be able to select Sales Authority Size

@mytag
	Scenario: AgentProposalForSell_SalesAuthSelection001_Verify the Question for Sales Authority Size selection
	Given User navigates to Agent_Registration_Page
	And User navigates to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Sales Authority Size Selection after selecting details as
	| SaleMethods | Languages |
	| Auctions    | Arabic    |
	Then Question "How long is your standard sale authority?" is displayed for Authority Team Size selection

	Scenario: AgentProposalForSell_SalesAuthSelection002_Verify that Sales Team selection question is displayed when user clicks Next after selecting Sales Authority Size
	Given User navigates to Agent_Registration_Page
	And User navigates to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Sales Authority Size Selection after selecting details as
	| SaleMethods | Languages       |
	| Auctions    | Arabic |
	And User clicks Next after selecting Sales Authority Size As
	| SaleAuthoritySize |
	| 1 month           |
	Then Sales Team selection question is displayed

	Scenario: AgentProposalForSell_SalesAuthSelection003_Verify that under Progress section, Authority circle should be displayed as Active
	Given User navigates to Agent_Registration_Page
	And User navigates to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Sales Authority Size Selection after selecting details as
	| SaleMethods | Languages |
	| Auctions    | Arabic    |
	Then Authority circle should be displayed as Active

	Scenario: AgentProposalForSell_SalesAuthSelection004_Verify that under Progress section, Authority circle should be displayed as Checked on navigating to next section
	Given User navigates to Agent_Registration_Page
	And User navigates to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Sales Authority Size Selection after selecting details as
	| SaleMethods | Languages |
	| Auctions    | Arabic    |
	And User clicks Next after selecting Sales Authority Size As
	| SaleAuthoritySize |
	| 1 month           |
	Then Authority circle should be displayed as Checked

	Scenario: AgentProposalForSell_SalesAuthSelection005_Verify options under Sale Authority Selection drop down
	Given User navigates to Agent_Registration_Page
	And User navigates to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Sales Authority Size Selection after selecting details as
	| SaleMethods | Languages |
	| Auctions    | Arabic    |
	Then Below options should be available under Sale Authority Selection drop down
		| SaleAuthoritySize |
		| No exclusivity    |
		| 1 month           |
		| 2 months          |
		| 3 months          |
		| 4 months          |
		| 5 months          |
		| 6 months          |
		| 9 months          |
		| 12 months         |