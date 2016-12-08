Feature: AgentQualityFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting valid option for Agent Quality

@mytag
Scenario: PropReg_AgentQuality001_Verify the Question for Agent Quality
	Given I am on Prop_Reg_Page
	And I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Q "What's most important to you in an agent?" should be displayed for Agent Quality selection 

Scenario: PropReg_AgentQuality002_Verify that option "ABILITY TO GET THE BEST OUTCOME" should be available
	Given I am on Prop_Reg_Page
	And I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Option Ability to get the best outcome with text "ABILITY TO GET THE BEST OUTCOME" should be available

Scenario: PropReg_AgentQuality003_Verify that option "LOCAL KNOWLEDGE AND EXPERTISE" should be available
	Given I am on Prop_Reg_Page
	And I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Option Local knowledge and expertise with text "LOCAL KNOWLEDGE AND EXPERTISE" should be available

Scenario: PropReg_AgentQuality004_Verify that option "TRUSTWORTHINESS AND RELIABILITY" should be available
	Given I am on Prop_Reg_Page
	And I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Option Trustworthiness and reliability with text "TRUSTWORTHINESS AND RELIABILITY" should be available

Scenario: PropReg_AgentQuality005_Verify that option "PATIENCE AND UNDERSTANDING" should be available
	Given I am on Prop_Reg_Page
	And I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Option Patience and understanding with text "PATIENCE AND UNDERSTANDING" should be available

Scenario: PropReg_AgentQuality006_Verify that link for Moving Forward should be disabled by default
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Moving Forward Link is displayed disabled

	Scenario: PropReg_AgentQuality007_Verify that Specific Agencies question should be displayed when user selects "ABILITY TO GET THE BEST OUTCOME" option
	Given  I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "AbilityToGetBestOutcome"
	Then Specific Agencies question is displayed
	
	Scenario: PropReg_AgentQuality008_Verify that Specific Agencies question should be displayed when user selects "TRUSTWORTHINESS AND RELIABILITY" option
	Given  I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "LocalKnowledegeAndExpertise"
	Then Specific Agencies question is displayed

	Scenario: PropReg_AgentQuality009_Verify that Specific Agencies question should be displayed when user selects "LOCAL KNOWLEDGE AND EXPERTISE" option
	Given  I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "TrustworthinessAndReliability"
	Then Specific Agencies question is displayed

	Scenario: PropReg_AgentQuality010_Verify that Specific Agencies question should be displayed when user selects "PATIENCE AND UNDERSTANDING" option
	Given  I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "PatienceAndUnderstanding"
	Then Specific Agencies question is displayed

	Scenario: PropReg_AgentQuality011_Verify the color of option AbilityToGetBestOutcome when it is not selected
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Color of the AbilityToGetBestOutcome option should be "#00AEFF"

	Scenario: PropReg_AgentQuality012_Verify that color of the option AbilityToGetBestOutcome changes on selection.
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "AbilityToGetBestOutcome"
	And I move back to Agent Quality  Question
	Then Color of the AbilityToGetBestOutcome option should be "#14B24B"

	Scenario: PropReg_AgentQuality013_Verify the color of option LocalKnowledegeAndExpertise when it is not selected
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Color of the LocalKnowledegeAndExpertise option should be "#00AEFF"

	Scenario: PropReg_AgentQuality014_Verify that color of the option LocalKnowledegeAndExpertise changes on selection.
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "LocalKnowledegeAndExpertise"
	And I move back to Agent Quality  Question
	Then Color of the LocalKnowledegeAndExpertise option should be "#14B24B"

	Scenario: PropReg_AgentQuality015_Verify the color of option TrustworthinessAndReliability when it is not selected
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Color of the TrustworthinessAndReliability option should be "#00AEFF"

	Scenario: PropReg_AgentQuality016_Verify that color of the option TrustworthinessAndReliability changes on selection.
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "TrustworthinessAndReliability"
	And I move back to Agent Quality  Question
	Then Color of the TrustworthinessAndReliability option should be "#14B24B"

	Scenario: PropReg_AgentQuality017_Verify the color of option PatienceAndUnderstanding when it is not selected
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	Then Color of the PatienceAndUnderstanding option should be "#00AEFF"

	Scenario: PropReg_AgentQuality018_Verify that color of the option PatienceAndUnderstanding changes on selection.
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "PatienceAndUnderstanding"
	And I move back to Agent Quality  Question
	Then Color of the PatienceAndUnderstanding option should be "#14B24B"

	Scenario: PropReg_AgentQuality019_Verify that link for Moving forward is displayed as enabled when user moves back to Agent Quality selection from Specific Agencies selection
	Given I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "PatienceAndUnderstanding"
	And I move back to Agent Quality  Question
	Then Link for Moving forward is enabled

	Scenario: PropReg_AgentQuality020_Verify that Specific Agencies question is displayed on clicking Forward link
	Given  I am on Prop_Reg_Page
	And  I navigate to Agent Quality selection section after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode | Leased | LeasingDetails |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     | MyHome |                |
	When I Select agent quality option as "PatienceAndUnderstanding"
	And I move back to Agent Quality  Question
	And I click on Forward 
	Then Specific Agencies question is displayed