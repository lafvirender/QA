Feature: EmergencyContactFieldsVerification
	In order to submit the proposal for Landlords
	As an Agent
	I want to be able to enter select the option for Emergency Contact

@mytag
	Scenario: AgentProposalForRent_EmergencyContact001_Verify the Question for 24 hours Emergency Contact
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	Then Question "Do you offer a 24-hour emergency contact?" is displayed for Emergency Contact

	Scenario: AgentProposalForRent_EmergencyContact002_Verify the Question for Landlord Insurance Advice is displayed on clicking Yes option for Emergency Contact
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	And User selects option Yes
	Then Question for Landlord Insurance Advice is displayed

	Scenario: AgentProposalForRent_EmergencyContact003_Verify the Question for Landlord Insurance Advice is displayed on clicking Yes option for Emergency Contact
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	And User selects option No
	Then Question for Landlord Insurance Advice is displayed

	Scenario: AgentProposalForRent_EmergencyContact004_Verify that under Progress section, EMERGENCY circle should be displayed as Active
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	Then EMERGENCY circle should be displayed as Active

	Scenario: AgentProposalForRent_EmergencyContact005_Verify that under Progress section, EMERGENCY circle should be displayed as Checked on navigating to next section
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	And User selects option Yes
	Then EMERGENCY circle is displayed as Checked

	Scenario: AgentProposalForRent_EmergencyContact006_Verify that link for Moving Forward should be disabled by default
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	Then Links for Moving Forward is disabled

	Scenario: AgentProposalForRent_EmergencyContact007_Verify that link for Moving forward is displayed as enabled when user moves back to Emergency Contact question from Landlord Insurance Advice question
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	And User selects option Yes
	And I move back to Emergency Selection from Landlord Insurance Advice
	Then Link for moving forward should be enabled

	Scenario: AgentProposalForRent_EmergencyContact008_Verify that Landlord Insurance Advice question is displayed on clicking Forward link on Emergency Contact question
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	And User selects option Yes
	And I move back to Emergency Selection from Landlord Insurance Advice
	And I Click on Forward_Link
	Then  Question for Landlord Insurance Advice is displayed


	Scenario: AgentProposalForRent_EmergencyContact009_Verify the color of option Yes when it is not selected
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	Then Color of the Yes option should be "#00AEFF"

	Scenario: AgentProposalForRent_EmergencyContact010_Verify the color of option No when it is not selected
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	Then Color of the No option should be "#00AEFF"

	Scenario: AgentProposalForRent_EmergencyContact011_Verify the color of option Yes changes on selection
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	And User selects option Yes
	And I move back to Emergency Selection from Landlord Insurance Advice
	Then Color of the Yes option should be "#14B24B"

	Scenario: AgentProposalForRent_EmergencyContact012_Verify the color of option No changes on selection
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	And User selects option No
	And I move back to Emergency Selection from Landlord Insurance Advice
	Then Color of the No option should be "#14B24B"

	Scenario: AgentProposalForRent_EmergencyContact013_Verify the color of option Yes changes on deselection
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	And User selects option Yes
	And I move back to Emergency Selection from Landlord Insurance Advice
	And User selects option Yes
	Then Color of the Yes option should be "#00AEFF"

	Scenario: AgentProposalForRent_EmergencyContact014_Verify the color of option No changes on deselection
	Given User_navigates to Agent_Registration_Page
	And User_navigates to Begin_Proposal after registering agent with
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Emergency Contact page  after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages |
		| 50                   | 10                     | Spanish   |
	And User selects option No
	And I move back to Emergency Selection from Landlord Insurance Advice
	And User selects option No
	Then Color of the Yes option should be "#00AEFF"