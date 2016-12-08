using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;
using LAFTestAutomationFramework.Funnel.AgentRegistration;
using LAFTestAutomationFramework.Funnel.AgentRegistration.Slides;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration
{
    public class AgentRegistrationFunnel : AgentRegistrationUIMap
    {
        public BeginAgentRegistration BeforeYouStart;  
        public AgentInterests AgentInterests;
        public AgentDetails AgentDetails;
        public AgencyDetails AgencyDetails;
        public PrincipalDetails PrincipalDetails;
        public KeyInfo KeyInfo;
        public TermsAndConditions TermsAndConditions;
        public AgentWelcome AgentWelcome;
        public BeginAgentProposal BeginAgentProposal;

        private readonly TestObject _elementQ;

        private readonly TestObject _eltProgressAboutYouSection;
        private readonly TestObject _eltProgressAboutYouCheckmark;
        private readonly TestObject _eltProgressAboutYouCheckmarkCircle;
        private readonly TestObject _eltProgressAboutYouLabel;

        private readonly TestObject _eltProgressAgentSignUpLineAgentDetails;
        private readonly TestObject _eltProgressAgentSignUpLineSectionAgentDetails;

        private readonly TestObject _eltProgressAgencySection;
        private readonly TestObject _eltProgressAgencyCheckmark;
        private readonly TestObject _eltProgressAgencyCheckmarkCircle;
        private readonly TestObject _eltProgressAgencyLabel;

        private readonly TestObject _eltProgressAgentSignUpLinePrincipalDetails;
        private readonly TestObject _eltProgressAgentSignUpLineSectionPrincipalDetails;

        private readonly TestObject _eltProgressKeyInfoSection;
        private readonly TestObject _eltProgressKeyInfoCheckmark;
        private readonly TestObject _eltProgressKeyInfoCheckmarkCircle;
        private readonly TestObject _eltProgressKeyInfoLabel;

        private readonly TestObject _eltProgressTermsAndCondSection;
        private readonly TestObject _eltProgressTermsAndCondCheckmark;
        private readonly TestObject _eltProgressTermsAndCondCheckmarkCircle;
        private readonly TestObject _eltProgressTermsAndCondLabel;

        private readonly TestObject _lnkBack;
        private readonly TestObject _lnkForward;
        private readonly TestObject _errors;



        public AgentRegistrationFunnel(Browser browser) : base()

        {
            BeforeYouStart = new BeginAgentRegistration(browser, EltbeforeYouStartSlide,
                                                        EltBeforeYouStartHeading, LnkNext);

            AgentInterests = new AgentInterests(browser, EltpropCategorySlide,
                                            LnkSales, LnkRentals, LnkBoth, LnkForward,
                                            EltAgentInterestQuestion);

            AgentDetails = new AgentDetails(browser, EltaboutYouSlide, TxtAgentFirstName, 
                                            TxtAgentLastName, TxtAgentPhoneNumber, TxtAgentMobile,
                                            TxtAgentEmail, LstAgentPosition, LnkNextAboutYou, LnkBack, EltAgentPersonalDetailsQuestion,
                                            EltErrors);

            AgencyDetails = new AgencyDetails(browser, EltagencyDetailsSlide, 
                                              LnkEnterAddressManually, TxtUnitAppNo, 
                                              TxtStreetNo, TxtStreet, 
                                              TxtSuburb, TxtState, 
                                              TxtPostcode, LnkNextAboutYourAgency, 
                                              LnkBack, TxtAddressSearch,
                                              EltMatchingAddressListItem, 
                                              TxtAgencyName, TxtBranchName, 
                                              EltAgencyDetailsHeading, LnkManualAddress,
                                              EltErrors);

            PrincipalDetails = new PrincipalDetails(browser, EltAreYouThePrincipalSlide, 
                                                    TxtPrincipalFirstName, TxtPrincipalLastName,
                                                     TxtPrincipalEmail, LnkNextPrincipalDetails, 
                                                     BtnIsPrincipalYes,BtnIsPrincipalNo,
                                                     EltAreYouPrincipalQuestion, EltErrors);

            KeyInfo = new KeyInfo(browser, EltKeyInfoSlide, BtnAcceptAndContinue, EltKeyInfoHeading, EltRentalsKeyInfo, EltSalesKeyInfo);

            TermsAndConditions = new TermsAndConditions(browser, EltTermsAndCondSlide, BtnAcceptTerms, EltTermsContainer, ChkAcceptTermsandCond, EltErrors, LnkExpandTermsandCond,
                                                        EltTermsHeading, BtnCloseTermsPopup);

            AgentWelcome = new AgentWelcome(browser, EltAgentRegCompleteMessage, BtnCreateMyProfile, EltAgentWelcomeTextContFirstName);

            BeginAgentProposal = new BeginAgentProposal(browser, BtnBegin, EltBeginProposalHeading);

            _elementQ = new TestObject(browser, EltQuestion);

            _eltProgressAboutYouSection = new TestObject(browser, EltProgressAboutYouSection);
            _eltProgressAboutYouCheckmark = new TestObject(browser, EltProgressAboutYouCheckmark);
            _eltProgressAboutYouCheckmarkCircle = new TestObject(browser, EltProgressAboutYouCheckmarkCircle);
            _eltProgressAboutYouLabel = new TestObject(browser, EltProgressAboutYouLabel);

            _eltProgressAgentSignUpLineAgentDetails = new TestObject(browser, EltProgressAgentSignUpLineAgentDetails);
            _eltProgressAgentSignUpLineSectionAgentDetails = new TestObject(browser, EltProgressAgentSignUpLineSectionAgentDetails);

            _eltProgressAgencySection = new TestObject(browser, EltProgressAgencySection);
            _eltProgressAgencyCheckmark = new TestObject(browser, EltProgressAgencyCheckmark);
            _eltProgressAgencyCheckmarkCircle = new TestObject(browser, EltProgressAgencyCheckmarkCircle);
            _eltProgressAgencyLabel = new TestObject(browser, EltProgressAgencyLabel);

            _eltProgressAgentSignUpLinePrincipalDetails = new TestObject(browser, EltProgressAgentSignUpLinePrincipalDetails);
            _eltProgressAgentSignUpLineSectionPrincipalDetails = new TestObject(browser, EltProgressAgentSignUpLineSectionPrincipalDetails);

            _eltProgressKeyInfoSection = new TestObject(browser, EltProgressKeyInfoSection);
            _eltProgressKeyInfoCheckmark = new TestObject(browser, EltProgressKeyInfoCheckmark);
            _eltProgressKeyInfoCheckmarkCircle = new TestObject(browser, EltProgressKeyInfoCheckmarkCircle);
            _eltProgressKeyInfoLabel = new TestObject(browser, EltProgressKeyInfoLabel);


            _eltProgressTermsAndCondSection = new TestObject(browser, EltProgressTermsAndCondSection);
            _eltProgressTermsAndCondCheckmark = new TestObject(browser, EltProgressTermsAndCondCheckmark);
            _eltProgressTermsAndCondCheckmarkCircle = new TestObject(browser, EltProgressTermsAndCondCheckmarkCircle);
            _eltProgressTermsAndCondLabel = new TestObject(browser, EltProgressTermsAndCondLabel);
            _lnkBack = new TestObject(browser, LnkBack);
            _lnkForward = new TestObject(browser, LnkForward);
            _errors = new TestObject(browser, EltErrors);

        }

        public bool VerifyErrorExists(string errString)
        {
            return _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString);

        }

        public VerificationInfo ShouldVerifyThatAgencyIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgencyCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressAgencyCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatKeyInfoIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressKeyInfoCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressKeyInfoCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatTermsAndCondIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressTermsAndCondCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressTermsAndCondCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfAgentPersonalDetailsTrackingInProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressAboutYouLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfKeyInfoTrackingInProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressKeyInfoLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfTermsAndCondTrackingInProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressTermsAndCondLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatAboutYouCircleIsFilledInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAboutYouCheckmark.GetClassAttributeValue().Contains("complete")
                   && _eltProgressAboutYouCheckmarkCircle.VerifyAgentRegProgressCircleForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfAgencyDetailsTrackingInProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressAgencyLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string questionString)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = questionString;
            info.Actual = GetQuestionText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        private string GetQuestionText()
        {
            return _elementQ.GetText();
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

        public void ShouldNavigateToAgentInterestsSection()
        {
            BeforeYouStart.ShouldTakeMeToInterestSelection();
            AgentInterests.IsDisplayed();
        }

        public void ShouldNavigateToAgentPersonalDetailsSectionAfterEnteringDetailsAs(AgentRegistrationFields agentRegFields)
        {
            ShouldNavigateToAgentInterestsSection();
            AgentInterests.SelectPropertyCategoryAs(agentRegFields.Interest);
            AgentDetails.IsDisplayed();
        }

        public void ShouldNavigateToAgencyDetailsSectionAfterEnteringDetailsAs(AgentRegistrationFields agentRegFields)
        {
            ShouldNavigateToAgentPersonalDetailsSectionAfterEnteringDetailsAs(agentRegFields);
            AgentDetails.EnterAgentDetailsAs(agentRegFields.AgentFirstName, agentRegFields.AgentLastName, agentRegFields.AgentPhone,
                                             agentRegFields.AgentMobile, agentRegFields.AgentEmail, agentRegFields.AgentPosition);
            AgencyDetails.IsDisplayed();
        }

        public void ShouldNavigateToPrincipalDetailsSectionAfterEnteringDetailsAs(AgentRegistrationFields agentRegFields)
        {
            ShouldNavigateToAgencyDetailsSectionAfterEnteringDetailsAs(agentRegFields);
            AgencyDetails.EnterAgencyDetailsAs(agentRegFields.AgencyUnitAppNo, agentRegFields.AgencyStreetNo, agentRegFields.AgencyStreet,
                                                agentRegFields.AgencySuburb, agentRegFields.AgencyState, agentRegFields.AgencyPostCode,
                                                agentRegFields.AgencyName, agentRegFields.AgencyBranch);
            PrincipalDetails.IsDisplayed();
        }

        public void ShouldNavigateToKeyInfoSectionAfterEnteringDetailsAs(AgentRegistrationFields agentRegFields)
        {
            ShouldNavigateToPrincipalDetailsSectionAfterEnteringDetailsAs(agentRegFields);
            PrincipalDetails.EnterPrincipalDetailsAs(agentRegFields.PrincipalFirstName, agentRegFields.PrincipalLastName,
                                                    agentRegFields.PrincipalEmail);
            KeyInfo.IsDisplayed();
        }

        public void ShouldNavigateToTermsAndCondAfterEnteringDetailsAs(AgentRegistrationFields agentRegFields)
        {
            ShouldNavigateToKeyInfoSectionAfterEnteringDetailsAs(agentRegFields);
            KeyInfo.SelectAcceptAndContinue();
            TermsAndConditions.IsDisplayed();
        }

        public void ShouldNavigateToAgentWelcomeAfterEnteringDetailsAs(AgentRegistrationFields agentRegFields)
        {
            ShouldNavigateToTermsAndCondAfterEnteringDetailsAs(agentRegFields);
            TermsAndConditions.AcceptTheTerms();
            AgentWelcome.IsDisplayed();
        }

        public void ShouldNavigateToBeginProposalAfterEnteringDetailsAs(AgentRegistrationFields agentRegFields)
        {
            ShouldNavigateToAgentWelcomeAfterEnteringDetailsAs(agentRegFields);
            AgentWelcome.SelectCreateProfile();
            BeginAgentProposal.IsDisplayed();
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

        public VerificationInfo IsBackLinkEnabled()
        {
            VerificationInfo info = new VerificationInfo();
            if (_lnkBack.GetClassAttributeValue().Contains("not-active"))
            {
                info.Result = false;
            }
            else
            {
                info.Result = true;
            }
            info.Actual = _lnkBack.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLinksForMovingBackIsDisabled()
        {
            return IsBackLinkDisabled();
        }

        public VerificationInfo ShouldVerifyThatProgressLineIndicatesEntryOfAgentBasicDetails()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentSignUpLineAgentDetails.GetClassAttributeValue().Contains("complete")
                   && _eltProgressAgentSignUpLineSectionAgentDetails.VerifyAgentRegProgressLine().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressAgentSignUpLineAgentDetails.GetClassAttributeValue() + "-" + _eltProgressAgentSignUpLineSectionAgentDetails.VerifyAgentRegProgressLine().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatAboutYouCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAboutYouSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressAboutYouSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ProgressLineForAgentDetailsIsFilledAndAboutYouCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (ShouldVerifyThatAboutYouCircleIsChecked().Result 
                && ShouldVerifyThatProgressLineIndicatesEntryOfAgentBasicDetails().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = ShouldVerifyThatAboutYouCircleIsChecked().Actual + "-" + ShouldVerifyThatProgressLineIndicatesEntryOfAgentBasicDetails().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatAgencyCircleIsFilledInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgencyCheckmark.GetClassAttributeValue().Contains("complete")
                   && _eltProgressAgencyCheckmarkCircle.VerifyAgentRegProgressCircleForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressAgencyCheckmark.GetClassAttributeValue() + "-" + _eltProgressAgencyCheckmarkCircle.VerifyAgentRegProgressCircleForActive().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatProgressLineIndicatesEntryOfPrincipalDetails()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressAgentSignUpLinePrincipalDetails.GetClassAttributeValue().Contains("complete")
                   && _eltProgressAgentSignUpLineSectionPrincipalDetails.VerifyAgentRegProgressLine().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressAgentSignUpLinePrincipalDetails.GetClassAttributeValue() + "-" + _eltProgressAgentSignUpLineSectionPrincipalDetails.VerifyAgentRegProgressLine().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatTAndCsCircleIsFilledInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressTermsAndCondCheckmark.GetClassAttributeValue().Contains("complete")
                  && _eltProgressTermsAndCondCheckmarkCircle.VerifyAgentRegProgressCircleForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressTermsAndCondCheckmark.GetClassAttributeValue() + "-" + _eltProgressTermsAndCondCheckmarkCircle.VerifyAgentRegProgressCircleForActive().Actual;
            return info;
        }
    }
}
