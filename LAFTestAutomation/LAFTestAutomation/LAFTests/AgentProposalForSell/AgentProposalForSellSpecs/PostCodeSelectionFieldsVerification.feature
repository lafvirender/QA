Feature: PostCodeSelectionFieldsVerification
	In order to submit the proposal for Vendors
	As an Agent
	I want to be able to enter the postcodes

@mytag
	Scenario: AgentProposalForSell_PostCodesSelection001_Verify the Question for Postcodes selection
	Given User is on Agent_Reg_Page
	And User navigates to BeginProposal Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Postcodes Selection after entering details as
	| SaleMethods | Languages       | SaleAuthoritySize | SaleTeamSize |
	| Auctions    | Arabic | 1 month           | 5            |
	Then Question "Which postcodes do you cover?" is displayed for Postcodes selection

	Scenario: AgentProposalForSell_PostCodesSelection002_Verify that Your Biography section is displayed when user clicks Next after entering postcodes
	Given User is on Agent_Reg_Page
	And User navigates to BeginProposal Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Postcodes Selection after entering details as
	| SaleMethods | Languages       | SaleAuthoritySize | SaleTeamSize |
	| Auctions    | Arabic | 1 month           | 5            |
	When User clicks Next after entering postcodes As
	| PostCodes |
	| 3055      |
	Then Your Biography section is displayed

	Scenario: AgentProposalForSell_PostCodesSelection003_Verify that under Progress section, PostCodes circle should be displayed as Active
	Given User is on Agent_Reg_Page
	And User navigates to BeginProposal Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Postcodes Selection after entering details as
	| SaleMethods | Languages       | SaleAuthoritySize | SaleTeamSize |
	| Auctions    | Arabic | 1 month           | 5            |
	Then PostCodes circle should be displayed as Active

	Scenario: AgentProposalForSell_PostCodesSelection004_Verify that under Progress section, PostCodes circle should be displayed as Checked on navigating to next section
	Given User is on Agent_Reg_Page
	And User navigates to BeginProposal Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Postcodes Selection after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize |
	| Auctions    | Arabic    | 1 month           | 5            |
	When User clicks Next after entering postcodes As
	| PostCodes |
	| 3055      |
	Then PostCodes circle should be displayed as Checked

	Scenario: AgentProposalForSell_PostCodesSelection005_Verify that Your Biography section is displayed when user clicks Next after entering postcodes in all the fields
	Given User is on Agent_Reg_Page
	And User navigates to BeginProposal Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Postcodes Selection after entering details as
	| SaleMethods | Languages       | SaleAuthoritySize | SaleTeamSize |
	| Auctions    | Arabic | 1 month           | 5            |
	When User clicks Next after entering postcodes As
	| PostCodes                |
	| 3055,3054,3053,3052,3051 |
	Then Your Biography section is displayed

	Scenario: AgentProposalForSell_PostCodesSelection006_Verify that Your Biography section is displayed when user clicks Next after entering postcodes in 3 fields
	Given User is on Agent_Reg_Page
	And User navigates to BeginProposal Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Postcodes Selection after entering details as
	| SaleMethods | Languages       | SaleAuthoritySize | SaleTeamSize |
	| Auctions    | Arabic | 1 month           | 5            |
	When User clicks Next after entering postcodes As
	| PostCodes      |
	| 3055,3054,3053 |
	Then Your Biography section is displayed