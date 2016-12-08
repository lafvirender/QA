Feature: SaleMethodsFieldsVerification
	In order to submit the proposal for Vendors
	As an Agent
	I want to be able to select Sale Method

@mytag
	Scenario: AgentProposalForSell_SaleMethods001_Verify the Question for Sales Methods selection
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Question "What sales methods do you specialise in?" is displayed for Sales Methods selection

	Scenario: AgentProposalForSell_SaleMethods002_Verify that method "Private Sale" should be available on Registration Page.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Method Private Sale with text "PRIVATE SALE" should be available on Registration Page

	Scenario: AgentProposalForSell_SaleMethods003_Verify that method "Auction" should be available on Registration Page.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Method auctions with text "AUCTION" should be available on Registration Page

	Scenario: AgentProposalForSell_SaleMethods004_Verify that method "Off Market" should be available on Registration Page.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Method off market with text "OFF MARKET" should be available on Registration Page

	Scenario: AgentProposalForSell_SaleMethods005_Verify that method "Fixed Date" should be available on Registration Page.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Method Fixed Date with text "FIXED DATE" should be available on Registration Page

	Scenario: AgentProposalForSell_SaleMethods006_Verify that link for Moving Forward should be disabled by default
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Links for Moving Forward should be disabled

	
	Scenario: AgentProposalForSell_SaleMethods007_Verify that Languages selection question should be displayed when user selects "Private Sale" method.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| PrivateSale |
	And I Click on Next
	Then Languages selection question is displayed

	Scenario: AgentProposalForSell_SaleMethods008_Verify that Languages selection question should be displayed when user selects "Auctions" method.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| Auctions    |
	And I Click on Next
	Then Languages selection question is displayed

	Scenario: AgentProposalForSell_SaleMethods009_Verify that Languages selection question should be displayed when user selects "Off Market" method.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| OffMarket   |
	And I Click on Next
	Then Languages selection question is displayed
	
	Scenario: AgentProposalForSell_SaleMethods010_Verify that Languages selection question should be displayed when user selects "Fixed Date" method.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| FixedDate   |
	And I Click on Next
	Then Languages selection question is displayed

	Scenario: AgentProposalForSell_SaleMethods011_Verify that link for Moving forward is displayed as enabled when user moves back to Sale Method selection from Language selection.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| FixedDate   |
	And I Click on Next
	And I move back to Sale Method Selection from Language selection
	Then Link for moving forward is enabled

	Scenario: AgentProposalForSell_SaleMethods012_Verify that Language selection question is displayed on clicking Forward link on Sale Method selection section.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| FixedDate   |
	And I Click on Next
	And I move back to Sale Method Selection from Language selection
	When I Click on Forward link
	Then  Language selection question is displayed

	Scenario: AgentProposalForSell_SaleMethods013_Verify the color of option Private Sale when it is not selected
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Color of the Private Sale option should be "#00AEFF"

	Scenario: AgentProposalForSell_SaleMethods014_Verify the color of option Auctions when it is not selected
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Color of the Auctions option should be "#00AEFF"

	Scenario: AgentProposalForSell_SaleMethods015_Verify the color of option Off Market when it is not selected
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Color of the Off Market option should be "#00AEFF"
	
	Scenario: AgentProposalForSell_SaleMethods016_Verify the color of option Fixed Date when it is not selected
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Color of the Fixed Date option should be "#00AEFF"

	Scenario: AgentProposalForSell_SaleMethods017_Verify the color of option Private Sale changes on selection
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| PrivateSale |
	Then Color of the Private Sale option should be "#14B24B"

	Scenario: AgentProposalForSell_SaleMethods018_Verify the color of option Auctions changes on selection
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| Auctions    |
	Then Color of the Auctions option should be "#14B24B"

	Scenario: AgentProposalForSell_SaleMethods019_Verify the color of option Off Market changes on selection
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| OffMarket   |
	Then Color of the Off Market option should be "#14B24B"

	Scenario: AgentProposalForSell_SaleMethods020_Verify the color of option Fixed Date changes on selection
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| FixedDate   |
	Then Color of the Fixed Date option should be "#14B24B"

	Scenario: AgentProposalForSell_SaleMethods020_Verify the Language Selection Question is displayed after selecting all Sales Methods
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| FixedDate,OffMarket,PrivateSale,Auctions|
	And I Click on Next
	Then Languages selection question is displayed

	Scenario: AgentProposalForSell_SaleMethods021_Verify the color of option Fixed Date changes on deselection
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| FixedDate   |
	And I Select method as
	| SaleMethods |
	| FixedDate   |
	Then Color of the Fixed Date option should be "#00AEFF"

	Scenario: AgentProposalForSell_SaleMethods022_Verify that under Progress section, Label "METHODS" should be displayed for Sales Methods Selection progress.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Label "METHODS" should be displayed for Sales Methods Selection progress

	Scenario: AgentProposalForSell_SaleMethods023_Verify that under Progress section, METHODS circle should be displayed as Active
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then METHODS circle should be displayed as active

	Scenario: AgentProposalForSell_SaleMethods024_Verify that under Progress section, Label "LANGUAGES" should be displayed for Languages Selection progress.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Label "LANGUAGES" should be displayed for Languages Selection progress

	Scenario: AgentProposalForSell_SaleMethods025_Verify that under Progress section, Languages circle should be displayed as InActive
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Languages circle should be displayed as inactive

	Scenario: AgentProposalForSell_SaleMethods026_Verify that under Progress section, Label "AUTHORITY" should be displayed for Sale Authority Selection progress.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Label "AUTHORITY" should be displayed for Sale Authority Selection progress

	Scenario: AgentProposalForSell_SaleMethods027_Verify that under Progress section, Sale Authority circle should be displayed as InActive
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then  Sale Authority circle should be displayed as inactive

	Scenario: AgentProposalForSell_SaleMethods028_Verify that under Progress section, Label "TEAM SIZE" should be displayed for Sale Authority Selection progress.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Label "TEAM SIZE" should be displayed for Sale Team Selection progress

	Scenario: AgentProposalForSell_SaleMethods029_Verify that under Progress section, Team Size circle should be displayed as InActive
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then  Team Size circle should be displayed as inactive

	Scenario: AgentProposalForSell_SaleMethods030_Verify that under Progress section, Label "POSTCODES" should be displayed for PostCodes Selection progress.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Label "POSTCODES" should be displayed for PostCodes Selection progress

	Scenario: AgentProposalForSell_SaleMethods031_Verify that under Progress section, PostCodes circle should be displayed as InActive
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then  PostCodes circle should be displayed as inactive

	Scenario: AgentProposalForSell_SaleMethods032_Verify that under Progress section, Label "BIOGRAPHY" should be displayed for Biography Details Entry progress.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Label "BIOGRAPHY" should be displayed for Biography Details Entry progress

	Scenario: AgentProposalForSell_SaleMethods033_Verify that under Progress section, BIOGRAPHY circle should be displayed as InActive
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then  BIOGRAPHY circle should be displayed as inactive

	Scenario: AgentProposalForSell_SaleMethods034_Verify that under Progress section, Label "FEES" should be displayed for Fees Details Entry progress.
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Label "FEES" should be displayed for Fees Details Entry progress

	Scenario: AgentProposalForSell_SaleMethods035_Verify that under Progress section, Fees circle should be displayed as InActive
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then  Fees circle should be displayed as inactive

	Scenario: AgentProposalForSell_SaleMethods036_Verify that under Progress section, Methods circle should be displayed as Checked on navigating to Languages Selection
	Given User is on Agent_Reg Page
	And User navigates to Sale_Methods selection after registering Agent with details
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail |
	| Sales    | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When I Select method as
	| SaleMethods |
	| FixedDate,OffMarket,PrivateSale,Auctions|
	And I Click on Next
	Then Methods circle should be displayed as Checked