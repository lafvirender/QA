Feature: LandlordInsuranceAdviceFieldsVerification
In order to submit the proposal for Landlords
	As an Agent
	I want to be able to enter select the option for Landlord Insurance Advice

@mytag
	Scenario: AgentProposalForRent_LandlordInsuranceAdvice001_Verify the Question for Landlord Insurance Advice
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	Then Question "Do you offer landlord insurance advice?" is displayed for Landlord Insurance Advice

	
	Scenario: AgentProposalForRent_LandlordInsuranceAdvice002_Verify the Question for Landlord Insurance Advice is displayed on clicking Yes option for Emergency Contact
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	And User selects Yes
	Then Question for selecting Inspection Frequency is displayed

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice003_Verify the Question for Landlord Insurance Advice is displayed on clicking No option for Emergency Contact
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	And User selects No
	Then Question for selecting Inspection Frequency is displayed
	
	Scenario: AgentProposalForRent_LandlordInsuranceAdvice004_Verify that under Progress section, Insurance circle should be displayed as Active
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	Then Insurance circle should be displayed as Active

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice005_Verify that under Progress section, Insurance circle should be displayed as Checked on navigating to next section
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	And  User selects Yes
	Then Insurance circle is displayed as Checked

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice006_Verify that link for Moving Forward should be disabled by default
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	Then Links for Moving_Forward is disabled

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice007_Verify that link for Moving forward is displayed as enabled when user moves back to Landlord Insurance question from Property Inspection Frequency question
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	And  User selects Yes
	And I move back to Landlord Insurance Advice from Property Inspection Frequency question
	Then Link for moving_forward is enabled

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice008_Verify that Property Inspection Frequency question is displayed on clicking Forward link on Landlord Insurance Advice question
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	And User selects Yes
	And I move back to Landlord Insurance Advice from Property Inspection Frequency question
	And I Click Forward_Link
	Then  Question for selecting Inspection Frequency is displayed

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice009_Verify the color of option Yes when it is not selected
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	Then Color of the Yes option is "#00AEFF"

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice010_Verify the color of option No when it is not selected
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	Then Color of the No option is "#00AEFF"

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice011_Verify the color of option Yes changes on selection
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	And User selects Yes
	And I move back to Landlord Insurance Advice from Property Inspection Frequency question
	Then Color of the Yes option is "#14B24B"

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice012_Verify the color of option No changes on selection
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	And User selects No
	And I move back to Landlord Insurance Advice from Property Inspection Frequency question
	Then Color of the No option is "#14B24B"

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice013_Verify the color of option Yes changes on deselection
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	And User selects Yes
	And I move back to Landlord Insurance Advice from Property Inspection Frequency question
	And User selects Yes
	Then Color of the Yes option is "#00AEFF"

	Scenario: AgentProposalForRent_LandlordInsuranceAdvice014_Verify the color of option No changes on deselection
	Given User_navigate to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Landlord Insurance page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact |
		| 50                   | 10                     | Spanish   | Yes              |
	And User selects No
	And I move back to Landlord Insurance Advice from Property Inspection Frequency question
	And User selects No
	Then Color of the No option is "#00AEFF"