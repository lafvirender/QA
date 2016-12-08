Feature: PropertyMgmtTeamSizeFieldsVerification
	In order to submit the proposal for Landlords
	As an Agent
	I want to be able to select Property Management Team Size

@mytag
	Scenario: AgentProposalForRent_PropMgmtTeam001_Verify the Question for Property Managment Team Size selection
	Given User goes to Agent_Reg_Page
	And User goes to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Property Management Team Size Selection page 
	Then Question "How many people are in your property management team?" is displayed for Property Managment Team Size selection

	
	Scenario: AgentProposalForRent_PropMgmtTeam002_Verify that Property Per Property Manager selection question is displayed when user clicks Next after selecting Property Managment Team Size
	Given User goes to Agent_Reg_Page
	And User goes to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Property Management Team Size Selection page 
	When User clicks Next after selecting Property Management Team Size As
	| PropertyMgmtTeamSize |
	| 5                    |
	Then Property Per Property Manager selection question is displayed

	Scenario: AgentProposalForRent_PropMgmtTeam003_Verify that error message is displayed when user clicks Next without entering Property Managment Team Size
	Given User goes to Agent_Reg_Page
	And User goes to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Property Management Team Size Selection page 
	When User clicks Next
	Then Error with message "How many people are in your property management team?" is displayed

	Scenario: AgentProposalForRent_PropMgmtTeam004_Verify that error message is displayed when user clicks Next after entering alphabets in Property Managment Team Size
	Given User goes to Agent_Reg_Page
	And User goes to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Property Management Team Size Selection page 
	When User clicks Next after selecting Property Management Team Size As
	| PropertyMgmtTeamSize |
	| abcd                 |
	Then Error with message "How many people are in your property management team?" is displayed

	Scenario: AgentProposalForRent_PropMgmtTeam005_Verify that under Progress section, Team Size circle should be displayed as Active
	Given User goes to Agent_Reg_Page
	And User goes to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Property Management Team Size Selection page 
	Then Team Size circle is displayed as Active

	Scenario: AgentProposalForRent_PropMgmtTeam006_Verify that under Progress section, Team Size circle should be displayed as Checked on navigating to next section
	Given User goes to Agent_Reg_Page
	And User goes to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Property Management Team Size Selection page 
	When User clicks Next after selecting Property Management Team Size As
	| PropertyMgmtTeamSize |
	| 5                    |
	Then Team Size circle is displayed as Checked

	Scenario: AgentProposalForRent_PropMgmtTeam007_Verify that error message is displayed when user clicks Next after entering decimal value in Property Managment Team Size
	Given User goes to Agent_Reg_Page
	And User goes to BeginProposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Property Management Team Size Selection page 
	And User clicks Next after selecting Property Management Team Size As
	| PropertyMgmtTeamSize |
	| 5.88                 |
	Then Error with message "How many people are in your property management team?" is displayed