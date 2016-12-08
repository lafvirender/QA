using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;
using LAFTestAutomationFramework.Funnel.AgentProposalForRent.Slides;
namespace LAFTestAutomationFramework.Funnel.AgentProposalForRent
{

    public class AgentProposalForRentFunnel : AgentProposalForRentUIMap
    {
        public BeginAgentProposal BeginAgentProposal;
        public PropertyManagementTeamSize PropertyManagementTeam;
        public PropertyPerPropertyManager PropertyPerPropertyManager;
        public Languages Languages;
        public EmergencyContact EmergencyContact;
        public LandlordInsuranceAdvice LandlordInsuranceAdvice;
        public InspectionFrequency InspectionFrequency;
        public PostCodeSelection PostCodeSelection;
        public RentalAgentBiography RentalAgentBiography;
        public AgentRentalFeeStructure AgentRentalFeeStructure;
        public RentalProposalConfirmation RentalProposalConfirmation;

        private readonly TestObject _elementQ;
        private readonly TestObject _lnkForward;
        private readonly TestObject _lnkBack;


        private readonly TestObject _eltProgressTeamSizeSection;
        private readonly TestObject _eltProgressTeamSizeCheckmark;
        private readonly TestObject _eltProgressTeamSizeCheckmarkCircle;
        private readonly TestObject _eltProgressTeamSizeLabel;

        private readonly TestObject _eltProgressPropPerManagerSection;
        private readonly TestObject _eltProgressPropPerManagerCheckmark;
        private readonly TestObject _eltProgressPropPerManagerCheckmarkCircle;
        private readonly TestObject _eltProgressPropPerManagerLabel;

        private readonly TestObject _eltProgressLanguagesSection;
        private readonly TestObject _eltProgressLanguagesCheckmark;
        private readonly TestObject _eltProgressLanguagesCheckmarkCircle;
        private readonly TestObject _eltProgressLanguagesLabel;

        private readonly TestObject _eltProgressEmergencyContactSection;
        private readonly TestObject _eltProgressEmergencyContactCheckmark;
        private readonly TestObject _eltProgressEmergencyContactCheckmarkCircle;
        private readonly TestObject _eltProgressEmergencyContactLabel;

        private readonly TestObject _eltProgressLandlordInsuranceAdvSection;
        private readonly TestObject _eltProgressLandlordInsuranceAdvCheckmark;
        private readonly TestObject _eltProgressLandlordInsuranceAdvCheckmarkCircle;
        private readonly TestObject _eltProgressLandlordInsuranceAdvLabel;

        private readonly TestObject _eltProgressInspectionFreqSection;
        private readonly TestObject _eltProgressInspectionFreqCheckmark;
        private readonly TestObject _eltProgressInspectionFreqCheckmarkCircle;
        private readonly TestObject _eltProgressInspectionFreqLabel;

        private readonly TestObject _eltProgressPostCodesSection;
        private readonly TestObject _eltProgressPostCodesCheckmark;
        private readonly TestObject _eltProgressPostCodesCheckmarkCircle;
        private readonly TestObject _eltProgressPostCodesLabel;


        private readonly TestObject _eltProgressBiographySection;
        private readonly TestObject _eltProgressBiographyCheckmark;
        private readonly TestObject _eltProgressBiographyCheckmarkCircle;
        private readonly TestObject _eltProgressBiographyLabel;

        private readonly TestObject _eltProgressFeesSection;
        private readonly TestObject _eltProgressFeesCheckmark;
        private readonly TestObject _eltProgressFeesCheckmarkCircle;
        private readonly TestObject _eltProgressFeesLabel;



        public AgentProposalForRentFunnel(Browser browser) : base()
        {
            BeginAgentProposal = new BeginAgentProposal(browser, BtnBegin, EltBeginProposalHeading);

            PropertyManagementTeam = new PropertyManagementTeamSize(browser, EltPropertyManagmentTeamSizeSlide, 
                                                                    EltPropertyMgmtTeamSizeQuestion, TxtPropMgmtTeamSize,
                                                                  BtnNextPropMgmtTeam, EltErrors);

            PropertyPerPropertyManager = new PropertyPerPropertyManager(browser, EltPropPerPropManagerSlide, EltPropertyPerPropManagerQ,
                                                                        TxtPropPerPropManager, BtnNextPropPerPropManager, EltErrors);

            Languages = new Languages(browser, EltLanguagesSlide, BtnArabic, BtnCantonese, BtnCroatian,
                                     BtnDutch, BtnFrench, BtnGreek, BtnHebrew, BtnHindi, BtnHungarian,
                                     BtnIndonesian, BtnEnglish, BtnItalian, BtnJapanese, BtnKorean,
                                     BtnLebanese, BtnMacedonian, BtnMaltese, BtnMandarin, BtnPersian,
                                     BtnPolish, BtnPortuguese, BtnRussian, BtnSerbian, BtnSpanish, BtnSriLankan,
                                     BtnTagalog, BtnThai, BtnTurkish, BtnVietnamese, BtnNextLanguages, EltLanguageSelectionQuestion);

            EmergencyContact = new EmergencyContact(browser,EltEmergencyContactSlide,EltEmergencyContactQuestion,BtnEmergencyContactYes, BtnEmergencyContactNo, LnkBack,
                                                   LnkForward);
            LandlordInsuranceAdvice = new LandlordInsuranceAdvice(browser, EltLandlordInsuranceAdviceSlide, EltLandlordInsuranceAdviceQuestion, 
                                                                    BtnLandlordInsuranceAdviceYes, BtnLandlordInsuranceAdviceNo, LnkForward, LnkBack);

            InspectionFrequency = new InspectionFrequency(browser,EltInspectionFreqSlide,EltInspectionFreqQuestion,LstInspectionFreqPeriod, BtnNextInspection,
                                                            LnkForward, LnkBack);

            PostCodeSelection = new PostCodeSelection(browser, EltPostCodeSelectionSlide,
                                                     BtnNextPostcodes, TxtPostCode1, TxtPostCode2, 
                                                     TxtPostCode3, TxtPostCode4, 
                                                     TxtPostCode5, LnkBack, LnkForward,
                                                     EltPostcodesSelectionQuestion);

            RentalAgentBiography = new RentalAgentBiography(browser,EltAgentBiographySlide, 
                                                LnkForward, LnkBack, BtnNextBiography, LnkAboutYou, 
                                                TxtAboutYouDetails, LnkAboutYourAgency, 
                                                TxtAboutYourAgencyDetails, LnkMarketingSellingApproach,
                                                TxtMarketingSellingApproachDetails, EltAgentBiographyQuestion);

            AgentRentalFeeStructure = new AgentRentalFeeStructure(browser,EltAgentRentalFeeStructureSlide, EltAgentRentalFeeStructureQuestion,
                                                                   LstLettingFee, TxtManagementFee, LstMarketingBudget, BtnRentalFeeStructureSubmit,
                                                                   EltErrors);

            RentalProposalConfirmation = new RentalProposalConfirmation(browser, EltConfirmationMessage, BtnGoToYourPortal, EltAgentDashboardWelcomeMsg);

            _elementQ = new TestObject(browser, EltQuestion);
            _lnkForward = new TestObject(browser, LnkForward);

            _eltProgressTeamSizeSection = new TestObject(browser, EltProgressTeamSizeSection);
            _eltProgressTeamSizeCheckmark = new TestObject(browser, EltProgressTeamSizeCheckmark);
            _eltProgressTeamSizeCheckmarkCircle = new TestObject(browser, EltProgressTeamSizeCheckmarkCircle);
            _eltProgressTeamSizeLabel = new TestObject(browser, EltProgressTeamSizeLabel);

            _eltProgressPropPerManagerSection = new TestObject(browser, EltProgressPropPerManagerSection);
            _eltProgressPropPerManagerCheckmark = new TestObject(browser, EltProgressPropPerManagerCheckmark);
            _eltProgressPropPerManagerCheckmarkCircle = new TestObject(browser, EltProgressPropPerManagerCheckmarkCircle);
            _eltProgressPropPerManagerLabel = new TestObject(browser, EltProgressPropPerManagerLabel);

            _eltProgressLanguagesSection = new TestObject(browser, EltProgressLanguagesSection);
            _eltProgressLanguagesCheckmark = new TestObject(browser, EltProgressLanguagesCheckmark);
            _eltProgressLanguagesCheckmarkCircle = new TestObject(browser, EltProgressLanguagesCheckmarkCircle);
            _eltProgressLanguagesLabel = new TestObject(browser, EltProgressLanguagesLabel);

            _eltProgressEmergencyContactSection = new TestObject(browser, EltProgressEmergencyContactSection);
            _eltProgressEmergencyContactCheckmark = new TestObject(browser, EltProgressEmergencyContactCheckmark);
            _eltProgressEmergencyContactCheckmarkCircle = new TestObject(browser, EltProgressEmergencyContactCheckmarkCircle);
            _eltProgressEmergencyContactLabel = new TestObject(browser, EltProgressEmergencyContactLabel);

            _eltProgressLandlordInsuranceAdvSection = new TestObject(browser, EltProgressLandlordInsuranceAdvSection);
            _eltProgressLandlordInsuranceAdvCheckmark = new TestObject(browser, EltProgressLandlordInsuranceAdvCheckmark);
            _eltProgressLandlordInsuranceAdvCheckmarkCircle = new TestObject(browser, EltProgressLandlordInsuranceAdvCheckmarkCircle);
            _eltProgressLandlordInsuranceAdvLabel = new TestObject(browser, EltProgressLandlordInsuranceAdvLabel);

            _eltProgressInspectionFreqSection = new TestObject(browser, EltProgressInspectionFreqSection);
            _eltProgressInspectionFreqCheckmark = new TestObject(browser, EltProgressInspectionFreqCheckmark);
            _eltProgressInspectionFreqCheckmarkCircle = new TestObject(browser, EltProgressInspectionFreqCheckmarkCircle);
            _eltProgressInspectionFreqLabel = new TestObject(browser, EltProgressInspectionFreqLabel);

            _eltProgressPostCodesSection = new TestObject(browser, EltProgressPostCodesSection);
            _eltProgressPostCodesCheckmark = new TestObject(browser, EltProgressPostCodesCheckmark);
            _eltProgressPostCodesCheckmarkCircle = new TestObject(browser, EltProgressPostCodesCheckmarkCircle);
            _eltProgressPostCodesLabel = new TestObject(browser, EltProgressPostCodesLabel);


            _eltProgressBiographySection = new TestObject(browser, EltProgressBiographySection);
            _eltProgressBiographyCheckmark = new TestObject(browser, EltProgressBiographyCheckmark);
            _eltProgressBiographyCheckmarkCircle = new TestObject(browser, EltProgressBiographyCheckmarkCircle);
            _eltProgressBiographyLabel = new TestObject(browser, EltProgressBiographyLabel);

            _eltProgressFeesSection = new TestObject(browser, EltProgressFeesSection);
            _eltProgressFeesCheckmark = new TestObject(browser, EltProgressFeesCheckmark);
            _eltProgressFeesCheckmarkCircle = new TestObject(browser, EltProgressFeesCheckmarkCircle);
            _eltProgressFeesLabel = new TestObject(browser, EltProgressFeesCheckmarkCircle);

            _lnkForward = new TestObject(browser, LnkForward);
            _lnkBack = new TestObject(browser, LnkBack);
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string questionString)
        {
            VerificationInfo info = new VerificationInfo();
            info.Actual = questionString;
            info.Expected = _elementQ.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void ShouldNavigateToPropertyManagementTeamSizeSelectionPage()
        {
            BeginAgentProposal.SelectBegin();
            PropertyManagementTeam.IsDisplayed();
        }

        public void ShouldNavigateToPropertyPerPropManagerPageAfterEnteringDetailsAs(LandlordProposalFields landlordPropFields)
        {
            ShouldNavigateToPropertyManagementTeamSizeSelectionPage();
            PropertyManagementTeam.SetPropMgmtTeamSizeAs(landlordPropFields.PropertyMgmtTeamSize);
            PropertyPerPropertyManager.IsDisplayed();
        }

        public void ShouldNavigateToLanguageSelectionPageAfterEnteringDetailsAs(LandlordProposalFields landlordPropFields)
        {
            ShouldNavigateToPropertyPerPropManagerPageAfterEnteringDetailsAs(landlordPropFields);
            PropertyPerPropertyManager.SetPropPerPropManagerFieldAs(landlordPropFields.PropertyPerPropManager);
            Languages.IsDisplayed();
        }

        public void ShouldNavigateToEmergencyContactPageAfterEnteringDetailsAs(LandlordProposalFields landlordPropFields)
        {
            ShouldNavigateToLanguageSelectionPageAfterEnteringDetailsAs(landlordPropFields);
            Languages.SelectLanguagesAs(landlordPropFields.Languages);
            EmergencyContact.IsDisplayed();
        }


        public void ShouldNavigateToLandlordInsuranceAdvicePageAfterEnteringDetailsAs(LandlordProposalFields landlordPropFields)
        {
            ShouldNavigateToEmergencyContactPageAfterEnteringDetailsAs(landlordPropFields);
            EmergencyContact.SelectOptionAs(landlordPropFields.EmergencyContact);
            LandlordInsuranceAdvice.IsDisplayed();
        }

        public void ShouldNavigateToInspectionFreqPeriodPageAfterEnteringDetailsAs(LandlordProposalFields landlordPropFields)
        {
            ShouldNavigateToLandlordInsuranceAdvicePageAfterEnteringDetailsAs(landlordPropFields);
            LandlordInsuranceAdvice.SelectOptionAs(landlordPropFields.LandlordInsuranceAdvice);
            InspectionFrequency.IsDisplayed();
        }


        public void ShouldNavigateToPostcodesSelectionAfterEnteringDetailsAs(LandlordProposalFields landlordPropFields)
        {
            ShouldNavigateToInspectionFreqPeriodPageAfterEnteringDetailsAs(landlordPropFields);
            InspectionFrequency.SetInspectionFrequencyPeriodAs(landlordPropFields.InspectionFrequencyPeriod);
            PostCodeSelection.IsDisplayed();
        }

        public void ShouldNavigateToAgentBiographySectionAfterEnteringDetailsAs(LandlordProposalFields landlordPropFields)
        {
            ShouldNavigateToPostcodesSelectionAfterEnteringDetailsAs(landlordPropFields);
            PostCodeSelection.SetValueInPostCodes(landlordPropFields.RentalPostCodes);
            PostCodeSelection.ClickNext();
            RentalAgentBiography.IsDisplayed();
        }

        public void ShouldNavigateToAgentRentalFeeStructureSectionAfterEnteringDetailsAs(LandlordProposalFields landlordPropFields)
        {
            ShouldNavigateToAgentBiographySectionAfterEnteringDetailsAs(landlordPropFields);
            RentalAgentBiography.SetAgentBiographyDetailsAs(landlordPropFields.RentalsAboutYouDetails, landlordPropFields.RentalsAboutYourAgencyDetails,
                                                      landlordPropFields.RentalsMarketingSellingApproach);
            AgentRentalFeeStructure.IsDisplayed();
        }

        public void ShouldNavigateToRentalProposalConfirmationAfterEnteringDetailsAs(LandlordProposalFields landlordPropFields)
        {
            ShouldNavigateToAgentRentalFeeStructureSectionAfterEnteringDetailsAs(landlordPropFields);
            AgentRentalFeeStructure.ShouldEntertheRentalFeeStructureDetailsAs(landlordPropFields);
            AgentRentalFeeStructure.ClickSubmit();
            RentalProposalConfirmation.IsDisplayed();
        }

        public VerificationInfo ShouldVerifyTheLabelOfTeamSizeSelectionProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Actual = label;
            info.Expected = _eltProgressTeamSizeLabel.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatTeamSizeIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressTeamSizeCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressTeamSizeCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressTeamSizeCheckmark.GetClassAttributeValue() + "-" + _eltProgressTeamSizeCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
            return info;
        }
        public VerificationInfo ShouldVerifyThatTeamSizeCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressTeamSizeSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressTeamSizeSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfPropertiesProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressPropPerManagerLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatPropertiesIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPropPerManagerCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressPropPerManagerCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressPropPerManagerCheckmark.GetClassAttributeValue() + "-" + _eltProgressPropPerManagerCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;

            return info;
        }

        public VerificationInfo ShouldVerifyThatPropertiesCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPropPerManagerSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressPropPerManagerSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfLanguagesProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressLanguagesLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;

        }
        public VerificationInfo ShouldVerifyThatLanguagesIsActiveInProgressBar()
        {

            VerificationInfo info = new VerificationInfo();
            if (_eltProgressLanguagesCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressLanguagesCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressLanguagesCheckmark.GetClassAttributeValue() + "-" + _eltProgressLanguagesCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;

            return info;

        }
        public VerificationInfo ShouldVerifyThatLanguagesCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressLanguagesSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressLanguagesSection.GetClassAttributeValue();
            return info;

        }

        public VerificationInfo ShouldVerifyTheLabelOfEmergencyProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressEmergencyContactLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatEmergencyIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressEmergencyContactCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressEmergencyContactCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressEmergencyContactCheckmark.GetClassAttributeValue() + "-" + _eltProgressEmergencyContactCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatEmergencyCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressEmergencyContactSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;
        

            info.Actual = _eltProgressEmergencyContactSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfInsuranceProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressLandlordInsuranceAdvLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatInsuranceIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressLandlordInsuranceAdvCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressLandlordInsuranceAdvCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressLandlordInsuranceAdvCheckmark.GetClassAttributeValue() + "-" + _eltProgressLandlordInsuranceAdvCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
            return info;
        }
        public VerificationInfo ShouldVerifyThatInsuranceCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressLandlordInsuranceAdvSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;


            info.Actual = _eltProgressLandlordInsuranceAdvSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfInspectionProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressInspectionFreqLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatInspectionIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressInspectionFreqCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressInspectionFreqCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressInspectionFreqCheckmark.GetClassAttributeValue() + "-" + _eltProgressInspectionFreqCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
            return info;

        }
        public VerificationInfo ShouldVerifyThatInspectionCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressInspectionFreqSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressInspectionFreqSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfPostcodesProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressPostCodesLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatPostcodesIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPostCodesCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressPostCodesCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressPostCodesCheckmark.GetClassAttributeValue() + "-" + _eltProgressPostCodesCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
            return info;
        }
        public VerificationInfo ShouldVerifyThatPostcodesCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPostCodesSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressPostCodesSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfBiographyProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressBiographyLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatBiographyIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressBiographyCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressBiographyCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressBiographyCheckmark.GetClassAttributeValue() + "-" + _eltProgressBiographyCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
            return info;
        }
        public VerificationInfo ShouldVerifyThatBiographyCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressBiographySection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressBiographySection.GetClassAttributeValue();
            return info;

        }

        public VerificationInfo ShouldVerifyTheLabelOfFeesProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressFeesLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatFeesIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressFeesCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressFeesCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressFeesCheckmark.GetClassAttributeValue() + "-" + _eltProgressFeesCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
            return info;
        }
        public VerificationInfo ShouldVerifyThatFeesCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressFeesSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressFeesSection.GetClassAttributeValue();
            return info;

        }


        public VerificationInfo IsForwardLinkDisabled()
        {
            VerificationInfo info = new VerificationInfo();
            if (_lnkForward.GetClassAttributeValue().Contains("not-active"))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo IsForwardLinkEnabled()
        {
            VerificationInfo info = new VerificationInfo();
            if (_lnkForward.GetClassAttributeValue().Contains("not-active"))
                info.Result = false;
            else
                info.Result = true;

            return info;
        }

        public void ClickForward()
        {
            _lnkForward.Click();
        }
    }
}
