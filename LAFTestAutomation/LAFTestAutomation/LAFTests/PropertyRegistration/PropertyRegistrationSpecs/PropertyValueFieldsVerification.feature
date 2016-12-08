Feature: PropertyValueFieldsVerificationSteps
	In order to register property for Sell or Rent
	As a User
	I want to be able to proceed after selecting Property Value

@mytag
	Scenario: PropReg_PropValue001_Verify the Question for Property Value options on Registration Page.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Q "What is the approximate value of your property?" should be displayed for Property Value selection options

	Scenario: PropReg_PropValue002_Verify that Progress line indicates selection of Bedrooms
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Progress line shows the selection of Bedrooms

	Scenario: PropReg_PropValue003_Verify that link for Moving Forward should be disabled by default
	Given I am on Property_Registration Page
 	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Moving Forward Link is displayed as disabled

	Scenario: PropReg_PropValue004_Verify that Address question should be displayed when user selects "Less Than $200K" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "LessThanTwoHunderedK"
	Then Address question should be displayed

	Scenario: PropReg_PropValue005_Verify that Progress line indicates selection of Property Value
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "LessThanTwoHunderedK"
	And I move back to Property Value Selection from Address
	Then Progress line shows the selection of Property Value

	Scenario: PropReg_PropValue006_Verify that Address question should be displayed when user selects "$200K To $400K" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "TwoHunderedKToFourHunderedK"
	Then Address question should be displayed

	Scenario: PropReg_PropValue007_Verify that Address question should be displayed when user selects "$400K To $600K" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "FourHunderedKToSixHunderedK"
	Then Address question should be displayed

	Scenario: PropReg_PropValue008_Verify that Address question should be displayed when user selects "$600K To $800K" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "SixHunderedKToEightHunderedK"
	Then Address question should be displayed

	Scenario: PropReg_PropValue009_Verify that Address question should be displayed when user selects "$800K To $1M" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "EightHunderedKToOneMillion"
	Then Address question should be displayed

	Scenario: PropReg_PropValue010_Verify that Address question should be displayed when user selects "$1M To $1.5M" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "OneMillionToOneAndHalfMillion"
	Then Address question should be displayed

	Scenario: PropReg_PropValue011_Verify that Address question should be displayed when user selects "$1.5M To $2M" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "OneAndHalfMillionToTwoMillion"
	Then Address question should be displayed

	Scenario: PropReg_PropValue012_Verify that Address question should be displayed when user selects "$2M+" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "MoreThanTwoMillion"
	Then Address question should be displayed

	Scenario: PropReg_PropValue013_Verify that Address question should be displayed when user selects "Less Than $200" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "LessThanTwoHundered"
	Then Address question should be displayed

	Scenario: PropReg_PropValue014_Verify that Address question should be displayed when user selects "$200 Than $300" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "TwoHunderedToThreeHundered"
	Then Address question should be displayed

	Scenario: PropReg_PropValue015_Verify that Address question should be displayed when user selects "$300 Than $400" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "ThreeHunderedToFourHundered"
	Then Address question should be displayed

	Scenario: PropReg_PropValue016_Verify that Address question should be displayed when user selects "$400 Than $500" value.
	Given I am on Property_Registration Page
 	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "FourHunderedToFiveHundered"
	Then Address question should be displayed

	Scenario: PropReg_PropValue017_Verify that Address question should be displayed when user selects "$500 Than $700" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "FiveHunderedToSevenHundered"
	Then Address question should be displayed

	Scenario: PropReg_PropValue018_Verify that Address question should be displayed when user selects "$700 Than $1000" value.
	Given I am on Property_Registration Page
  	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "SevenHunderedToOneThousand"
	Then Address question should be displayed

	Scenario: PropReg_PropValue019_Verify that Address question should be displayed when user selects "$1000 Than $1500" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "OneThousandToFifteenHundered"
	Then Address question should be displayed

	Scenario: PropReg_PropValue020_Verify that Address question should be displayed when user selects "$1500+" value.
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "MoreThanFifteenHundered"
	Then Address question should be displayed

	Scenario: PropReg_PropValue021_Verify the color of option for "Less Than $200K" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Color of the Less Than TwoHundered K value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue022_Verify that color of the option  for "Less Than $200K" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "LessThanTwoHunderedK"
	And I move back to Property Value Selection from Address
	Then Color of the Less Than TwoHundered K value option should be "#16B24D"

	Scenario: PropReg_PropValue023_Verify the color of option for "$200K Than $400K" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Color of the TwoHunderedK To FourHunderedK value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue024_Verify that color of the option  for "$200K Than $400K" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "TwoHunderedKToFourHunderedK"
	And I move back to Property Value Selection from Address
	Then Color of the TwoHunderedK To FourHunderedK value option should be "#16B24D"

	Scenario: PropReg_PropValue025_Verify the color of option for "$400K Than $600K" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Color of the FourHunderedK To SixHunderedK value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue026_Verify that color of the option  for "$400K Than $600K" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "FourHunderedKToSixHunderedK"
	And I move back to Property Value Selection from Address
	Then Color of the FourHunderedK To SixHunderedK value option should be "#16B24D"

	Scenario: PropReg_PropValue027_Verify the color of option for "$600K Than $800K" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Color of the SixHunderedK To EightHunderedK value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue028_Verify that color of the option  for "$600K Than $800K" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "SixHunderedKToEightHunderedK"
	And I move back to Property Value Selection from Address
	Then Color of the SixHunderedK To EightHunderedK value option should be "#16B24D"

	Scenario: PropReg_PropValue029_Verify the color of option for "$800K Than $1M" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Color of the EightHunderedK To OneMillion value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue030_Verify that color of the option  for "$800K Than $1M" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "EightHunderedKToOneMillion"
	And I move back to Property Value Selection from Address
	Then Color of the EightHunderedK To OneMillion value option should be "#16B24D"

	Scenario: PropReg_PropValue031_Verify the color of option for "$1M Than $1.5M" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Color of the OneMillion To OneAndHalfMillion value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue032_Verify that color of the option  for "$1M Than $1.5M" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "OneMillionToOneAndHalfMillion"
	And I move back to Property Value Selection from Address
	Then Color of the OneMillion To OneAndHalfMillion value option should be "#16B24D"

    Scenario: PropReg_PropValue033_Verify the color of option for "$1.5M Than $2M" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Color of the OneAndHalfMillion To TwoMillion value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue034_Verify that color of the option  for "$1.5M Than $2M" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "OneAndHalfMillionToTwoMillion"
	And I move back to Property Value Selection from Address
	Then Color of the OneAndHalfMillion To TwoMillion value option should be "#16B24D"

    Scenario: PropReg_PropValue035_Verify the color of option for "$2M+" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	Then Color of the MoreThanTwoMillion value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue036_Verify that color of the option  for "$2M+" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Sell     | House    | One  |
	When I Select value as "MoreThanTwoMillion"
	And I move back to Property Value Selection from Address
	Then Color of the MoreThanTwoMillion value option should be "#16B24D"

	Scenario: PropReg_PropValue037_Verify the color of option for "Less Than 200" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	Then Color of the Less Than TwoHundered value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue038_Verify that color of the option  for "Less Than 200" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "LessThanTwoHundered"
	And I move back to Property Value Selection from Address
	Then Color of the Less Than TwoHundered value option should be "#16B24D"

	Scenario: PropReg_PropValue039_Verify the color of option for "200 To 300" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	Then Color of the TwoHundered To ThreeHundered value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue040_Verify that color of the option  for "200 To 300" value on selection
	Given I am on Property_Registration Page
 	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "TwoHunderedToThreeHundered"
	And I move back to Property Value Selection from Address
	Then Color of the TwoHundered To ThreeHundered value option should be "#16B24D"

	Scenario: PropReg_PropValue041_Verify the color of option for "300 To 400" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	Then Color of the ThreeHundered To FourHundered value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue042_Verify that color of the option  for "300 To 400" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "ThreeHunderedToFourHundered"
	And I move back to Property Value Selection from Address
	Then Color of the ThreeHundered To FourHundered value option should be "#16B24D"

	Scenario: PropReg_PropValue043_Verify the color of option for "400 To 500" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	Then Color of the FourHundered To FiveHundered value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue044_Verify that color of the option  for "400 To 500" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "FourHunderedToFiveHundered"
	And I move back to Property Value Selection from Address
	Then Color of the FourHundered To FiveHundered value option should be "#16B24D"

	Scenario: PropReg_PropValue045_Verify the color of option for "500 To 700" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	Then Color of the FiveHundered To SevenHundered value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue046_Verify that color of the option  for "500 To 700" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "FiveHunderedToSevenHundered"
	And I move back to Property Value Selection from Address
	Then Color of the FiveHundered To SevenHundered value option should be "#16B24D"

	Scenario: PropReg_PropValue047_Verify the color of option for "700 To 1000" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	Then Color of the SevenHundered To OneThousandvalue option should be "#00AEFF"
	
	Scenario: PropReg_PropValue048_Verify that color of the option  for "700 To 1000" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "SevenHunderedToOneThousand"
	And I move back to Property Value Selection from Address
	Then Color of the SevenHundered To OneThousandvalue option should be "#16B24D"

	Scenario: PropReg_PropValue049_Verify the color of option for "1000 To 1500" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	Then Color of the OneThousand To FifteenHundered value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue050_Verify that color of the option  for "1000 To 1500" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "OneThousandToFifteenHundered"
	And I move back to Property Value Selection from Address
	Then Color of the OneThousand To FifteenHundered value option should be "#16B24D"

	Scenario: PropReg_PropValue051_Verify the color of option for "1500+" value when it is not selected
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	Then Color of the MoreThanFifteenHundered value option should be "#00AEFF"
	
	Scenario: PropReg_PropValue052_Verify that color of the option  for "1500+" value on selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "MoreThanFifteenHundered"
	And I move back to Property Value Selection from Address
	Then Color of the MoreThanFifteenHundered value option should be "#16B24D"

	Scenario: PropReg_PropValue053_Verify that link for Moving forward is displayed as enabled when user moves back to Property Value selection from Address section
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "MoreThanFifteenHundered"
	And I move back to Property Value Selection from Address
	Then Moving forward Link is displayed as enabled

	Scenario: PropReg_PropValue054_Verify that Address question is displayed on clicking Forward link on Property Value selection
	Given I am on Property_Registration Page
	And I navigate to Property Value Section after entering details
	| Category | PropType | Beds |
	| Rent     | House    | One  |
	When I Select value as "MoreThanFifteenHundered"
	And I move back to Property Value Selection from Address
	And Click on Forward Link
	Then Address question should be displayed