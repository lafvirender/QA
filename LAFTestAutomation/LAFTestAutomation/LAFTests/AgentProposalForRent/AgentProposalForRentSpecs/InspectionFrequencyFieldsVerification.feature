Feature: InspectionFrequencyFieldsVerification
	In order to submit the proposal for Vendors
	As an Agent
	I want to be able to select Inspection Frequency

@mytag
	Scenario: AgentProposalForRent_InspectionFreqSelection001_Verify the Question for Inspection Frequency selection
	Given User_navigate to Agent Registration_Page
	And User navigates to BeginProposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Inspection Frequency Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     |
	Then Question "How often do you typically run property inspections?" is displayed for Inspection Frequency selection

	Scenario: AgentProposalForRent_InspectionFreqSelection002_Verify that Postcode selection question is displayed when user clicks Next after selecting Inspection Frequency as Every 3 months
	Given User_navigate to Agent Registration_Page
	And User navigates to BeginProposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Inspection Frequency Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     |
	And User clicks Next after selecting Inspection Frequency As
	| InspectionFrequencyPeriod |
	| Every 3 months           |
	Then Question for Postcode selection is displayed

	Scenario: AgentProposalForRent_InspectionFreqSelection003_Verify that under Progress section, Inspection circle should be displayed as Active
	Given User_navigate to Agent Registration_Page
	And User navigates to BeginProposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Inspection Frequency Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     |
	Then Inspection circle should be displayed as Active

	Scenario: AgentProposalForRent_InspectionFreqSelection004_Verify that under Progress section, Inspection circle should be displayed as Checked on navigating to next section
	Given User_navigate to Agent Registration_Page
	And User navigates to BeginProposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Inspection Frequency Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     |
	And User clicks Next after selecting Inspection Frequency As
	| InspectionFrequencyPeriod |
	| Every 3 months           |
	Then Inspection circle is displayed as Checked

	Scenario: AgentProposalForRent_InspectionFreqSelection005_Verify options under Property Inspection Frequency drop down
	Given User_navigate to Agent Registration_Page
	And User navigates to BeginProposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Inspection Frequency Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     |
	Then Below options should be available under Inspection Frequency drop down
		| InspectionFrequencyPeriod |
		| As requested              |
		| Every 3 months            |
		| Every 4 months            |
		| Every 6 months            |
		| Every 9 months            |
		| Every 12 months           |

	Scenario: AgentProposalForRent_InspectionFreqSelection006_Verify that next section is not displayed when user clicks Next without selecting any valid option for Inspection Frequency
	Given User_navigate to Agent Registration_Page
	And User navigates to BeginProposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Inspection Frequency Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     |
	And User clicks Next after selecting Inspection Frequency As
	| InspectionFrequencyPeriod |
	| Select                    |
	Then Question for Postcode selection is not displayed

	Scenario: AgentProposalForRent_InspectionFreqSelection007_Verify that Postcode selection question is displayed when user clicks Next after selecting Inspection Frequency as As requested
	Given User_navigate to Agent Registration_Page
	And User navigates to BeginProposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Inspection Frequency Selection after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     |
	And User clicks Next after selecting Inspection Frequency As
	| InspectionFrequencyPeriod |
	| As requested              |
	Then Question for Postcode selection is displayed


