Feature: PropertyDescriptionFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting valid Property Description.

@mytag
	Scenario: PropReg_PropertyDescription001_Verify the Question for Property Description on Registration Page.
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	Then Q "Which best describes your property?" should be displayed for Property Description section

	Scenario: PropReg_PropertyDescription002_Verify that Progress line indicates selection of Address
	Given  I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	Then Progress line indicates selection of Address

	Scenario: PropReg_PropertyDescription003_Verify that link for Moving Forward should be disabled by default
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	Then Link for Moving Forward is disabled

	Scenario: PropReg_PropertyDescription004_Verify that under Progress section, Agent should be displayed as activated.
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	Then Agent Details Progress should be displayed as activated

	Scenario: PropReg_PropertyDescription005_Verify that under Progress section, Agent Circle should not be displayed as Filled by default.
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	Then Agent Details Progress Circle should be displayed as not Filled

	Scenario: PropReg_PropertyDescription006_Verify that option "MY HOME" should be available for Property Description.
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	Then Option My Home  with text "MY HOME" should be displayed

	Scenario: PropReg_PropertyDescription007_Verify that option "VACANT PROPERTY" should be available for Property Description.
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	Then Option Vacant Property  with text "VACANT PROPERTY" should be displayed

	Scenario: PropReg_PropertyDescription008_Verify that option "TENANTED PROPERTY" should be available for Property Description.
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	Then Option Tenanted Property  with text "TENANTED PROPERTY" should be displayed

	Scenario: PropReg_PropertyDescription009_Verify that Specific Agencies question should be displayed when user selects "My Home" in Property Description.
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	When I Select option as "MyHome"
	Then  Specific Agencies question should be displayed

	Scenario: PropReg_PropertyDescription010_Verify that field for entering Leasing Details should be available when option Vacant Property is selected
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	When I Select option as "VacantProperty"
	Then Field for entering Leasing Details should be available

	Scenario: PropReg_PropertyDescription011_Verify that field for entering Leasing Details should be available when option Tenanted Property is selected
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	When I Select option as "TenantedProperty"
	Then Field for entering Leasing Details should be available

	Scenario: PropReg_PropertyDescription012_Verify that error is displayed for empty Leasing Details field
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	When I Select option as "TenantedProperty"
	And Click Next
	Then Error is displayed for empty Leasing Details field

	Scenario: PropReg_PropertyDescription013_Verify that Specific Agencies question should be displayed when user selects "Vacant Property" in Property Description and enters Leasing Details
	Given I am on Prop_Reg Page
	And I navigate to Property Description after entering details
	| Category | PropType | Beds | ApproxValue          | UnitAppNo | StreetNo  | Street    | Suburb    | State | PostCode |
	| Sell     | House    | One  | LessThanTwoHunderedK | Unit 2    | myStreet1 | Harlem St | Inglewood | NSW   | 3137     |
	When I Select leased option as "VacantProperty" and enter leased details as "Leasing Details"
	Then  Specific Agencies question should be displayed