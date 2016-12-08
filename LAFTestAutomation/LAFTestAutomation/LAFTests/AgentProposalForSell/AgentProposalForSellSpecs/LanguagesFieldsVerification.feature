Feature: LanguagesFieldsVerification
	In order to submit the proposal for Vendors
	As an Agent
	I want to be able to select Languages

@mytag
	Scenario: AgentProposalForSell_LanguageSelection001_Verify the Question for Language selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions    | 
	Then Question "What languages are spoken in your office?" is displayed for Language selection


	Scenario: AgentProposalForSell_LanguageSelection002_Verify that link for Moving Forward should be disabled by default
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions    | 
	Then Link for Moving Forward is displayed as enabled

	
	Scenario: AgentProposalForSell_LanguageSelection003_Verify that Sale Autority Size question should be displayed when user selects "Arabic" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions    |
	And User clicks Next after selecting Languages as
	| Languages |
	| Arabic    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection004_Verify that Sale Autority Size question should be displayed when user selects "Cantonese" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions    |
	And User clicks Next after selecting Languages as
	| Languages |
	| Cantonese    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection005_Verify that Sale Autority Size question should be displayed when user selects "Croatian" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Croatian    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection006_Verify that Sale Autority Size question should be displayed when user selects "Dutch" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Dutch    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection007_Verify that Sale Autority Size question should be displayed when user selects "French" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| French    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection008_Verify that Sale Autority Size question should be displayed when user selects "Greek" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Greek    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection009_Verify that Sale Autority Size question should be displayed when user selects "Hebrew" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Hebrew    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection010_Verify that Sale Autority Size question should be displayed when user selects "Hindi" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Hindi    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection011_Verify that Sale Autority Size question should be displayed when user selects "Hungarian" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Hungarian    |
	Then Sale Autority Size question is displayed
	

	Scenario: AgentProposalForSell_LanguageSelection012_Verify that Sale Autority Size question should be displayed when user selects "Indonesian" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Indonesian    |
	Then Sale Autority Size question is displayed
	
	
	Scenario: AgentProposalForSell_LanguageSelection013_Verify that Sale Autority Size question should be displayed when user selects "English" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| English    |
	Then Sale Autority Size question is displayed
	
		
	Scenario: AgentProposalForSell_LanguageSelection014_Verify that Sale Autority Size question should be displayed when user selects "Italian" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Italian    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection015_Verify that Sale Autority Size question should be displayed when user selects "Japanese" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Japanese    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection016_Verify that Sale Autority Size question should be displayed when user selects "Korean" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Korean    |
	Then Sale Autority Size question is displayed


	Scenario: AgentProposalForSell_LanguageSelection017_Verify that Sale Autority Size question should be displayed when user selects "Lebanese" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Lebanese    |
	Then Sale Autority Size question is displayed


	Scenario: AgentProposalForSell_LanguageSelection018_Verify that Sale Autority Size question should be displayed when user selects "Macedonian" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Macedonian    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection019_Verify that Sale Autority Size question should be displayed when user selects "Maltese" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Maltese    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection020_Verify that Sale Autority Size question should be displayed when user selects "Mandarin" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Mandarin    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection021_Verify that Sale Autority Size question should be displayed when user selects "Mandarin" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Persian    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection022_Verify that Sale Autority Size question should be displayed when user selects "Polish" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Polish    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection023_Verify that Sale Autority Size question should be displayed when user selects "Portuguese" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Portuguese    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection024_Verify that Sale Autority Size question should be displayed when user selects "Russian" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Russian    |
	Then Sale Autority Size question is displayed


	Scenario: AgentProposalForSell_LanguageSelection025_Verify that Sale Autority Size question should be displayed when user selects "Serbian" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Serbian    |
	Then Sale Autority Size question is displayed

	
	Scenario: AgentProposalForSell_LanguageSelection026_Verify that Sale Autority Size question should be displayed when user selects "Spanish" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Spanish    |
	Then Sale Autority Size question is displayed

	
	Scenario: AgentProposalForSell_LanguageSelection027_Verify that Sale Autority Size question should be displayed when user selects "Srilankan" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Srilankan    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection028_Verify that Sale Autority Size question should be displayed when user selects "Tagalog" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Tagalog    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection029_Verify that Sale Autority Size question should be displayed when user selects "Thai" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Thai    |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection030_Verify that Sale Autority Size question should be displayed when user selects "Turkish" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages |
	| Turkish    |
	Then Sale Autority Size question is displayed


	Scenario: AgentProposalForSell_LanguageSelection031_Verify that Sale Autority Size question should be displayed when user selects "Vietnamese" language
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Vietnamese |
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection032_Verify that link for Moving forward is displayed as enabled when user moves back to Languages selection from Sale Authority Size section
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Vietnamese |
	And I move back to Languages Selection from Sale Authority Size section
	Then Moving forward link is enabled

	Scenario: AgentProposalForSell_LanguageSelection033_Verify that Sale Authority Size section is displayed on clicking Forward link on Languages selection section.
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Vietnamese |
	And I move back to Languages Selection from Sale Authority Size section
	And I Click on link to move forward
	Then Sale Autority Size question is displayed

	Scenario: AgentProposalForSell_LanguageSelection034_Verify the color of option Arabic when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Arabic option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection035_Verify the color of option Cantonese when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Cantonese option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection036_Verify the color of option Croatian when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Croatian option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection037_Verify the color of option Dutch when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Dutch option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection038_Verify the color of option French when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the French option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection039_Verify the color of option Greek when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Greek option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection040_Verify the color of option Hebrew when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Hebrew option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection041_Verify the color of option Hindi when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Hindi option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection042_Verify the color of option Hungarian when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Hungarian option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection043_Verify the color of option Indonesian when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Indonesian option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection044_Verify that option English is selected by default
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the English option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection045_Verify the color of option Italian when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Italian option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection046_Verify the color of option Japanese when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Japanese option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection047_Verify the color of option Korean when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Korean option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection048_Verify the color of option Lebanese when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Lebanese option should be "#00AEFF"


	Scenario: AgentProposalForSell_LanguageSelection049_Verify the color of option Macedonian when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Macedonian option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection050_Verify the color of option Maltese when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Maltese option should be "#00AEFF"


	Scenario: AgentProposalForSell_LanguageSelection051_Verify the color of option Mandarin when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Mandarin option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection052_Verify the color of option Persian when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Persian option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection053_Verify the color of option Polish when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Polish option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection054_Verify the color of option Portuguese when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Portuguese option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection055_Verify the color of option Russian when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Russian option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection056_Verify the color of option Serbian when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Serbian option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection057_Verify the color of option Spanish when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Spanish option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection058_Verify the color of option Srilankan when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Srilankan option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection059_Verify the color of option Tagalog when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Tagalog option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection060_Verify the color of option Thai when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Thai option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection061_Verify the color of option Turkish when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Turkish option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection062_Verify the color of option Vietnamese when it is not selected
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	Then Color of the Vietnamese option should be "#00AEFF"

	Scenario: AgentProposalForSell_LanguageSelection063_Verify the color of option Arabic changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Arabic |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Arabic option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection064_Verify the color of option Arabic changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Arabic |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Arabic option should be "#14B24B"

	
	Scenario: AgentProposalForSell_LanguageSelection065_Verify the color of option  Cantonese changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Cantonese |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Cantonese option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection066_Verify the color of option  Croatian changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Croatian |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Croatian option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection067_Verify the color of option  Dutch changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Dutch |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Dutch option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection068_Verify the color of option  French changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| French |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the French option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection069_Verify the color of option  Greek changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Greek |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Greek option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection070_Verify the color of option  Hebrew changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Hebrew |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Hebrew option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection071_Verify the color of option  Hindi changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Hindi |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Hindi option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection072_Verify the color of option  Hungarian changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Hungarian |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Hungarian option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection073_Verify the color of option  Indonesian changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Indonesian |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Indonesian option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection074_Verify the color of option  English changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| English |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the English option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection075_Verify the color of option  Italian changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Italian |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Italian option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection076_Verify the color of option  Japanese changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Japanese |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Japanese option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection077_Verify the color of option  Korean changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Korean |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Korean option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection078_Verify the color of option  Lebanese changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Lebanese |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Lebanese option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection079_Verify the color of option Macedonian changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Macedonian |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Macedonian option should be "#14B24B"


	Scenario: AgentProposalForSell_LanguageSelection080_Verify the color of option Maltese changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Maltese |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Maltese option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection081_Verify the color of option Mandarin changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Mandarin |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Mandarin option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection082_Verify the color of option Persian changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Persian |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Persian option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection083_Verify the color of option Polish changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as 
	| Languages  |
	| Polish |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Polish option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection084_Verify the color of option Portuguese changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as 
	| Languages  |
	| Portuguese |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Portuguese option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection085_Verify the color of option Russian changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as 
	| Languages  |
	| Russian |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Russian option should be "#14B24B"


	Scenario: AgentProposalForSell_LanguageSelection086_Verify the color of option Serbian changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as 
	| Languages  |
	| Serbian |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Serbian option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection087_Verify the color of option Spanish changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as 
	| Languages  |
	| Spanish |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Spanish option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection088_Verify the color of option Srilankan changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as 
	| Languages  |
	| Srilankan |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Srilankan option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection089_Verify the color of option Tagalog changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as 
	| Languages  |
	| Tagalog |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Tagalog option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection090_Verify the color of option Thai changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Thai |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Thai option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection091_Verify the color of option Turkish changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Turkish |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Turkish option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection092_Verify the color of option Vietnamese changes on selection
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Vietnamese |
	And I move back to Languages Selection from Sale Authority Size section
	Then Color of the Vietnamese option should be "#14B24B"

	Scenario: AgentProposalForSell_LanguageSelection093_Verify that under Progress section, Languages circle should be displayed as Active
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions    |
	Then Languages circle should be displayed as active

	Scenario: AgentProposalForSell_SaleMethods036_Verify that under Progress section, Languages circle should be displayed as Checked on navigating to next section
	Given User is on Agent_Registration_Page
	And User navigates to Begin_Proposal after registering agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Both     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Language Selection after selecting sales methods as
	| SaleMethods |
	| Auctions        |
	And User clicks Next after selecting Languages as
	| Languages  |
	| Vietnamese |
	Then Languages circle should be displayed as Checked