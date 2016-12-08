Feature: TermsAndConditionsFieldsVerification
	In order to submit the proposal
	As an Agent
	I want to be able to accept the Terms and Conditions
	
	@mytag
	Scenario: AgentSignUp_Terms001_Verify the heading on Terms And Conditions section
	Given User navigates to AgentSignUp Page
	And User navigates to Terms And Conditions section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Text "Terms and conditions" is displayed

	Scenario: AgentSignUp_Terms002_Verify that user navigates to Agent Welcome section after accepting Terms and Conditions
	Given User navigates to AgentSignUp Page
	And User navigates to Terms And Conditions section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	And User Accepts the Terms and Conditions
	Then Agent Welcome section should be displayed

	Scenario: AgentSignUp_Terms003_Verify that Submit button is disabled by default on Terms and Conditions
	Given User navigates to AgentSignUp Page
	And User navigates to Terms And Conditions section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then Submit button is displayed as Disabled

	Scenario: AgentSignUp_Terms004_Verify that Submit button is enabled after reading and clicking the acceptance checkbox on terms and condition
	Given User navigates to AgentSignUp Page
	And User navigates to Terms And Conditions section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	And User reads and checks the acceptance checkbox on terms and conditions
	Then Submit button is Enabled after reading terms and condition

	Scenario: AgentSignUp_Terms005_Verify that error is displayed on clicking Submit button without selecting Acceptance checkbox
	Given User navigates to AgentSignUp Page
	And User navigates to Terms And Conditions section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	And User reads and checks the acceptance checkbox on terms and conditions
	And User deselects acceptance checkbox on terms and conditions
	When User clicks Submit
	Then Error "Please tick the box to acknowledge that you accept the terms and conditions and that your proposal will be automatically submitted to suitable homeowners on your behalf." is displayed

	Scenario: AgentSignUp_Terms006_Verify that under Progress section, T&Cs circle should not be displayed as Filled by default.
	Given User navigates to AgentSignUp Page
	And User navigates to Terms And Conditions section after entering details as
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals  | First          | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	Then T&Cs Circle should be displayed as not filled