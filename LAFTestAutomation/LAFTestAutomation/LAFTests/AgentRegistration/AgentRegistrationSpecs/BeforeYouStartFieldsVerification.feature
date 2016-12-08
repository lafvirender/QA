Feature: BeforeYouStartFieldsVerification
	In order to submit the proposal
	As an Agent
	I want to be able to start the registration
	
	@automated
	Scenario: AgentSignUp_BeforeStart001_Verify the heading on Before you start slide
	Given User navigates to Agent SignUp Page
	Then Heading "Before you begin" should be displayed

	@automated
	Scenario: AgentSignUp_BeforeStart002_Verify that user navigates to Interest selection on clicking Next
	Given User navigates to Agent SignUp Page
	And User clicks on Next button
	Then Interest selection section should be displayed
