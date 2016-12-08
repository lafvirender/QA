Feature: SalesProposalConfirmationFieldsVerification
	Agent Sales Proposal should be submitted successfully

@mytag
Scenario: AgentProposalForSell_ProposalConfirmation001_Verify Agent Dashboard is displayed on clicking Go To Your Portal button on Confirm popup
	Given User navigates to Agent_Registration Page
	And User navigates to Begin_Proposal Page after registering agent with details as below
	| Interest | AgentFirstName | AgentLastName | AgentPhone | AgentMobile | AgentEmail | AgentPosition    | AgencyUnitAppNo | AgencyStreetNo | AgencyStreet | AgencySuburb | AgencyState | AgencyPostCode | AgencyName | AgencyBranch | PrincipalFirstName | PrincipalLastName | PrincipalPhone | PrincipalMobile | PrincipalEmail         |
	| Sales     | First          | Last          | 0412213456 | 0412213456  | randomize | Sales Consultant | Unit1           | testStreet     | streetname   | testSuburb   | VIC         | 3081           | testAgency | branch       | PFirst             | PLast             | 0412213456     | 0412213456      | a@testing167658756.com |
	When Submits the Sales proposal after entering details as
	| SaleMethods | Languages | SaleAuthoritySize | SaleTeamSize | PostCodes | AboutYouDetails  | AboutYourAgencyDetails    | MarketingSellingApproach   | FirstFeeStrPropertiesBetweenUB | FirstFeeStrCommissionType | FirstFeeStrCommissionPercentage | FirstFeeStrCommissionFixedFee | FirstFeeStrMarketingBudget | SecondFeeStrPropertiesBetweenUB | SecondFeeStrCommissionType | SecondFeeStrCommissionPercentage | SecondFeeStrCommissionFixedFee | SecondFeeStrMarketingBudget | ThirdFeeStrPropertiesBetweenUB | ThirdFeeStrCommissionType | ThirdFeeStrCommissionPercentage | ThirdFeeStrCommissionFixedFee | ThirdFeeStrMarketingBudget |
	| Auctions    | Arabic    | 1 month           | 4            | 3081      | aboutyou details | about your agency details | marketing approach details | $2.5M+                         | percentage                | 3.0                             |                               |                            |                                 |                            |                                  |                                |                             |                                |                           |                                 |                               |                            |  
	And User clicks on Go To Your Portal Button on Sales Confirm popup
	Then Agent Dashboard is displayed

