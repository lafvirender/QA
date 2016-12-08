using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration
{
    public class PropertyRegistrationFunnelUIMap
    {
        public TestObjectProperties EltListingCategorySlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide.listingcategory[data-slick-index='0']");
        public TestObjectProperties EltPropertyTypeSlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide[data-slick-index='1']");
        public TestObjectProperties EltBedroomsSlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide[data-slick-index='2']");
        public TestObjectProperties EltPropertyValueSlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide[data-slick-index='3']");
        public TestObjectProperties EltAddressSlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide.address-group[data-slick-index='4']");
        public TestObjectProperties EltPropertyDescriptionSlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide[data-slick-index='5']");
        public TestObjectProperties EltAgentQualitySSlide = new TestObjectProperties(Locator.CssSelector, 
                                                                         ".slide[data-slick-index='6']");
        public TestObjectProperties EltSpecificAgenciesSlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide[data-slick-index='7']");
        public TestObjectProperties EltContactedAgenciesSlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide[data-slick-index='8']");
        public TestObjectProperties EltUrgencySlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide[data-slick-index='9']");
        public TestObjectProperties EltPersonalDetailsSlide = new TestObjectProperties(Locator.CssSelector,
                                                                         ".slide[data-slick-index='10']");

        public TestObjectProperties EltQuestion = new TestObjectProperties(Locator.CssSelector, 
                        "div[aria-hidden=false]>.question");
        //public TestObjectProperties LnkBack = new TestObjectProperties(Locator.CssSelector, 
        //                ".nav-section.prev-section.checkmark_circle>a");
        //public TestObjectProperties LnkForward = new TestObjectProperties(Locator.CssSelector, 
        //                ".nav-section.next-section.checkmark_circle>a");

        public TestObjectProperties LnkBack = new TestObjectProperties(Locator.CssSelector,
                                                                ".tracked.prev.nav-button[data-parameter=Back]");
        public TestObjectProperties LnkForward = new TestObjectProperties(Locator.CssSelector,
                                                                ".tracked.next.nav-button[data-parameter=Next]");


        public TestObjectProperties EltProgressPropDetails = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details");
        public TestObjectProperties EltProgressPropDetailsCheckmark = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-point.checkmark");
        public TestObjectProperties EltProgressPropDetailsCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressPropDetailsCheckmarkStem = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-point.checkmark>.checkmark_stem");

        public TestObjectProperties EltProgressPropDetailsLinePropType = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-line-container>.progress-point.line[data-parameter=PropertyType]");
        public TestObjectProperties EltProgressPropDetailsLineSectionPropType = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-line-container>.progress-point.line[data-parameter=PropertyType]>.line-section");

        public TestObjectProperties EltProgressPropDetailsLineBedrooms = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-line-container>.progress-point.line[data-parameter=Bedrooms]");
        public TestObjectProperties EltProgressPropDetailsLineSectionBedrooms = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-line-container>.progress-point.line[data-parameter=Bedrooms]>.line-section");

        public TestObjectProperties EltProgressPropDetailsLinePropValue = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-line-container>.progress-point.line[data-parameter=Value]");
        public TestObjectProperties EltProgressPropDetailsLineSectionPropValue = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-line-container>.progress-point.line[data-parameter=Value]>.line-section.line-top");

        public TestObjectProperties EltProgressPropDetailsLineAddress = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-line-container>.progress-point.line[data-parameter=Address]");
        public TestObjectProperties EltProgressPropDetailsLineSectionAddress = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.progress-line-container>.progress-point.line[data-parameter=Address]>.line-section");

        public TestObjectProperties EltProgressPropDetailsLabel = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.property-details>.section-label");
        public TestObjectProperties EltProgressAgentPref = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.agent-preferences");
        public TestObjectProperties EltProgressAgentPrefCheckmark = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.agent-preferences>.progress-point.checkmark");
        public TestObjectProperties EltProgressAgentPrefCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.agent-preferences>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressAgentPrefCheckmarkStem = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.agent-preferences>.progress-point.checkmark>.checkmark_stem");
        public TestObjectProperties EltProgressAgentPrefLineSpecificAgency = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.agent-preferences>.progress-line-container>.progress-point.line[data-parameter=SpecificAgency]");
        public TestObjectProperties EltProgressAgentPrefLineSectionSpecificAgency = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.agent-preferences>.progress-line-container>.progress-point.line[data-parameter=SpecificAgency]>.line-section");
        public TestObjectProperties EltProgressAgentPrefLineContactedAgency = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.agent-preferences>.progress-line-container>.progress-point.line[data-parameter=ContactedAgency]");
        public TestObjectProperties EltProgressAgentPrefLineSectionContactedAgency = new TestObjectProperties(Locator.CssSelector,
                       ".progress-section>.section.agent-preferences>.progress-line-container>.progress-point.line[data-parameter=ContactedAgency]>.line-section");
        public TestObjectProperties EltProgressAgentPrefLabel = new TestObjectProperties(Locator.CssSelector,
                       ".progress-section>.section.agent-preferences>.section-label");
        public TestObjectProperties EltProgressYourDetails = new TestObjectProperties(Locator.CssSelector,
                       ".progress-section>.section.your-details");
        public TestObjectProperties EltProgressYourDetailsCheckmark = new TestObjectProperties(Locator.CssSelector,
                       ".progress-section>.section.your-details>.progress-point.checkmark");
        public TestObjectProperties EltProgressYourDetailsCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                       ".progress-section>.section.your-details>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressYourDetailsCheckmarkStem = new TestObjectProperties(Locator.CssSelector,
                       ".progress-section>.section.your-details>.progress-point.checkmark>.checkmark_stem");
        public TestObjectProperties EltProgressYourDetailsLabel = new TestObjectProperties(Locator.CssSelector,
                       ".progress-section>.section.your-details>.section-label");
        public TestObjectProperties LnkSell = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[data-parameter=Sell]");
        public TestObjectProperties LnkRent = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[data-parameter=Rent]");

        public TestObjectProperties EltMatchingAddressListItem=new TestObjectProperties(Locator.CssSelector, ".pca.pcalist>.pcaitem");

        public TestObjectProperties LnkHouse = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[data-parameter=House]");
        public TestObjectProperties LnkUnit = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[data-parameter=Unit]");
        public TestObjectProperties LnkLand = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[data-parameter=Land]");
        public TestObjectProperties LnkApartment = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[data-parameter=Apartment]");
        public TestObjectProperties LnkTownHouse = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[data-parameter=TownHouse]");
        public TestObjectProperties LnkVilla = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[data-parameter=Villa]");

        public TestObjectProperties LnkOneBedRoom = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=Bedrooms][data-parameter='1']");
        public TestObjectProperties LnkTwoBedRoom = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=Bedrooms][data-parameter='2']");
        public TestObjectProperties LnkThreeBedRoom = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=Bedrooms][data-parameter='3']");
        public TestObjectProperties LnkFourBedRoom = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=Bedrooms][data-parameter='4+']");

        public TestObjectProperties EltApproxValue = new TestObjectProperties(Locator.CssSelector, "a[option-parameter=ApproxValue]>.option-text");

        public TestObjectProperties LnkLessThan200K = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='150000']");
        public TestObjectProperties LnkValue200KTo400K = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='300000']");
        public TestObjectProperties LnkValue400KTo600K = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='500000']");
        public TestObjectProperties LnkValue600KTo800K = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='700000']");
        public TestObjectProperties LnkValue800KTo1M = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='900000']");
        public TestObjectProperties LnkValue1MTo1_5M = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='1250000']");
        public TestObjectProperties LnkValue1_5MTo2M = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='1750000']");
        public TestObjectProperties LnkValue2MPlus = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='2500000']");

        public TestObjectProperties LnkLessThan200 = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='150']");
        public TestObjectProperties LnkValue200To300 = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='250']");
        public TestObjectProperties LnkValue300To400 = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='350']");
        public TestObjectProperties LnkValue400To500 = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='450']");
        public TestObjectProperties LnkValue500To700 = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='600']");
        public TestObjectProperties LnkValue700To1000 = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='850']");
        public TestObjectProperties LnkValue1000To1500 = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='1250']");
        public TestObjectProperties LnkValue1500Plus = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value='1700']");

        public TestObjectProperties LnkManualAddress = new TestObjectProperties(Locator.CssSelector, ".input-address-manually[data-event=Address]");
        public TestObjectProperties TxtApartmentNo = new TestObjectProperties(Locator.Id, "AppartmentNo");
        public TestObjectProperties TxtStreetNo = new TestObjectProperties(Locator.Id, "StreetNo");
        public TestObjectProperties TxtStreet = new TestObjectProperties(Locator.Id, "Street");
        public TestObjectProperties TxtSuburb = new TestObjectProperties(Locator.Id, "Suburb");
        public TestObjectProperties TxtState = new TestObjectProperties(Locator.Id, "State");
        public TestObjectProperties TxtPostcode = new TestObjectProperties(Locator.Id, "Postcode");
        public TestObjectProperties LnkNext = new TestObjectProperties(Locator.LinkText, "NEXT");
        public TestObjectProperties LnkNextAddress = new TestObjectProperties(Locator.CssSelector, ".tracked.button[data-event=Address][data-parameter=Next]");
        public TestObjectProperties TxtAddressSearch = new TestObjectProperties(Locator.Id, "search");

        public TestObjectProperties LnkMyHome = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=Leased][option-index='0']");
        public TestObjectProperties LnkVacantProperty = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=Leased][option-index='1']");
        public TestObjectProperties LnkTenantedProperty = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=Leased][option-index='2']");
        public TestObjectProperties TxtLeasingDetails = new TestObjectProperties(Locator.CssSelector,
                                                                        "textarea[name='LeasingDetails']");
        public TestObjectProperties TxtSpecificAgencyDetails = new TestObjectProperties(Locator.CssSelector,
                                                                        "textarea[name='SpecificAgencyDetails']");
        public TestObjectProperties TxtContactedAgencyDetails = new TestObjectProperties(Locator.CssSelector,
                                                                        "textarea[name='ContactedAgencyDetails']");
        //public TestObjectProperties LnkYes = new TestObjectProperties(Locator.LinkText, "YES");
        //public TestObjectProperties LnkNo = new TestObjectProperties(Locator.LinkText, "NO");
        public TestObjectProperties LnkDirectConnectYes = new TestObjectProperties(Locator.Id, "dcyes");
        public TestObjectProperties LnkDirectConnectNo = new TestObjectProperties(Locator.Id, "dcno");
        public TestObjectProperties LnkSpecificAgencyYes = new TestObjectProperties(Locator.CssSelector,
                            ".option.tracked.button[data-event='SpecificAgency'][data-parameter='Yes']");
        public TestObjectProperties LnkSpecificAgencyNo = new TestObjectProperties(Locator.CssSelector,
                             ".option.tracked.button[data-event='SpecificAgency'][data-parameter='No']");

        public TestObjectProperties LnkContactedAgencyYes = new TestObjectProperties(Locator.CssSelector,
                             ".option.tracked.button[data-event='ContactedAgency'][data-parameter='Yes']");
        public TestObjectProperties LnkContactedAgencyNo = new TestObjectProperties(Locator.CssSelector,
                              ".option.tracked.button[data-event='ContactedAgency'][data-parameter='No']");
        public TestObjectProperties TxtFirstName = new TestObjectProperties(Locator.Id, "FirstName");
        public TestObjectProperties TxtLastName = new TestObjectProperties(Locator.Id, "LastName");
        public TestObjectProperties TxtEmail = new TestObjectProperties(Locator.Id, "Email");
        public TestObjectProperties TxtMobileNumber = new TestObjectProperties(Locator.Id, "Phone");
        public TestObjectProperties LnkSubmit = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Finished]");
        public TestObjectProperties EltSalutationCustomerDetails= new TestObjectProperties(Locator.CssSelector, 
                                                                        ".modal-title.black-text>.salutations-1");
        public TestObjectProperties TxtDirectConnectDetails = new TestObjectProperties(Locator.Id, "details3Top");
        public TestObjectProperties BtnFinished = new TestObjectProperties(Locator.CssSelector, 
                                                                        "button.button.next.tracked.connected");
        public TestObjectProperties EltThanksSection = new TestObjectProperties(Locator.ClassName, "thanks-section");
        public TestObjectProperties EltconfirmMsgOneToUser = new TestObjectProperties(Locator.CssSelector, ".auto.thanks-content>h2");
        public TestObjectProperties EltconfirmMsgTwoToUser = new TestObjectProperties(Locator.CssSelector, ".auto.thanks-content>h2:nth-child(2)");
        public TestObjectProperties EltinfMsgToUser = new TestObjectProperties(Locator.CssSelector, ".auto.thanks-content>h3");
        public TestObjectProperties EltagentCount = new TestObjectProperties(Locator.CssSelector, ".agent-count-indicator");
        public TestObjectProperties EltagentIndicatorText = new TestObjectProperties(Locator.CssSelector, ".indicator-text");
        public TestObjectProperties EltcustomerEmailText = new TestObjectProperties(Locator.CssSelector, ".email-address");
        public TestObjectProperties EltEMailMsg = new TestObjectProperties(Locator.CssSelector, ".email-template-text");
        public TestObjectProperties EltEstimateTimeMsg = new TestObjectProperties(Locator.CssSelector, ".estimate-text");


        
        public TestObjectProperties LnkAbilityToGetBestOutcome = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value=BestOutCome]");
        public TestObjectProperties LnkLocalKnowledegeAndExpertise = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value=LocalKnowledge]");
        public TestObjectProperties LnkTrustworthinessAndReliability = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value=Trust]");
        public TestObjectProperties LnkPatienceAndUnderstanding = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-value=Patience]");

        public TestObjectProperties LnkImmediately = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=TimeofSale][option-value='1']");
        public TestObjectProperties LnkZeroToThreeMonths = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=TimeofSale][option-value='2']");
        public TestObjectProperties LnkThreeToSixMonths = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=TimeofSale][option-value='3']");
        public TestObjectProperties LnkSixPlusMonths = new TestObjectProperties(Locator.CssSelector, ".option.tracked.button[option-parameter=TimeofSale][option-value='4']");
    }
}
