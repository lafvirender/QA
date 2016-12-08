Feature: PropertiesPerPropManagerFieldsVerification
	In order to submit the proposal for Landlords
	As an Agent
	I want to be able to enter Properties Per Prop Manager

@mytag
	Scenario: AgentProposalForRent_PropPerPropManager001_Verify the Question for Properties Per Property Manager
	Given User goes to Agent_Registration_Page
	And User goes to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Properties Per Property Manager page  after entering details as
	| PropertyMgmtTeamSize |
	| 5                    |
	Then Question "How many properties does each property manager look after?" is displayed for Properties Per Property Manager

	
	Scenario: AgentProposalForRent_PropPerPropManager002_Verify that Property Per Property Manager selection question is displayed when user clicks Next after selecting Properties Per Property Manager
	Given User goes to Agent_Registration_Page
	And User goes to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Properties Per Property Manager page  after entering details as
	| PropertyMgmtTeamSize |
	| 50                    |
	And User clicks Next after entering Properties Per Property Manager As
	| PropertyPerPropManager |
	| 30                     |
	Then Language Selection question is displayed

	Scenario: AgentProposalForRent_PropPerPropManager003_Verify that error message is displayed when user clicks Next without entering Properties Per Property Manager
	Given User goes to Agent_Registration_Page
	And User goes to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Properties Per Property Manager page  after entering details as
	| PropertyMgmtTeamSize |
	| 50                    |
	And  User clicks on Next
	Then Error with msg "How many properties does each property manager look after?" is displayed

	Scenario: AgentProposalForRent_PropPerPropManager004_Verify that error message is displayed when user clicks Next without entering alphabets in Properties Per Property Manager
	Given User goes to Agent_Registration_Page
	And User goes to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Properties Per Property Manager page  after entering details as
	| PropertyMgmtTeamSize |
	| 50                    |
	And User clicks Next after entering Properties Per Property Manager As
	| PropertyPerPropManager |
	| abcd                   |
	Then Error with msg "How many properties does each property manager look after?" is displayed

	Scenario: AgentProposalForRent_PropPerPropManager005_Verify that under Progress section, Properties circle should be displayed as Active
	Given User goes to Agent_Registration_Page
	And User goes to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Properties Per Property Manager page  after entering details as
	| PropertyMgmtTeamSize |
	| 5                    |
	Then Properties circle should be displayed as Active

	Scenario: AgentProposalForRent_PropPerPropManager006_Verify that under Progress section, Properties circle should be displayed as Checked on navigating to next section
	Given User goes to Agent_Registration_Page
	And User goes to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Properties Per Property Manager page  after entering details as
	| PropertyMgmtTeamSize |
	| 50                    |
	And User clicks Next after entering Properties Per Property Manager As
	| PropertyPerPropManager |
	| 30                     |
	Then Properties circle should be displayed as Checked