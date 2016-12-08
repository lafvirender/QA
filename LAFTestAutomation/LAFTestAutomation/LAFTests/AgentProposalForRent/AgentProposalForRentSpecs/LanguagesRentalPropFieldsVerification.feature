Feature: LanguagesRentalPropFieldsVerification
	In order to submit the proposal for Landlords
	As an Agent
	I want to be able to select Languages

@mytag
	Scenario: AgentProposalForRent_LanguageSelection001_Verify the Question for Language selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Question "What languages are spoken in your office?" is displayed for Language selection page


	Scenario: AgentProposalForRent_LanguageSelection002_Verify that links for Moving Back and Forward should be disabled by default
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Links for navigating Forward and Backward are disabled

	
	Scenario: AgentProposalForRent_LanguageSelection003_Verify that Sale Autority Size question should be displayed when user selects "Arabic" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Arabic    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection004_Verify that Sale Autority Size question should be displayed when user selects "Cantonese" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Cantonese    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection005_Verify that Sale Autority Size question should be displayed when user selects "Croatian" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Croatian    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection006_Verify that Sale Autority Size question should be displayed when user selects "Dutch" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Dutch    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection007_Verify that Sale Autority Size question should be displayed when user selects "French" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| French    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection008_Verify that Sale Autority Size question should be displayed when user selects "Greek" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Greek    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection009_Verify that Sale Autority Size question should be displayed when user selects "Hebrew" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Hebrew    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection010_Verify that Sale Autority Size question should be displayed when user selects "Hindi" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Hindi    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection011_Verify that Sale Autority Size question should be displayed when user selects "Hungarian" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Hungarian    |
	Then Emergency Contact question is displayed
	

	Scenario: AgentProposalForRent_LanguageSelection012_Verify that Sale Autority Size question should be displayed when user selects "Indonesian" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Indonesian    |
	Then Emergency Contact question is displayed
	
	
	Scenario: AgentProposalForRent_LanguageSelection013_Verify that Sale Autority Size question should be displayed when user selects "English" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| English    |
	Then Emergency Contact question is displayed
	
		
	Scenario: AgentProposalForRent_LanguageSelection014_Verify that Sale Autority Size question should be displayed when user selects "Italian" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Italian    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection015_Verify that Sale Autority Size question should be displayed when user selects "Japanese" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Japanese    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection016_Verify that Sale Autority Size question should be displayed when user selects "Korean" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Korean    |
	Then Emergency Contact question is displayed


	Scenario: AgentProposalForRent_LanguageSelection017_Verify that Sale Autority Size question should be displayed when user selects "Lebanese" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Lebanese    |
	Then Emergency Contact question is displayed


	Scenario: AgentProposalForRent_LanguageSelection018_Verify that Sale Autority Size question should be displayed when user selects "Macedonian" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Macedonian    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection019_Verify that Sale Autority Size question should be displayed when user selects "Maltese" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Maltese    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection020_Verify that Sale Autority Size question should be displayed when user selects "Mandarin" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Mandarin    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection021_Verify that Sale Autority Size question should be displayed when user selects "Mandarin" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Persian    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection022_Verify that Sale Autority Size question should be displayed when user selects "Polish" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Polish    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection023_Verify that Sale Autority Size question should be displayed when user selects "Portuguese" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Portuguese |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection024_Verify that Sale Autority Size question should be displayed when user selects "Russian" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Russian    |
	Then Emergency Contact question is displayed


	Scenario: AgentProposalForRent_LanguageSelection025_Verify that Sale Autority Size question should be displayed when user selects "Serbian" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Serbian    |
	Then Emergency Contact question is displayed

	
	Scenario: AgentProposalForRent_LanguageSelection026_Verify that Sale Autority Size question should be displayed when user selects "Spanish" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Spanish    |
	Then Emergency Contact question is displayed

	
	Scenario: AgentProposalForRent_LanguageSelection027_Verify that Sale Autority Size question should be displayed when user selects "Srilankan" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Srilankan    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection028_Verify that Sale Autority Size question should be displayed when user selects "Tagalog" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Tagalog    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection029_Verify that Sale Autority Size question should be displayed when user selects "Thai" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Thai    |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection030_Verify that Sale Autority Size question should be displayed when user selects "Turkish" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Turkish    |
	Then Emergency Contact question is displayed


	Scenario: AgentProposalForRent_LanguageSelection031_Verify that Sale Autority Size question should be displayed when user selects "Vietnamese" language
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Vietnamese |
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection032_Verify that link for Moving forward is displayed as enabled when user moves back to Languages selection from Sale Authority Size section
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Vietnamese |
	And I move back to Languages Selection
	Then Forward link is displayed enabled

	Scenario: AgentProposalForRent_LanguageSelection033_Verify that Sale Authority Size section is displayed on clicking Forward link on Languages selection section.
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Vietnamese |
	And I move back to Languages Selection
	And I Click on forward
	Then Emergency Contact question is displayed

	Scenario: AgentProposalForRent_LanguageSelection034_Verify the color of option Arabic when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Arabic option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection035_Verify the color of option Cantonese when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Cantonese option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection036_Verify the color of option Croatian when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Croatian option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection037_Verify the color of option Dutch when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Dutch option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection038_Verify the color of option French when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the French option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection039_Verify the color of option Greek when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Greek option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection040_Verify the color of option Hebrew when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Hebrew option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection041_Verify the color of option Hindi when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Hindi option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection042_Verify the color of option Hungarian when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Hungarian option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection043_Verify the color of option Indonesian when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Indonesian option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection044_Verify that English option is selected by default
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the English option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection045_Verify the color of option Italian when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Italian option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection046_Verify the color of option Japanese when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Japanese option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection047_Verify the color of option Korean when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Korean option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection048_Verify the color of option Lebanese when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Lebanese option is "#00AEFF"


	Scenario: AgentProposalForRent_LanguageSelection049_Verify the color of option Macedonian when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Macedonian option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection050_Verify the color of option Maltese when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Maltese option is "#00AEFF"


	Scenario: AgentProposalForRent_LanguageSelection051_Verify the color of option Mandarin when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Mandarin option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection052_Verify the color of option Persian when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Persian option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection053_Verify the color of option Polish when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Polish option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection054_Verify the color of option Portuguese when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Portuguese option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection055_Verify the color of option Russian when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Russian option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection056_Verify the color of option Serbian when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Serbian option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection057_Verify the color of option Spanish when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Spanish option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection058_Verify the color of option Srilankan when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Srilankan option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection059_Verify the color of option Tagalog when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Tagalog option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection060_Verify the color of option Thai when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Thai option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection061_Verify the color of option Turkish when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Turkish option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection062_Verify the color of option Vietnamese when it is not selected
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Color of the Vietnamese option is "#00AEFF"

	Scenario: AgentProposalForRent_LanguageSelection063_Verify the color of option Arabic changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Arabic    |
	And I move back to Languages Selection
	Then Color of the Arabic option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection064_Verify the color of option Arabic changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Arabic |
	And I move back to Languages Selection
	Then Color of the Arabic option is "#14B24B"

	
	Scenario: AgentProposalForRent_LanguageSelection065_Verify the color of option  Cantonese changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Cantonese |
	And I move back to Languages Selection
	Then Color of the Cantonese option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection066_Verify the color of option  Croatian changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Croatian |
	And I move back to Languages Selection
	Then Color of the Croatian option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection067_Verify the color of option  Dutch changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Dutch |
	And I move back to Languages Selection
	Then Color of the Dutch option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection068_Verify the color of option  French changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| French |
	And I move back to Languages Selection
	Then Color of the French option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection069_Verify the color of option  Greek changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Greek |
	And I move back to Languages Selection
	Then Color of the Greek option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection070_Verify the color of option  Hebrew changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Hebrew |
	And I move back to Languages Selection
	Then Color of the Hebrew option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection071_Verify the color of option  Hindi changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Hindi |
	And I move back to Languages Selection
	Then Color of the Hindi option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection072_Verify the color of option  Hungarian changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Hungarian |
	And I move back to Languages Selection
	Then Color of the Hungarian option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection073_Verify the color of option  Indonesian changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Indonesian |
	And I move back to Languages Selection
	Then Color of the Indonesian option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection074_Verify the color of option  English changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| English |
	And I move back to Languages Selection
	Then Color of the English option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection075_Verify the color of option  Italian changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Italian |
	And I move back to Languages Selection
	Then Color of the Italian option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection076_Verify the color of option  Japanese changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Japanese |
	And I move back to Languages Selection
	Then Color of the Japanese option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection077_Verify the color of option  Korean changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Korean |
	And I move back to Languages Selection
	Then Color of the Korean option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection078_Verify the color of option  Lebanese changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Lebanese |
	And I move back to Languages Selection
	Then Color of the Lebanese option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection079_Verify the color of option Macedonian changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Macedonian |
	And I move back to Languages Selection
	Then Color of the Macedonian option is "#14B24B"


	Scenario: AgentProposalForRent_LanguageSelection080_Verify the color of option Maltese changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Maltese |
	And I move back to Languages Selection
	Then Color of the Maltese option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection081_Verify the color of option Mandarin changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Mandarin |
	And I move back to Languages Selection
	Then Color of the Mandarin option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection082_Verify the color of option Persian changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Persian |
	And I move back to Languages Selection
	Then Color of the Persian option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection083_Verify the color of option Polish changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as 
	| Languages  |
	| Polish |
	And I move back to Languages Selection
	Then Color of the Polish option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection084_Verify the color of option Portuguese changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as 
	| Languages  |
	| Portuguese |
	And I move back to Languages Selection
	Then Color of the Portuguese option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection085_Verify the color of option Russian changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as 
	| Languages  |
	| Russian |
	And I move back to Languages Selection
	Then Color of the Russian option is "#14B24B"


	Scenario: AgentProposalForRent_LanguageSelection086_Verify the color of option Serbian changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as 
	| Languages  |
	| Serbian |
	And I move back to Languages Selection
	Then Color of the Serbian option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection087_Verify the color of option Spanish changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as 
	| Languages  |
	| Spanish |
	And I move back to Languages Selection
	Then Color of the Spanish option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection088_Verify the color of option Srilankan changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as 
	| Languages  |
	| Srilankan |
	And I move back to Languages Selection
	Then Color of the Srilankan option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection089_Verify the color of option Tagalog changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as 
	| Languages  |
	| Tagalog |
	And I move back to Languages Selection
	Then Color of the Tagalog option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection090_Verify the color of option Thai changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Thai |
	And I move back to Languages Selection
	Then Color of the Thai option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection091_Verify the color of option Turkish changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Turkish |
	And I move back to Languages Selection
	Then Color of the Turkish option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection092_Verify the color of option Vietnamese changes on selection
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages  |
	| Vietnamese |
	And I move back to Languages Selection
	Then Color of the Vietnamese option is "#14B24B"

	Scenario: AgentProposalForRent_LanguageSelection093_Verify that under Progress section, Languages circle should be displayed as Active
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	Then Languages circle should be displayed as Active

	Scenario: AgentProposalForRent_LanguageSelection094_Verify that under Progress section, Languages circle should be displayed as Checked on navigating to next section
	Given User navigate to Agent_Registration Page
	And User navigates to Beg_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after entering details as
	| PropertyMgmtTeamSize | PropertyPerPropManager |
	| 50                   | 10                     |
	And User clicks on Next after selecting Languages as
	| Languages |
	| Arabic    |
	Then Languages circle is displayed as Checked