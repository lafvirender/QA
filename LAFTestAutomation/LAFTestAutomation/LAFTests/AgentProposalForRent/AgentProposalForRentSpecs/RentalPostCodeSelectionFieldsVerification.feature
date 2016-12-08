Feature: RentalPostCodeSelectionFieldsVerification
	In order to submit the proposal for Landlords
	As an Agent
	I want to be able to enter the postcodes

@mytag
	Scenario: AgentProposalForRent_PostCodesSelection001_Verify the Question for Postcodes selection
	Given User is on Agent_SignUp_Page
	And User navigates to Begin_Proposal_Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigate to Postcodes Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              |
	Then Question "Which postcodes do you cover?" is displayed for Postcodes

	Scenario: AgentProposalForRent_PostCodesSelection002_Verify that Your Biography section is displayed when user clicks Next after entering postcodes
	Given User is on Agent_SignUp_Page
	And User navigates to Begin_Proposal_Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigate to Postcodes Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              |
	When User clicks on Next after entering postcodes
	| RentalPostCodes |
	| 3055            |
	Then Your Biography section should be displayed

	Scenario: AgentProposalForRent_PostCodesSelection003_Verify that under Progress section, Postcodes circle should be displayed as Active
	Given User is on Agent_SignUp_Page
	And User navigates to Begin_Proposal_Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigate to Postcodes Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              |
	Then Postcodes circle should be displayed as Active

	Scenario: AgentProposalForRent_PostCodesSelection004_Verify that under Progress section, Postcodes circle should be displayed as Checked on navigating to next section
	Given User is on Agent_SignUp_Page
	And User navigates to Begin_Proposal_Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigate to Postcodes Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              |
	When User clicks on Next after entering postcodes
	| RentalPostCodes |
	| 3055            |
	Then Postcodes circle is displayed as Checked

	Scenario: AgentProposalForRent_PostCodesSelection005_Verify that Your Biography section is displayed when user clicks Next after entering postcodes in all the fields
	Given User is on Agent_SignUp_Page
	And User navigates to Begin_Proposal_Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigate to Postcodes Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              |
	When User clicks on Next after entering postcodes
	| RentalPostCodes          |
	| 3055,3054,3053,3052,3051 |
	Then Your Biography section should be displayed

	Scenario: AgentProposalForRent_PostCodesSelection006_Verify that Your Biography section is displayed when user clicks Next after entering postcodes in 3 fields
	Given User is on Agent_SignUp_Page
	And User navigates to Begin_Proposal_Page after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigate to Postcodes Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              |
	When User clicks on Next after entering postcodes
	| RentalPostCodes |
	| 3055,3054,3053  |
	Then Your Biography section should be displayed