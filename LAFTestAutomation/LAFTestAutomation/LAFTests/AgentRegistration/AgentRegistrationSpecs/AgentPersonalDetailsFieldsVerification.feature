Feature: AgentPersonalDetailsFieldsVerification
	In order to submit the proposal
	As an Agent
	I want to be able to register after entering valid values in Agent's Personal Details section

@mytag
	Scenario: AgentSignUp_AgentPersonalDetails001_Verify that link for Moving Forward should be disabled by default
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	Then Link for moving forward is not enabled

	Scenario: AgentSignUp_AgentPersonalDetails002_Verify that Heading "About You" should be displayed for About you section
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	Then Question "About you" should be displayed for About you section

	Scenario: AgentSignUp_AgentPersonalDetails003_Verify that Progress line for Agent Details is not filled by default.
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	Then Progress line for Agent Details is not filled by default

	Scenario: AgentSignUp_AgentPersonalDetails004_Verify that error is displayed for empty First Name field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		|                | Last          | 0412213456 | 0412213456  | randomize    | Sales Consultant |
	Then Error "Your first name" should be displayed for empty First Name field

	Scenario: AgentSignUp_AgentPersonalDetails005_Verify that error is displayed for empty Last Name field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| First          |               | 0412213456 | 0412213456  | randomize   | Sales Consultant |
	Then Error  "Your last name" should be displayed for empty Last Name field

	Scenario: AgentSignUp_AgentPersonalDetails006_Verify that error is displayed for empty Phone Number field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| First          | Last          |            | 0412213456  | randomize   | Sales Consultant |
	Then Error "Your phone number" should be displayed for empty Phone Number field

	Scenario: AgentSignUp_AgentPersonalDetails007_Verify that error is displayed for empty Mobile Number field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
	| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| First          | Last          | 0412213456 |             | randomize   | Sales Consultant |
	Then Error "Your mobile phone number" should be displayed for empty Mobile Number field

	Scenario: AgentSignUp_AgentPersonalDetails008_Verify that error is displayed for empty EmailAddress field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| First          | Last          | 0412213456 | 0412213456  |            | Sales Consultant |
	Then Error "Your email address" should be displayed for empty Email Address field

	Scenario: AgentSignUp_AgentPersonalDetails009_Verify that error is displayed for empty Position field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
	| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition |
	| First          | Last          | 0412213456 | 0412213456  | randomize |               |
	Then Error "Your position" should be displayed for empty Position field

	Scenario: AgentSignUp_AgentPersonalDetails010_Verify that Agency Details section is displayed after entering details in About You section
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
	| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	Then Agency Details section is displayed

	Scenario: AgentSignUp_AgentPersonalDetails011_Verify that error is displayed when Alphabets are entered in Phone Number field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| First          | Last          | ABCDEFGHS  | 0412213456  | randomize    | Sales Consultant |
	Then Error should be displayed for Phone Number field

	Scenario: AgentSignUp_AgentPersonalDetails012_Verify that error is displayed when Alphabets are entered in Mobile Number field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
	| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| First          | Last          | 0412213456 | ABCDEFGHS   | randomize    | Sales Consultant |
	Then Error should be displayed for Mobile Number field

	Scenario: AgentSignUp_AgentPersonalDetails013_Verify that error is displayed for invalid EmailAddress in Email Address field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| First          | Last          | 0412213456 | 0412213456  | abcde      | Sales Consultant |
	Then Error "Your email address using correct format" should be displayed for empty Email Address field

	Scenario: AgentSignUp_AgentPersonalDetails014_Verify that error message is displayed on entering more than 50 characters in First Name field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName                                      | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| this is a very very very loooooooooooooooong string | Last          | 0412213456 | 0412213456  | randomize   | Sales Consultant |
	Then Error "Your first name" should be displayed for empty First Name field

	Scenario: AgentSignUp_AgentPersonalDetails015_Verify that error message is displayed on entering more than 50 characters in Last Name field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName                                       | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| First          | this is a very very very loooooooooooooooong string | 0412213456 | 0412213456  | randomize   | Sales Consultant |
	Then Error  "Your last name" should be displayed for empty Last Name field

	Scenario: AgentSignUp_AgentPersonalDetails014_Verify that Agency Details section is displayed on entering 50 characters string in First Name field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName                                     | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| this is a very very very looooooooooooooong string | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant |
	Then Agency Details section is displayed

	Scenario: AgentSignUp_AgentPersonalDetails015_Verify that Agency Details section is displayed on entering 50 characters string in Last Name field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName                                      | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| First          | this is a very very very looooooooooooooong string | 0412213456 | 0412213456  | randomize  | Sales Consultant |
	Then Agency Details section is displayed

	Scenario: AgentSignUp_AgentPersonalDetails016_Verify that error is displayed on entering more than 99 characters in Email field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail                                                                                            | AgentPosition    |
		| First          | Last          | 0412213456 | 0412213456  | thisisaveryveryveryloooooooooooooooooooooooooooooongstring@testing50CharacterStringForLAFAgent.com.au | Sales Consultant |
	Then Error "Your email address" should be displayed for invalid Email Address

	Scenario: AgentSignUp_AgentPersonalDetails017_Verify that Agency Details section is displayed on entering 99 characters in Email field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail                                                                                            | AgentPosition    |
		| First          | Last          | 0412213456 | 0412213456  | thisisaveryveryverylooooooooooooooooooooooooooooongstring@testing50CharacterStringForLAFAgent.com.au | Sales Consultant |
	Then Agency Details section is displayed

	Scenario: AgentSignUp_AgentPersonalDetails018_Verify that error message is displayed on entering invalid characters in First Name field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| <a             | Last          | 0412213456 | 0412213456  | randomize  | Sales Consultant |
	Then Error "Your first name" should be displayed for empty First Name field

	Scenario: AgentSignUp_AgentPersonalDetails019_Verify that error message is displayed on entering invalid characters in Last Name field
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
		| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
		| First          | <a            | 0412213456 | 0412213456  | randomize  | Sales Consultant |
	Then Error  "Your last name" should be displayed for empty Last Name field

	Scenario: AgentSignUp_AgentPersonalDetails020_Verify that under Progress section, Agency circle should be displayed as activated by default.
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	Then Agency Circle under Progress bar should be displayed as activated


	Scenario: AgentSignUp_AgentPersonalDetails021_Verify options under Choose Job Title drop down
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	Then Below options should be available under Choose Job Title drop down
		| AgentPosition                |
		| Administration Manager       |
		| Assistant Property Manager   |
		| Assistant to the Principal   |
		| Business Development Manager |
		| Director                     |
		| Investor Services Manager    |
		| Licensee                     |
		| Marketing Co-ordinator       |
		| Office Manager               |
		| Principal                    |
		| Property Manager             |
		| Receptionist                 |
		| Rural Lifestyle Specialist   |
		| Sales Assistant              |
		| Sales Consultant             |
		| Sales Executive              |
		| Sales Manager                |
		| Senior Property Manager      |
		| Senior Sales Executive       |
		| N/A                          |


	Scenario: AgentSignUp_AgentPersonalDetails022_Verify that Progress Line for Agent Details is displayed as filled and About You circle  as checked after entering details in About You section and navigating to next section
	Given User is on Agent_SignUp Page
	And User navigates to About You section after selecting
	| Interest |
	| Both     |
	When I click Next after entering details as
	| AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    |
	| First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant |
	Then Progress Line for Agent Details is displayed as filled and About You circle  is displayed as checked 

