Feature: AgentInterestsFieldsVerification
	In order to submit the proposal
	As an Agent
	I want to be able to register after selecting valid Interests for Rentals, Sales or both.
	
	@mytag
	Scenario: AgentSignUp_Interests001_Verify the Question for Interests on Agent SignUp.
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Question "Do you cover sales, rentals or both?" should be displayed for Interests Selection

	Scenario: AgentSignUp_Interests002_Verify that category Sales with text "SALES" should be available on Interests Selection
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Category Sales with text "SALES" should be available on Interests Selection

	Scenario: AgentSignUp_Interests003_Verify that category Rentals with text "RENTALS" should be available on Interests Selection
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Category Rentals with text "RENTALS" should be available on Interests Selection

	Scenario: AgentSignUp_Interests004_Verify that category "BOTH" should be available on Agent Interests Selection
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Category Both with text "BOTH" should be available on Interests Selection

	Scenario: AgentSignUp_Interests005_Verify that under Progress section, About You Circle should not be displayed as Filled by default.
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then About You Progress Circle should be displayed as not filled

	Scenario: AgentSignUp_Interests006_Verify that under Progress section, Label "ABOUT YOU" should be displayed for User Details filling progress.
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Label "ABOUT YOU" should be displayed for User Details filling progress

	Scenario: AgentSignUp_Interests007_Verify that under Progress section, no progress should be displayed for Agency by default.
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then No progress should be displayed for Agency by default

	Scenario: AgentSignUp_Interests008_Verify that under Progress section, Label "AGENCY" should be displayed for Agency Details filling progress.
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Label "AGENCY" should be displayed for Agency Details filling progress

	Scenario: AgentSignUp_Interests009_Verify that under Progress section, no progress should be displayed for Key Info by default.
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then No progress should be displayed for Key Info by default

	Scenario: AgentSignUp_Interests010_Verify that under Progress section, Label "KEY INFO" should be displayed for key information filling progress
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Label "KEY INFO" should be displayed for key information filling progress

	Scenario: AgentSignUp_Interests011_Verify that under Progress section, no progress should be displayed for Terms and Conditions by default.
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then No progress should be displayed for Terms and Conditions by default

	Scenario: AgentSignUp_Interests012_Verify that under Progress section, Label "T&CS" should be displayed for Terms and Conditions filling progress
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Label "T&CS" should be displayed for Terms and Conditions filling progress

	Scenario: AgentSignUp_Interests013_Verify that Basic Details Entry question should be displayed when user selects "Sales" Category.
	Given User is on Agent SignUp Page
	And User navigates to Basic Details Entry after selecting option
	| Interest |
	| Sales    |
	Then Basic Details Entry question should be displayed

	Scenario: AgentSignUp_Interests014_Verify that Basic Details Entry question should be displayed when user selects "Rentals" Category.
	Given User is on Agent SignUp Page
	And User navigates to Basic Details Entry after selecting option
	| Interest |
	| Rentals     |
	Then Basic Details Entry question should be displayed

	Scenario: AgentSignUp_Interests015_Verify that Basic Details Entry question should be displayed when user selects "Both" Category.
	Given User is on Agent SignUp Page
	And User navigates to Basic Details Entry after selecting option
	| Interest |
	| Both     |
	Then Basic Details Entry question should be displayed

	Scenario: AgentSignUp_Interests016_Verify that link for Moving forward is displayed as enabled when user moves back to Interest Selection from Basic Details Entry section.
	Given User is on Agent SignUp Page
	And User navigates to Basic Details Entry after selecting option
	| Interest |
	| Both     |
	And I move back to Interest Selection
	Then Forward link is enabled

	Scenario: AgentSignUp_Interests017_Verify that Basic Details entry section is displayed on clicking Forward link on Interest Selection
	Given User is on Agent SignUp Page
	And User navigates to Basic Details Entry after selecting option
	| Interest |
	| Both     |
	And User move back to Interest Selection
	When User click Forward Link
	Then Basic Details Entry question should be displayed

	Scenario: AgentSignUp_Interests018_Verify the color of option Sales when it is not selected
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Color of the Sales option on Interest Selection should be "#00AEFF"

	Scenario: AgentSignUp_Interests019_Verify that color of the option Sales changes on selection.
	Given User is on Agent SignUp Page
	And User navigates to Basic Details Entry after selecting option
	| Interest |
	| Sales     |
	And User move back to Interest Selection
	Then Color of the Sales option on Interest Selection should be "#14B24B"

	Scenario: AgentSignUp_Interests020_Verify the color of option Rentals when it is not selected
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Color of the Rent option on Interest Selection should be "#00AEFF"

	Scenario: AgentSignUp_Interests021_Verify that color of the option Rent changes on selection.
	Given User is on Agent SignUp Page
	And User navigates to Basic Details Entry after selecting option
	| Interest |
	| Rentals     |
	And User move back to Interest Selection
	Then Color of the Rent option on Interest Selection should be "#14B24B"

	Scenario: AgentSignUp_Interests020_Verify the color of option Both when it is not selected
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then Color of the Both option on Interest Selection should be "#00AEFF"

	Scenario: AgentSignUp_Interests021_Verify that color of the option Both changes on selection.
	Given User is on Agent SignUp Page
	And User navigates to Basic Details Entry after selecting option
	| Interest |
	| Both     |
	And User move back to Interest Selection
	Then Color of the Both option on Interest Selection should be "#14B24B"

	Scenario: AgentSignUp_Interests022_Verify that Forward link should be disabled when user comes on Interest Selection for the first time.
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then  Forward link should be disabled

	Scenario: AgentSignUp_Interests023_Verify that link for moving back should be enabled when user comes on Interest Selection for the first time.
	Given User is on Agent SignUp Page
	And User navigates to Interests Selection
	Then  Link for moving Back should be enabled

	Scenario: AgentSignUp_Interests024_Verify that under Progress section, About You Circle should be displayed as Filled when user selects an Interest
	Given User is on Agent SignUp Page
	And User navigates to Basic Details Entry after selecting option
	| Interest |
	| Both     |
	Then About You Progress Circle should be displayed as filled