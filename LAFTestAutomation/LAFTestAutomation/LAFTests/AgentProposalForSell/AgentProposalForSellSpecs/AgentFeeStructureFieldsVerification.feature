Feature: AgentFeeStructureFieldsVerification
	In order to submit the proposal for Vendors
	As an Agent
	I want to be able to enter the Agent Fees

@mytag
Scenario: AgentProposalForSell_FeeStructure001_Verify the Question for Agent Fee Structure section
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	Then Question "How do you structure your fees?" is displayed for Agent Fee Structure section

	Scenario: AgentProposalForSell_FeeStructure002_Verify options under Properties between drop down
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	Then Below options should be available under Properties between drop down
		| PropertiesBetween |
		| $50,000           |
		| $100,000          |
		| $200,000          |
		| $300,000          |
		| $500,000          |
		| $750,000          |
		| $1M               |
		| $1.5M             |
		| $2M               |
		| $2.5M+            |

	Scenario: AgentProposalForSell_FeeStructure003_Verify options under CommissionTypes drop down
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	Then Below options should be available under CommissionTypes drop down
		| CommissionTypes |
		| percentage      |
		| fixed fee       |

	Scenario: AgentProposalForSell_FeeStructure004_Verify options under  Marketing Budget drop down
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	Then Below options should be available under Marketing Budget drop down
		| MarketingBudget  |
		| Free Marketing   |
		| No Sale No Fee   |
		| Less than $1,000 |
		| $1,001 - $2,000  |
		| $2,001 - $3,000  |
		| $3,001 - $4,000  |
		| $4,001 - $5,000  |
		| More than $5,001 |

	Scenario: AgentProposalForSell_FeeStructure005_Verify that on clicking Add Higher Range button for first time, Second section for entering Fee Structure containing fields for Properties between, Commission and Marketing Budget is displayed
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User clicks Add Higher Range button
	Then Second Fee Structure section is displayed

	Scenario: AgentProposalForSell_FeeStructure006_Verify that on clicking Add Higher Range button for second time, third section for entering Fee Structure containing fields for Properties between, Commission and Marketing Budget is displayed
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User clicks Add Higher Range button
	And User clicks Add Higher Range second time
	Then Third Fee Structure section is displayed

	Scenario: AgentProposalForSell_FeeStructure007_Verify that Sales Proposal is submitted successfully after entering Commission Type as Percentage
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User selects the Commission Type as 
	| FirstFeeStrCommissionType |
	| percentage                |
	And User enter Commission Percentage as "5.0"
	And User Clicks Submit
	Then Confirmation for Proposal Submission is displayed

	Scenario: AgentProposalForSell_FeeStructure008_Verify that Sales Proposal is submitted successfully after entering Commission Type as Fixed Fee
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User selects the Commission Type as 
	| FirstFeeStrCommissionType |
	| fixed fee                 |
	And User enter Commission Fixed Fee as "500"
	And User Clicks Submit
	Then Confirmation for Proposal Submission is displayed

	Scenario: AgentProposalForSell_FeeStructure009_Verify that Sales Proposal is submitted successfully after selecting Properties Between as $2.5M+ in the First Fee Structure
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User enters the Fee Structure Details as 
	| FirstFeeStrPropertiesBetweenUB | FirstFeeStrCommissionType | FirstFeeStrCommissionPercentage | FirstFeeStrCommissionFixedFee | FirstFeeStrMarketingBudget | SecondFeeStrPropertiesBetweenUB | SecondFeeStrCommissionType | SecondFeeStrCommissionPercentage | SecondFeeStrCommissionFixedFee | SecondFeeStrMarketingBudget | ThirdFeeStrPropertiesBetweenUB | ThirdFeeStrCommissionType | ThirdFeeStrCommissionPercentage | ThirdFeeStrCommissionFixedFee | ThirdFeeStrMarketingBudget |
	| $2.5M+                            | percentage                | 3.0                             |                               | Free Marketing              |                                 |                            |                                  |                                |                             |                                |                           |                                 |                               |                            |  
	And User Clicks Submit
	Then Confirmation for Proposal Submission is displayed

	Scenario: AgentProposalForSell_FeeStructure010_Verify that error message is displayed on submitting Sales Proposal after selecting Properties Between UpperBound value as less than $2.5M+ when no other Fee Structure specifying the Fee for Properties upto $2.5M+ exists
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User enters the Fee Structure Details as 
	| FirstFeeStrPropertiesBetweenUB | FirstFeeStrCommissionType | FirstFeeStrCommissionPercentage | FirstFeeStrCommissionFixedFee | FirstFeeStrMarketingBudget | SecondFeeStrPropertiesBetweenUB | SecondFeeStrCommissionType | SecondFeeStrCommissionPercentage | SecondFeeStrCommissionFixedFee | SecondFeeStrMarketingBudget | ThirdFeeStrPropertiesBetweenUB | ThirdFeeStrCommissionType | ThirdFeeStrCommissionPercentage | ThirdFeeStrCommissionFixedFee | ThirdFeeStrMarketingBudget |
	| $2M                         | percentage                | 3.0                             |                               | Free Marketing              |                                 |                            |                                  |                                |                             |                                |                           |                                 |                               |                            |  
	And User Clicks Submit
	Then Error Message "Please provide commission information for range up to $2.5million" is displayed

	Scenario: AgentProposalForSell_FeeStructure011_Verify the value populated under Second Fee Structure Lower Bound and Upper Bound fields when new Range is added after selecting Properties Between UpperBound value $200,000 in First Fee Structure
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User enters the Fee Structure Details as 
	| FirstFeeStrPropertiesBetweenUB | FirstFeeStrCommissionType | FirstFeeStrCommissionPercentage | FirstFeeStrCommissionFixedFee | FirstFeeStrMarketingBudget | SecondFeeStrPropertiesBetweenUB | SecondFeeStrCommissionType | SecondFeeStrCommissionPercentage | SecondFeeStrCommissionFixedFee | SecondFeeStrMarketingBudget | ThirdFeeStrPropertiesBetweenUB | ThirdFeeStrCommissionType | ThirdFeeStrCommissionPercentage | ThirdFeeStrCommissionFixedFee | ThirdFeeStrMarketingBudget |
	| $200,000                       |                           |                              |                               |              |                                 |                            |                                  |                                |                             |                                |                           |                                 |                               |                            |  
	And User clicks Add Higher Range button
	Then Value "$200,000" is displayed in Properties Between LowerBound and Value "$2.5M+" is displayed in Properties Between UpperBound for New Fee Structure

	Scenario: AgentProposalForSell_FeeStructure012_Verify the value populated under Third Fee Structure Lower Bound and Upper Bound fields when a Third Fee Range is added after selecting Properties Between UpperBound value $2.5M+ in second Fee Structure
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  |randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User enters the Fee Structure Details as 
	| FirstFeeStrPropertiesBetweenUB | FirstFeeStrCommissionType | FirstFeeStrCommissionPercentage | FirstFeeStrCommissionFixedFee | FirstFeeStrMarketingBudget | SecondFeeStrPropertiesBetweenUB | SecondFeeStrCommissionType | SecondFeeStrCommissionPercentage | SecondFeeStrCommissionFixedFee | SecondFeeStrMarketingBudget | ThirdFeeStrPropertiesBetweenUB | ThirdFeeStrCommissionType | ThirdFeeStrCommissionPercentage | ThirdFeeStrCommissionFixedFee | ThirdFeeStrMarketingBudget |
	| $200,000                       |                           |                                 |                               |                            |                                 |                            |                                  |                                |                             |                                |                           |                                 |                               |                            |  
	And User clicks Add Higher Range button
	And User enters the Fee Structure Details as 
	| FirstFeeStrPropertiesBetweenUB | FirstFeeStrCommissionType | FirstFeeStrCommissionPercentage | FirstFeeStrCommissionFixedFee | FirstFeeStrMarketingBudget | SecondFeeStrPropertiesBetweenUB | SecondFeeStrCommissionType | SecondFeeStrCommissionPercentage | SecondFeeStrCommissionFixedFee | SecondFeeStrMarketingBudget | ThirdFeeStrPropertiesBetweenUB | ThirdFeeStrCommissionType | ThirdFeeStrCommissionPercentage | ThirdFeeStrCommissionFixedFee | ThirdFeeStrMarketingBudget |
	|                                |                           |                                 |                               |                            | $500,000                        |                            |                                  |                                |                             |                                |                           |                                 |                               |                            |
	And User clicks Add Higher Range button
	Then Value "$500,000" is displayed in Properties Between LowerBound and Value "$2.5M+" is displayed in Properties Between UpperBound for New Third Fee Structure

	Scenario: AgentProposalForSell_FeeStructure013_Verify that on clicking Delete Range, third section for entering Fee Structure is deleted
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User clicks Add Higher Range button
	And User enters the Fee Structure Details as 
	| FirstFeeStrPropertiesBetweenUB | FirstFeeStrCommissionType | FirstFeeStrCommissionPercentage | FirstFeeStrCommissionFixedFee | FirstFeeStrMarketingBudget | SecondFeeStrPropertiesBetweenUB | SecondFeeStrCommissionType | SecondFeeStrCommissionPercentage | SecondFeeStrCommissionFixedFee | SecondFeeStrMarketingBudget | ThirdFeeStrPropertiesBetweenUB | ThirdFeeStrCommissionType | ThirdFeeStrCommissionPercentage | ThirdFeeStrCommissionFixedFee | ThirdFeeStrMarketingBudget |
	|                                |                           |                                 |                               |                            | $750,000                        |                            |                                  |                                |                             |                                |                           |                                 |                               |                            |  
	And User clicks Add Higher Range button
	And User Clicks Delete Range button
	Then Third Fee Structure section is deleted and is not displayed

	Scenario: AgentProposalForSell_FeeStructure014_Verify that on clicking Delete Range, second section for entering Fee Structure is deleted
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	And User clicks Add Higher Range button
	And User enters the Fee Structure Details as 
	| FirstFeeStrPropertiesBetweenUB | FirstFeeStrCommissionType | FirstFeeStrCommissionPercentage | FirstFeeStrCommissionFixedFee | FirstFeeStrMarketingBudget | SecondFeeStrPropertiesBetweenUB | SecondFeeStrCommissionType | SecondFeeStrCommissionPercentage | SecondFeeStrCommissionFixedFee | SecondFeeStrMarketingBudget | ThirdFeeStrPropertiesBetweenUB | ThirdFeeStrCommissionType | ThirdFeeStrCommissionPercentage | ThirdFeeStrCommissionFixedFee | ThirdFeeStrMarketingBudget |
	|                                |                           |                                 |                               |                            | $750,000                        |                            |                                  |                                |                             |                                |                           |                                 |                               |                            |  
	And User clicks Add Higher Range button
	And User Clicks Delete Range button
	And User Clicks Delete Range second time
	Then Second Fee Structure section is deleted and is not displayed

	Scenario: AgentProposalForSell_FeeStructure015_Verify that under Progress section, Fees circle should be displayed as Active
	Given User goes to Agent_Registration Page
	And User goes to BeginProposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize| Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When User navigates to Fee Structure section after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details |
	Then Fees circle should be displayed as Active
