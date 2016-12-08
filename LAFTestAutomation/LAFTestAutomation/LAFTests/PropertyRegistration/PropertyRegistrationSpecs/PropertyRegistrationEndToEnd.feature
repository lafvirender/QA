Feature: PropertyRegistrationEndToEnd
	In order to compare agents for selling property
	As a User
	I want to be able to register property for sell

@EndToEnd
Scenario Outline: User Registers Property
	Given User is on LAF Home Page
	And User Navigates to Property Registration Page
	When User Enters the Details As '<Category>'  '<PropType>'  '<Beds>'  '<ApproxValue>'  '<Address>'  '<Leased>'  '<LeasingDetails>'  '<AgentQuality>'  '<SpecificAgency>'  '<SpecificAgenciesDetails>'  '<ContactedAgency>'  '<ContactedAgenciesDetails>'  '<Urgency>'  '<CustomerDetails>'  '<customerDirectConnectAnswer>'  '<DirectConnectDetails>'
    Then Property should be registered successfully

Examples: 
| Category | PropType  | Beds | ApproxValue                 | Address                                          | Leased           | LeasingDetails                   | AgentQuality                  | SpecificAgency | SpecificAgenciesDetails     | ContactedAgency | ContactedAgenciesDetails   | Urgency            | CustomerDetails                                    | customerDirectConnectAnswer | DirectConnectDetails |
| Sell     | House     | One  | LessThanTwoHunderedK        | Unit1,myStreet,Notlen St,Ringwood,VIC,3134       | MyHome           | Details                          | AbilityToGetBestOutcome       | No             | Specific Agencies           | No              | Contacted Agencies         | Immediately        | First,Last,a@Kqr.com,0416789754                    | Yes                         | Details              |
| Sell     | Unit      | Two  | TwoHunderedKToFourHunderedK | Unit2,myStreet1,Harlem St,Inglewood,NSW,3137     | VacantProperty   | Description of Vacant Property   | LocalKnowledegeAndExpertise   | Yes            | Name of Agencies Considered | Yes             | Name of Agencies Spoken To | ZeroToThreeMonths | FirstA,LastA,a@LKstA.com,0416785664                | No                          |                      |
| Rent     | Apartment | Four | LessThanTwoHundered         | Unit4,myStreet3,Gotham St,xyzland,VIC,3139       | TenantedProperty | Description of Tenanted Property | TrustworthinessAndReliability | No             |                             | No              |                            | ThreeToSixMonths   | FirstABC,LastABC,a@LKastBACD.com,0416789634        | No                          |                      |
| Rent     | Townhouse | One  | TwoHunderedToThreeHundered  | Unit5,myStreet4,Wolverine St,Goldland,NSW,3140   | VacantProperty   | Description of Tenanted Property | PatienceAndUnderstanding      | Yes            | Name of Agencies Considered | Yes             | Name of Agencies Spoken To | SixPlusMonths      | FirstABCD,LastABCD,a@LKastACCCBD.com,0416789634    | No                          |                      |
| Rent     | Villa     | Two  | ThreeHunderedToFourHundered | Unit6,myStreet5,Nighthawk St,Silverland,QLD,3141 | TenantedProperty | Description of Tenanted Property | PatienceAndUnderstanding      | No             |                             | No              |                            | SixPlusMonths      | FirstABCDE,LastABCDE,a@LKastACEERDS.com,0416789634 | No                          |                      |
