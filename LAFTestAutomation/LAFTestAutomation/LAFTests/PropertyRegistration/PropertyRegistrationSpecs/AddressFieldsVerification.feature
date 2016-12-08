Feature: AddressFieldsVerification
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting valid values in Address Fields.

@mytag
	Scenario: PropReg_Address001_Verify the Question for Address section for a House Property Type with Listing Category as Sell.
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	Then Q "What is the address of the house you are looking to sell?" should be displayed for Address

	Scenario: PropReg_Address002_Verify that Progress line indicates selection of Property Value.
	Given  I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	Then Selection of Property Value is displayed in Progress section

	Scenario: PropReg_Address003_Verify that option for entering the address manually should be available.
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	Then Option for entering the address manually with text "Enter your address manually" should be displayed

	Scenario: PropReg_Address004_Verify that field for searching address should be available
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	Then Search field should be available for searching address

	Scenario: PropReg_Address005_Verify that Next button is available 
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	Then Next button is available 

	Scenario: PropReg_Address006_Verify that link for Moving Forward should be disabled by default
	Given  I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	Then Link for Moving Forward should not be enabled

	Scenario: PropReg_Address007_Verify that on selecting the option for entering the address manually, UnitNo, StreetNo, Street, Suburb, State, and PostCode field should be displayed
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When I select option for entering address manually
	Then Fields Unit/App No., StreetNo., Street, Suburb, State and PostCode should be displayed

	Scenario: PropReg_Address008_Verify that error is displayed for empty Address Search field
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When I Click Next
	Then Error is displayed for empty Address Search field

	Scenario: PropReg_Address009_Verify that error is displayed for empty Street No field
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When Enter values in Address Fields as
		| UnitAppNo | StreetNo | Street | Suburb | State | PostCode |
		| Unit1      |          | Street | Suburb | VIC   | 3081     |
	Then Error is displayed for empty Street No field

	Scenario: PropReg_Address010_Verify that error is displayed for empty Street field
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When Enter values in Address Fields as
		| UnitAppNo | StreetNo  | Street | Suburb | State | PostCode |
		| Unit1      | Street No |        | Suburb | VIC   | 3081     |
	Then Error is displayed for empty Street field

	Scenario: PropReg_Address011_Verify that error is displayed for empty Suburb field
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When Enter values in Address Fields as
		| UnitAppNo | StreetNo  | Street | Suburb | State | PostCode |
		| Unit1      | Street No | Street |        | VIC   | 3081     |
	Then Error is displayed for empty Suburb field

	Scenario: PropReg_Address012_Verify that error is displayed for empty State field
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When Enter values in Address Fields as
		| UnitAppNo | StreetNo  | Street | Suburb | State | PostCode |
		| Unit1      | Street No | Street | Suburb |       | 3081     |
	Then Error is displayed for empty State field

	Scenario: PropReg_Address013_Verify that error is displayed for empty PostCode field
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When Enter values in Address Fields as
		| UnitAppNo | StreetNo  | Street | Suburb | State | PostCode |
		| Unit1      | Street No | Street | Suburb | VIC   |          |
	Then Error is displayed for empty PostCode field

	Scenario: PropReg_Address014_Verify that error is displayed for empty Unit_AppNo field for Unit property type
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | Unit     | One  | LessThanTwoHunderedK |
	When Enter values in Address Fields as
		| UnitAppNo | StreetNo  | Street | Suburb | State | PostCode |
		|            | Street No | Street | Suburb | VIC   | 3028     |
	Then Error is displayed for empty Unit_AppNo field

	Scenario: PropReg_Address015_Verify that error is displayed for empty Unit_AppNo field for Apartment property type
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType  | Beds | ApproxValue          |
	| Sell     | Apartment | One  | LessThanTwoHunderedK |
	When Enter values in Address Fields as
		| Unit_AppNo | StreetNo  | Street | Suburb | State | PostCode |
		|            | Street No | Street | Suburb | VIC   | 3028     |
	Then Error is displayed for empty Unit_AppNo field

	Scenario: PropReg_Address016_Verify that error is not displayed for empty Unit_AppNo field for property type other than Unit or Apartment
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When Enter values in Address Fields as
		| UnitAppNo | StreetNo  | Street | Suburb | State | PostCode |
		|            | Street No | Street | Suburb | VIC   | 3028     |
	Then Property Description Question is Displayed

	Scenario: PropReg_Address017_Verify that Progress line indicates entry of Address fields
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When Enter values in Address Fields as
		| UnitAppNo | StreetNo  | Street | Suburb | State | PostCode |
		|            | Street No | Street | Suburb | VIC   | 3028     |
	And I move back to Address section from Property Description section
	Then Progress line indicates entry of Address fields

	Scenario: PropReg_Address018_Verify that addresses in the address list should start with searched keyword
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When I enter search keyword as "A"
	Then Addresses in the address list should start with searched keyword "A"

	Scenario: PropReg_Address019_Verify that correct Street No should be populated for selected address
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When I enter search keyword as "A"
	And I select "1" Option in the populated Address List
	Then Correct Street No should be populated for selected address

	Scenario: PropReg_Address020_Verify that correct Street should be populated for selected address
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When I enter search keyword as "A"
	And I select "1" Option in the populated Address List
	Then Correct Street should be populated for selected address

	Scenario: PropReg_Address021_Verify that correct Suburb should be populated for selected address
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When I enter search keyword as "A"
	And I select "1" Option in the populated Address List
	Then Correct Suburb should be populated for selected address

	Scenario: PropReg_Address022_Verify that correct State should be populated for selected address
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When I enter search keyword as "A"
	And I select "1" Option in the populated Address List
	Then Correct State should be populated for selected address

	Scenario: PropReg_Address023_Verify that correct PostCode should be populated for selected address
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | House    | One  | LessThanTwoHunderedK |
	When I enter search keyword as "A"
	And I select "1" Option in the populated Address List
	Then Correct PostCode should be populated for selected address

	Scenario: PropReg_Address024_Verify the Question for Address section for a Unit Property Type with Listing Category as Sell.
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue          |
	| Sell     | Unit     | One  | LessThanTwoHunderedK |
	Then Q "What is the address of the unit you are looking to sell?" should be displayed for Address

	Scenario: PropReg_Address025_Verify the Question for Address section for a Land Property Type with Listing Category as Sell.
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue |
	| Sell     | Land     |      | LessThanTwoHunderedK |
	Then Q "What is the address of the land you are looking to sell?" should be displayed for Address

	Scenario: PropReg_Address026_Verify the Question for Address section for a Apartment Property Type with Listing Category as Sell.
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType  | Beds | ApproxValue          |
	| Sell     | Apartment | One  | LessThanTwoHunderedK |
	Then Q "What is the address of the apartment you are looking to sell?" should be displayed for Address

	Scenario: PropReg_Address027_Verify the Question for Address section for a Townhouse Property Type with Listing Category as Sell.
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType  | Beds | ApproxValue          |
	| Sell     | Townhouse | One  | LessThanTwoHunderedK |
	Then Q "What is the address of the townhouse you are looking to sell?" should be displayed for Address

	Scenario: PropReg_Address028_Verify the Question for Address section for a Villa Property Type with Listing Category as Sell.
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType  | Beds | ApproxValue          |
	| Sell     | Villa | One  | LessThanTwoHunderedK |
	Then Q "What is the address of the villa you are looking to sell?" should be displayed for Address

	Scenario: PropReg_Address029_Verify the Question for Address section for a Property Type with Listing Category as Rent.
	Given I am on Prop_Registration Page
	And I navigate to Address Section after entering details
	| Category | PropType | Beds | ApproxValue         |
	| Rent     | Villa    | One  | LessThanTwoHundered |
	Then Q "What is the address of the villa you are looking to rent?" should be displayed for Address

