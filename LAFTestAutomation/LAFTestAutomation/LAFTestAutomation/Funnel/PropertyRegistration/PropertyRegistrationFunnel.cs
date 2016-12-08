using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration
{
    public class PropertyRegistrationFunnel : PropertyRegistrationFunnelUIMap
    {
        public ListingCategory ListingCategory;
        public PropertyType PropertyType;
        public Bedrooms Bedrooms;
        public PropertyValue PropertyValue;
        public PropertyAddress PropertyAddress;
        public PropertyDescription PropertyDescription;
        public AgentQuality AgentQuality;
        public SpecificAgencies SpecificAgencies;
        public ContactedAgencies ContactedAgencies;
        public Urgency Urgency;
        public PersonalDetails PersonalDetails;
        public ThankYou ThankYou;

        private readonly TestObject _elementQ;
        private readonly TestObject _lnkBack;
        private readonly TestObject _lnkForward;
        private readonly TestObject _eltPropertyDetailsProgress;
        private readonly TestObject _eltProgressPropDetails;
        private readonly TestObject _eltProgressPropDetailsCheckmark;
        private readonly TestObject _eltProgressPropDetailsLinePropType;
        private readonly TestObject _eltProgressPropDetailsLineBedrooms;
        private readonly TestObject _eltProgressPropDetailsLinePropValue;
        private readonly TestObject _eltProgressPropDetailsLineAddress;
        private readonly TestObject _eltProgressPropDetailsLabel;
        private readonly TestObject _eltProgressPropDetailsCheckmarkCircle;
        private readonly TestObject _eltProgressPropDetailsCheckmarkStem;
        private readonly TestObject _eltProgressPropDetailsLineSectionPropType;
        private readonly TestObject _eltProgressPropDetailsLineSectionBedrooms;
        private readonly TestObject _eltProgressPropDetailsLineSectionPropValue;
        private readonly TestObject _eltProgressPropDetailsLineSectionAddress;
        private readonly TestObject _eltProgressAgentPref;
        private readonly TestObject _eltProgressAgentPrefCheckmark;
        private readonly TestObject _eltProgressAgentPrefLineSpecificAgency;
        private readonly TestObject _eltProgressAgentPrefLineContactedAgency;
        private readonly TestObject _eltProgressAgentPrefLabel;
        private readonly TestObject _eltProgressAgentPrefCheckmarkCircle;
        private readonly TestObject _eltProgressAgentPrefCheckmarkStem;
        private readonly TestObject _eltProgressAgentPrefLineSectionSpecificAgency;
        private readonly TestObject _eltProgressAgentPrefLineSectionContactedAgency;
        private readonly TestObject _eltProgressYourDetails;
        private readonly TestObject _eltProgressYourDetailsCheckmark;
        private readonly TestObject _eltProgressYourDetailsLabel;
        private readonly TestObject _eltProgressYourDetailsCheckmarkCircle;
        private readonly TestObject _eltProgressYourDetailsCheckmarkStem;

        public PropertyRegistrationFunnel(Browser browser) : base()
        {
            ListingCategory = new ListingCategory(browser, EltListingCategorySlide, 
                                                  LnkSell, LnkRent, LnkForward);

            PropertyType = new PropertyType(browser, EltPropertyTypeSlide, 
                                            LnkHouse, LnkUnit, LnkLand, 
                                            LnkApartment, LnkTownHouse, 
                                            LnkVilla, LnkBack);

            Bedrooms = new Bedrooms(browser, EltBedroomsSlide, 
                                    LnkOneBedRoom, LnkTwoBedRoom, 
                                    LnkThreeBedRoom, LnkFourBedRoom, 
                                    LnkBack);  

            PropertyValue = new PropertyValue(browser, EltPropertyValueSlide, 
                                              LnkLessThan200K, LnkValue200KTo400K, 
                                              LnkValue400KTo600K, LnkValue600KTo800K, 
                                              LnkValue800KTo1M, LnkValue1MTo1_5M, 
                                              LnkValue1_5MTo2M, LnkValue2MPlus, 
                                              LnkLessThan200,LnkValue200To300, 
                                              LnkValue300To400, LnkValue400To500, 
                                              LnkValue500To700, LnkValue700To1000, 
                                              LnkValue1000To1500, LnkValue1500Plus, 
                                              EltApproxValue, LnkBack);

            PropertyAddress = new PropertyAddress(browser, EltAddressSlide, 
                                                  LnkManualAddress, TxtApartmentNo, 
                                                  TxtStreetNo, TxtStreet, 
                                                  TxtSuburb, TxtState, 
                                                  TxtPostcode, LnkNextAddress, 
                                                  LnkBack, TxtAddressSearch, 
                                                  EltMatchingAddressListItem);

            PropertyDescription = new PropertyDescription(browser, EltPropertyDescriptionSlide, 
                                                          LnkMyHome, LnkVacantProperty, 
                                                          LnkTenantedProperty, TxtLeasingDetails, 
                                                          LnkNext);



            AgentQuality = new AgentQuality(browser, EltAgentQualitySSlide,
                                            LnkAbilityToGetBestOutcome, LnkLocalKnowledegeAndExpertise,
                                            LnkTrustworthinessAndReliability, LnkPatienceAndUnderstanding,
                                            LnkBack, LnkForward);

            ContactedAgencies = new ContactedAgencies(browser, EltContactedAgenciesSlide,
                                                     LnkContactedAgencyYes, LnkContactedAgencyNo,                                    
                                                     TxtContactedAgencyDetails, LnkNext);

            SpecificAgencies = new SpecificAgencies(browser, EltSpecificAgenciesSlide ,
                                                    LnkSpecificAgencyYes, LnkSpecificAgencyNo,
                                                    TxtSpecificAgencyDetails, LnkNext, LnkBack);

            Urgency = new Urgency(browser, EltUrgencySlide, LnkImmediately, LnkZeroToThreeMonths,
                         LnkThreeToSixMonths, LnkSixPlusMonths,
                         LnkBack, LnkForward);

            PersonalDetails = new PersonalDetails(browser, EltPersonalDetailsSlide, 
                                                  TxtFirstName, TxtLastName, 
                                                  TxtEmail, TxtMobileNumber, 
                                                  LnkSubmit, EltSalutationCustomerDetails,
                                                  LnkDirectConnectYes, LnkDirectConnectNo, 
                                                  BtnFinished, TxtDirectConnectDetails, LnkBack);

            ThankYou = new ThankYou(browser, EltThanksSection, 
                                    EltconfirmMsgOneToUser, EltconfirmMsgTwoToUser,
                                    EltinfMsgToUser, EltagentCount, 
                                    EltagentIndicatorText, EltcustomerEmailText, 
                                    EltEMailMsg, EltEstimateTimeMsg);

            _elementQ = new TestObject(browser, EltQuestion);
            _lnkBack = new TestObject(browser, LnkBack);
            _lnkForward = new TestObject(browser, LnkForward);
            _eltPropertyDetailsProgress = new TestObject(browser, EltProgressPropDetails);

            _eltProgressPropDetails = new TestObject(browser, EltProgressPropDetails);
            _eltProgressPropDetailsCheckmark = new TestObject(browser, EltProgressPropDetailsCheckmark);
            _eltProgressPropDetailsLinePropType = new TestObject(browser, EltProgressPropDetailsLinePropType);
            _eltProgressPropDetailsLineBedrooms = new TestObject(browser, EltProgressPropDetailsLineBedrooms);
            _eltProgressPropDetailsLinePropValue = new TestObject(browser, EltProgressPropDetailsLinePropValue);
            _eltProgressPropDetailsLineAddress = new TestObject(browser, EltProgressPropDetailsLineAddress);
            _eltProgressPropDetailsLabel = new TestObject(browser, EltProgressPropDetailsLabel);
            _eltProgressPropDetailsCheckmarkCircle = new TestObject(browser, EltProgressPropDetailsCheckmarkCircle);
            _eltProgressPropDetailsCheckmarkStem = new TestObject(browser, EltProgressPropDetailsCheckmarkStem);
            _eltProgressPropDetailsLineSectionPropType = new TestObject(browser, EltProgressPropDetailsLineSectionPropType);
            _eltProgressPropDetailsLineSectionBedrooms = new TestObject(browser, EltProgressPropDetailsLineSectionBedrooms);
            _eltProgressPropDetailsLineSectionPropValue = new TestObject(browser, EltProgressPropDetailsLineSectionPropValue);
            _eltProgressPropDetailsLineSectionAddress = new TestObject(browser, EltProgressPropDetailsLineSectionAddress);
            _eltProgressAgentPref = new TestObject(browser, EltProgressAgentPref);
            _eltProgressAgentPrefCheckmark = new TestObject(browser, EltProgressAgentPrefCheckmark);
            _eltProgressAgentPrefLineSpecificAgency = new TestObject(browser, EltProgressAgentPrefLineSpecificAgency);
            _eltProgressAgentPrefLineContactedAgency = new TestObject(browser, EltProgressAgentPrefLineContactedAgency);
            _eltProgressAgentPrefLabel = new TestObject(browser, EltProgressAgentPrefLabel);
            _eltProgressYourDetails = new TestObject(browser, EltProgressYourDetails);
            _eltProgressYourDetailsCheckmark = new TestObject(browser, EltProgressYourDetailsCheckmark);
            _eltProgressYourDetailsLabel = new TestObject(browser, EltProgressYourDetailsLabel);        
            _eltProgressAgentPrefCheckmarkCircle = new TestObject(browser, EltProgressAgentPrefCheckmarkCircle);
            _eltProgressAgentPrefCheckmarkStem = new TestObject(browser, EltProgressAgentPrefCheckmarkStem);
            _eltProgressAgentPrefLineSectionSpecificAgency = new TestObject(browser, EltProgressAgentPrefLineSectionSpecificAgency);
            _eltProgressAgentPrefLineSectionContactedAgency = new TestObject(browser, EltProgressAgentPrefLineSectionContactedAgency);
            _eltProgressYourDetailsCheckmarkCircle = new TestObject(browser, EltProgressYourDetailsCheckmarkCircle);
            _eltProgressYourDetailsCheckmarkStem = new TestObject(browser, EltProgressYourDetailsCheckmarkStem);
            _eltProgressYourDetailsCheckmark = new TestObject(browser, EltProgressYourDetailsCheckmark);
        }

        public VerificationInfo IsDisplayed()
        {

            return ListingCategory.IsDisplayed();
        }

        public void ShouldRegisterThePropertyWithDetails(string listingCategory, string propertyType, string bedrooms,
                                                         string approxValue, string apartmentNo, string streetNo,
                                                         string street, string suburb, string state, string postCode,
                                                         string leasedOption, string leasingDetails, string agentQuality, string specificAgency, string specificAgenciesDetails,
                                                         string contactedAgency, string contactedAgenciesDetails, string urgency, string firstName, string lastName,
                                                         string email, string phone, string customerDirectConnectAnswer, string directConnectDetails)
        {
            ListingCategory.SelectListingCategoryAs(listingCategory);
            PropertyType.SelectPropertyTypeAs(propertyType);
            Bedrooms.SelectBedroomAs(bedrooms);
            PropertyValue.SelectApproxValueAs(approxValue);
            PropertyAddress.EnterAddressManuallyAs(apartmentNo, streetNo, street, suburb, state, postCode);
            PropertyDescription.EnterLeasedInformation(leasedOption, leasingDetails);
            AgentQuality.SelectAgentQualityAs(agentQuality);
            SpecificAgencies.EnterSpecificAgenciesInformation(specificAgency, specificAgenciesDetails);
            ContactedAgencies.EnterContactedAgenciesInformation(contactedAgency, contactedAgenciesDetails);
            Urgency.SelectUrgencyAs(urgency);
            PersonalDetails.EnterPersonalDetailsAs(firstName, lastName, email, phone);
            PersonalDetails.EnterCustomerDirectConnectInformation(customerDirectConnectAnswer, directConnectDetails);
        }

        public void ShouldNavigateToPropTypeSectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ListingCategory.SelectListingCategoryAs(propRegFields.Category);
            PropertyType.IsDisplayed();
        }
        public void ShouldNavigateToBedroomSelectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToPropTypeSectionAfterEnteringDetailsAs(propRegFields);
            PropertyType.SelectPropertyTypeAs(propRegFields.PropType);
            Bedrooms.IsDisplayed();
        }

        public void ShouldNavigateToPropValueSectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToBedroomSelectionAfterEnteringDetailsAs(propRegFields);
            Bedrooms.SelectBedroomAs(propRegFields.Beds);
            PropertyValue.IsDisplayed();
        }

        public void ShouldNavigateToAddressSectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToPropValueSectionAfterEnteringDetailsAs(propRegFields);
            PropertyValue.SelectApproxValueAs(propRegFields.ApproxValue);
            PropertyAddress.IsDisplayed();
        }

        public void ShouldNavigateToPropertyDescAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToAddressSectionAfterEnteringDetailsAs(propRegFields);
            PropertyAddress.EnterAddressManuallyAs(propRegFields.UnitAppNo,propRegFields.StreetNo,propRegFields.Street,
                                                    propRegFields.Suburb, propRegFields.State, propRegFields.PostCode);

            PropertyDescription.IsDisplayed();
        }


        public void ShouldNavigateToAgentQualitySectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToPropertyDescAfterEnteringDetailsAs(propRegFields);
            PropertyDescription.EnterLeasedInformation(propRegFields.Leased, propRegFields.LeasingDetails);
            AgentQuality.IsDisplayed();
        }

        public void ShouldNavigateToSpecificAgenciesSectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToAgentQualitySectionAfterEnteringDetailsAs(propRegFields);
            AgentQuality.SelectAgentQualityAs(propRegFields.AgentQuality);
            SpecificAgencies.IsDisplayed();
        }

        public void ShouldNavigateToContactedAgenciesSectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToSpecificAgenciesSectionAfterEnteringDetailsAs(propRegFields);
            SpecificAgencies.EnterSpecificAgenciesInformation(propRegFields.SpecificAgency, propRegFields.SpecificAgenciesDetails);
            ContactedAgencies.IsDisplayed();
        }

        public void ShouldNavigateToUrgencySectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToContactedAgenciesSectionAfterEnteringDetailsAs(propRegFields);
            ContactedAgencies.EnterContactedAgenciesInformation(propRegFields.ContactedAgency,
                                                                propRegFields.ContactedAgenciesDetails);
            Urgency.IsDisplayed();
        }

        public void ShouldNavigateToCustomerDetailsSectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToUrgencySectionAfterEnteringDetailsAs(propRegFields);
            Urgency.SelectUrgencyAs(propRegFields.Urgency);
            PersonalDetails.IsDisplayed();
        }

        public void ShouldNavigateToDirectConnectSectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToCustomerDetailsSectionAfterEnteringDetailsAs(propRegFields);
            PersonalDetails.EnterPersonalDetailsAs(propRegFields.FirstName,propRegFields.LastName,
                                                    propRegFields.Email,propRegFields.Phone);
      
        }

        public void ShouldNavigateToPropRegThankYouSectionAfterEnteringDetailsAs(PropertyRegistrationFields propRegFields)
        {
            ShouldNavigateToDirectConnectSectionAfterEnteringDetailsAs(propRegFields);
            PersonalDetails.EnterCustomerDirectConnectInformation(propRegFields.CustomerDirectConnectAnswer, 
                                                        propRegFields.DirectConnectDetails);
        }

        public VerificationInfo NavigateToApproxValueSelectionForRent()
        {
            ListingCategory.SelectListingCategoryAs(ListingCategoryEnum.Rent.ToString());
            PropertyType.SelectPropertyTypeAs(PropertyTypeEnum.House.ToString());
            Bedrooms.SelectBedroomAs(BedroomsEnum.One.ToString());
            return PropertyValue.IsDisplayed();
        }

        public VerificationInfo NavigateToApproxValueSelectionForSell()
        {
            ListingCategory.SelectListingCategoryAs(ListingCategoryEnum.Sell.ToString());
            PropertyType.SelectPropertyTypeAs(PropertyTypeEnum.House.ToString());
            Bedrooms.SelectBedroomAs(BedroomsEnum.One.ToString());
            return PropertyValue.IsDisplayed();
        }

        public bool IsPropertyDetailsProgressActive()
        {
            return _eltPropertyDetailsProgress.GetClassAttributeValue().Contains("active");
        }

        public VerificationInfo IsBackLinkDisabled()
        {
            VerificationInfo info = new VerificationInfo();
            if (_lnkBack.GetClassAttributeValue().Contains("not-active"))
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _lnkBack.GetClassAttributeValue();

            return info;
        }

        public VerificationInfo IsForwardLinkDisabled()
        {
            VerificationInfo info = new VerificationInfo();
            if (_lnkForward.GetClassAttributeValue().Contains("not-active"))
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }

            info.Actual = _lnkForward.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo IsForwardLinkEnabled()
        {
            VerificationInfo info = new VerificationInfo();
            if (_lnkForward.GetClassAttributeValue().Contains("not-active"))
            {
                info.Result = false;
            }
            else
            {
                info.Result = true;
            }
            info.Actual = _lnkForward.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyBothTheLinksForMovingBackForwardAreDisabled()
        {
            VerificationInfo info = new VerificationInfo();
            if (IsBackLinkDisabled().Result && IsForwardLinkDisabled().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }

            info.Actual = IsBackLinkDisabled().Actual + "-" + IsForwardLinkDisabled().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfPropertyDetailsTrackingInProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressPropDetailsLabel.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfAgentDetailsTrackingInProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressAgentPrefLabel.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfYourDetailsTrackingInProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressYourDetailsLabel.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatPropertyIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();

            if (_eltProgressPropDetails.GetClassAttributeValue().Contains("active")
            && _eltProgressPropDetailsCheckmarkCircle.VerifyColorForActive().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }

            info.Actual = _eltProgressPropDetails.GetClassAttributeValue() + "-" + _eltProgressPropDetailsCheckmarkCircle.VerifyColorForActive().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatAgentIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentPref.GetClassAttributeValue().Contains("active")
                   && _eltProgressAgentPrefCheckmarkCircle.VerifyColorForActive().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }

            info.Actual = _eltProgressAgentPref.GetClassAttributeValue() + "-" + _eltProgressAgentPrefCheckmarkCircle.VerifyColorForActive().Actual;

            return info;
        }

        public VerificationInfo ShouldVerifyThatAgentIsNotActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentPref.GetClassAttributeValue().Contains("active")
             && _eltProgressAgentPrefCheckmarkCircle.VerifyColorForActive().Result)
            {
                info.Result = false;
            }
            else
            {
                info.Result = true;
            }
            info.Actual = _eltProgressAgentPref.GetClassAttributeValue() + "-" + _eltProgressAgentPrefCheckmarkCircle.VerifyColorForActive().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatYouIsActiveInProgressBar()
        {

            VerificationInfo info = new VerificationInfo();
            if (_eltProgressYourDetails.GetClassAttributeValue().Contains("active")
                   && _eltProgressYourDetailsCheckmarkCircle.VerifyColorForActive().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }

            info.Actual = _eltProgressYourDetails.GetClassAttributeValue() + "-" + _eltProgressYourDetailsCheckmarkCircle.VerifyColorForActive().Actual;
            return info;
        }


        public VerificationInfo ShouldVerifyThatYouIsNotActiveInProgressBar()
        {

            VerificationInfo info = new VerificationInfo();
            if (_eltProgressYourDetails.GetClassAttributeValue().Contains("active")
                   && _eltProgressYourDetailsCheckmarkCircle.VerifyColorForActive().Result)
            {
                info.Result = false;
            }
            else
            {
                info.Result = true;
            }

            info.Actual = _eltProgressYourDetails.GetClassAttributeValue() + "-" + _eltProgressYourDetailsCheckmarkCircle.VerifyColorForActive().Actual;
            return info;
        }


        public VerificationInfo ShouldVerifyThatPropertyCircleIsFilledInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPropDetailsCheckmark.GetClassAttributeValue().Contains("complete")
                   && _eltProgressPropDetailsCheckmarkCircle.VerifyPropRegProgressCircleForActive().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressPropDetailsCheckmark.GetClassAttributeValue() + "-" + _eltProgressPropDetailsCheckmarkCircle.VerifyPropRegProgressCircleForActive().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatPropertyCircleIsNotFilledInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPropDetailsCheckmark.GetClassAttributeValue().Contains("complete")
                   && _eltProgressPropDetailsCheckmarkCircle.VerifyPropRegProgressCircleForActive().Result)
            {
                info.Result = false;
            }
            else
            {
                info.Result = true;
            }
            info.Actual = _eltProgressPropDetailsCheckmark.GetClassAttributeValue() + "-" + _eltProgressPropDetailsCheckmarkCircle.VerifyPropRegProgressCircleForActive().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatProgressLineIndicatesFillingOfPropType()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPropDetailsLinePropType.GetClassAttributeValue().Contains("complete")
                   && _eltProgressPropDetailsLineSectionPropType.VerifyPropRegProgressLine().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressPropDetailsLinePropType.GetClassAttributeValue() + "-" + _eltProgressPropDetailsLineSectionPropType.VerifyPropRegProgressLine().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatProgressLineIndicatesFillingOfBedrooms()
        {

            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPropDetailsLineBedrooms.GetClassAttributeValue().Contains("complete")
                   && _eltProgressPropDetailsLineSectionBedrooms.VerifyPropRegProgressLine().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressPropDetailsLineBedrooms.GetClassAttributeValue() + "-" + _eltProgressPropDetailsLineSectionBedrooms.VerifyPropRegProgressLine().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatProgressLineIndicatesFillingOfPropValue()
        {
            VerificationInfo info = new VerificationInfo();
            info.Actual = _eltProgressPropDetailsLinePropValue.GetClassAttributeValue() + "-" + _eltProgressPropDetailsLineSectionPropValue.VerifyPropRegProgressLine().Actual;
            System.Console.WriteLine(info.Actual);
            if (_eltProgressPropDetailsLinePropValue.GetClassAttributeValue().Contains("complete")
            && _eltProgressPropDetailsLineSectionPropValue.VerifyPropRegProgressLine().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressPropDetailsLinePropValue.GetClassAttributeValue() + "-" + _eltProgressPropDetailsLineSectionPropValue.VerifyPropRegProgressLine().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatProgressLineIndicatesFillingOfAddress()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPropDetailsLineAddress.GetClassAttributeValue().Contains("complete")
            && _eltProgressPropDetailsLineSectionAddress.VerifyPropRegProgressLine().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressPropDetailsLineAddress.GetClassAttributeValue() + "-" + _eltProgressPropDetailsLineSectionAddress.VerifyPropRegProgressLine().Actual;
            return info;

        }

        public VerificationInfo ShouldVerifyThatPropertyCircleIsCheckedInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentPrefCheckmark.GetClassAttributeValue().Contains("complete")
             && (_eltProgressPropDetailsCheckmarkStem.IsDisplayed()))
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressAgentPrefCheckmark.GetClassAttributeValue() + "-" + _eltProgressPropDetailsCheckmarkStem.IsDisplayed();
            return info;

        }

        public VerificationInfo ShouldVerifyThatAgentCircleIsFilledInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentPrefCheckmark.GetClassAttributeValue().Contains("complete")
                   && _eltProgressAgentPrefCheckmarkCircle.VerifyPropRegProgressCircleForActive().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressAgentPrefCheckmark.GetClassAttributeValue() + "-" + _eltProgressAgentPrefCheckmarkCircle.VerifyPropRegProgressCircleForActive().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatAgentCircleIsNotFilledInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentPrefCheckmark.GetClassAttributeValue().Contains("complete")
                   && _eltProgressAgentPrefCheckmarkCircle.VerifyPropRegProgressCircleForActive().Result)
            {
                info.Result = false;
            }
            else
            {
                info.Result = true;
            }
            info.Actual = _eltProgressAgentPrefCheckmark.GetClassAttributeValue() + "-" + _eltProgressAgentPrefCheckmarkCircle.VerifyPropRegProgressCircleForActive().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatProgressLineIndicatesFillingOfSpecificAgency()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentPrefLineSpecificAgency.GetClassAttributeValue().Contains("complete")
                   && _eltProgressAgentPrefLineSectionSpecificAgency.VerifyPropRegProgressLine().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressAgentPrefLineSpecificAgency.GetClassAttributeValue() + "-" + _eltProgressAgentPrefLineSectionSpecificAgency.VerifyPropRegProgressLine().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatProgressLineIndicatesFillingOfContactedAgency()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentPrefLineContactedAgency.GetClassAttributeValue().Contains("complete")
                   && _eltProgressAgentPrefLineSectionContactedAgency.VerifyPropRegProgressLine().Result)
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressAgentPrefLineContactedAgency.GetClassAttributeValue() + "-" + _eltProgressAgentPrefLineSectionContactedAgency.VerifyPropRegProgressLine().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatAgentCircleIsCheckedInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentPrefCheckmark.GetClassAttributeValue().Contains("complete")
             && (_eltProgressAgentPrefCheckmarkStem.IsDisplayed()))
            {
                info.Result = true;
            }
            else
            {
                info.Result = false;
            }
            info.Actual = _eltProgressAgentPrefCheckmark.GetClassAttributeValue() + "-" + _eltProgressAgentPrefCheckmarkStem.IsDisplayed();
            return info;
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string questionString)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = questionString;
            info.Actual = GetQuestionText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private string GetQuestionText()
        {
            return _elementQ.GetText();
        }

    }

}