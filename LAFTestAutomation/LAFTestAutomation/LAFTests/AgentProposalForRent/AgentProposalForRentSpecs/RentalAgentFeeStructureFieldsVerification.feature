Feature: RentalAgentFeeStructureFieldsVerification
	In order to submit the proposal for Landlords
	As an Agent
	I want to be able to enter the Agent Fees

@mytag
Scenario: AgentProposalForRent_FeeStructure001_Verify the Question for Agent Fee Structure section
	Given User navigate to Agent_Reg Page
	And User goes to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Rental Agent Fee Structure section after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod | RentalPostCodes | RentalsAboutYouDetails | RentalsAboutYourAgencyDetails | RentalsMarketingSellingApproach |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              | 3055            | AboutYouDetails_rental | AboutYourAgencyDetails_rental | MarketingSellingApproach_rental |
	Then Question "How do you structure your fees?" is displayed for Rental Agent Fee Structure section

	Scenario: AgentProposalForRent_FeeStructure002_Verify options under Letting Fee drop down
	Given User navigate to Agent_Reg Page
	And User goes to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Rental Agent Fee Structure section after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod | RentalPostCodes | RentalsAboutYouDetails | RentalsAboutYourAgencyDetails | RentalsMarketingSellingApproach |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              | 3055            | AboutYouDetails_rental | AboutYourAgencyDetails_rental | MarketingSellingApproach_rental |
	Then Below options should be available under  Letting Fee drop down
		| LettingFee |
		| 0 weeks    |
		| 1 week     |
		| 1.5 weeks  |
		| 2 weeks    |
		| 2.5 weeks  |
		| 3 weeks    |
		| 4 weeks    |
		| 5 weeks    |

	Scenario: AgentProposalForRent_FeeStructure003_Verify options under Marketing Budget drop down
	Given User navigate to Agent_Reg Page
	And User goes to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Rental Agent Fee Structure section after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod | RentalPostCodes | RentalsAboutYouDetails | RentalsAboutYourAgencyDetails | RentalsMarketingSellingApproach |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              | 3055            | AboutYouDetails_rental | AboutYourAgencyDetails_rental | MarketingSellingApproach_rental |
	Then Below options should be available under Marketing Budget
		| RentalMarketingBudget |
		| Free Marketing        |
		| No Lease No Fee       |
		| Less than $250        |
		| $251 - $500           |
		| $501 - $750           |
		| $751 - $1,000         |
		| $1,001 - $1,500       |
		| $1,501 - $2,000       |
		| More than $2,000      |

	Scenario: AgentProposalForRent_FeeStructure004_Verify that Rental Proposal is submitted successfully after entering Management Fee as 3
	Given User navigate to Agent_Reg Page
	And User goes to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Rental Agent Fee Structure section after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod | RentalPostCodes | RentalsAboutYouDetails | RentalsAboutYourAgencyDetails | RentalsMarketingSellingApproach |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              | 3055            | AboutYouDetails_rental | AboutYourAgencyDetails_rental | MarketingSellingApproach_rental |
	And User enters Management Fee as
	| RentalsManagementFee |
	| 3                    |
	And User Clicks on Submit
	Then Confirmation for Rental Proposal Submission is displayed

	Scenario: AgentProposalForRent_FeeStructure005_Verify that Rental Proposal is submitted successfully after entering Management Fee as 8.5
	Given User navigate to Agent_Reg Page
	And User goes to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Rental Agent Fee Structure section after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod | RentalPostCodes | RentalsAboutYouDetails | RentalsAboutYourAgencyDetails | RentalsMarketingSellingApproach |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              | 3055            | AboutYouDetails_rental | AboutYourAgencyDetails_rental | MarketingSellingApproach_rental |
	And User enters Management Fee as
	| RentalsManagementFee |
	| 8.5                  |
	And User Clicks on Submit
	Then Confirmation for Rental Proposal Submission is displayed

	Scenario: AgentProposalForRent_FeeStructure006_Verify that Rental Proposal is submitted successfully after selecting Letting Fee as 2.5 weeks
	Given User navigate to Agent_Reg Page
	And User goes to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Rental Agent Fee Structure section after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod | RentalPostCodes | RentalsAboutYouDetails | RentalsAboutYourAgencyDetails | RentalsMarketingSellingApproach |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              | 3055            | AboutYouDetails_rental | AboutYourAgencyDetails_rental | MarketingSellingApproach_rental |
	And User enters Rental Fee Details as
	| LettingFee | RentalsManagementFee |
	| 2.5 weeks  | 8.5                  |
	And User Clicks on Submit
	Then Confirmation for Rental Proposal Submission is displayed

	Scenario: AgentProposalForRent_FeeStructure007_Verify that Rental Proposal is submitted successfully after selecting Marketing Budget as $251 - $500
	Given User navigate to Agent_Reg Page
	And User goes to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Rental Agent Fee Structure section after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod | RentalPostCodes | RentalsAboutYouDetails | RentalsAboutYourAgencyDetails | RentalsMarketingSellingApproach |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              | 3055            | AboutYouDetails_rental | AboutYourAgencyDetails_rental | MarketingSellingApproach_rental |
	And User enters Rental Fee Details as
	| LettingFee | RentalsManagementFee | RentalMarketingBudget |
	| 2.5 weeks  | 8.5                  | $251 - $500           |
	And User Clicks on Submit
	Then Confirmation for Rental Proposal Submission is displayed

	Scenario: AgentProposalForRent_FeeStructure008_Verify that error message is displayed on submitting Rentals Proposal without entering Management Fee
	Given User navigate to Agent_Reg Page
	And User goes to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Rental Agent Fee Structure section after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod | RentalPostCodes | RentalsAboutYouDetails | RentalsAboutYourAgencyDetails | RentalsMarketingSellingApproach |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              | 3055            | AboutYouDetails_rental | AboutYourAgencyDetails_rental | MarketingSellingApproach_rental |
	And User enters Rental Fee Details as
	| LettingFee | RentalsManagementFee | RentalMarketingBudget |
	|            |                      |                       |
	And User Clicks on Submit
	Then Error Message "Please provide a management fee. Please provide a realistic management fee." should be displayed

	Scenario: AgentProposalForRent_FeeStructure009_Verify that under Progress section, Fees circle should be displayed as Active
	Given User navigate to Agent_Reg Page
	And User goes to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Rentals     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Rental Agent Fee Structure section after entering details as
		| PropertyMgmtTeamSize | PropertyPerPropManager | Languages | EmergencyContact | LandlordInsuranceAdvice | InspectionFrequencyPeriod | RentalPostCodes | RentalsAboutYouDetails | RentalsAboutYourAgencyDetails | RentalsMarketingSellingApproach |
		| 50                   | 10                     | Spanish   | Yes              | Yes                     | As requested              | 3055            | AboutYouDetails_rental | AboutYourAgencyDetails_rental | MarketingSellingApproach_rental |
	Then Fees circle is displayed as Active
