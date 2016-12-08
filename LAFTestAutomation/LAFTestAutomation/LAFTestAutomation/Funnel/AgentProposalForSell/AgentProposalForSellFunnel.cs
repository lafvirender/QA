using LAFTestAutomationFramework.Funnel.AgentProposalForSell.Slides;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForSell
{

    public class AgentProposalForSellFunnel : AgentProposalForSellUIMap
    {
        public BeginAgentProposal BeginAgentProposal;
        public SalesMethods SalesMethods;
        public Languages Languages;
        public SaleAuthority SaleAuthority;
        public SalesTeamSelection SalesTeamSelection;
        public PostCodeSelection PostCodeSelection;
        public AgentBiography AgentBiography;
        public AgentFeeStructure AgentFeeStructure;
        public SalesProposalConfirmation SalesProposalConfirmation;

        private readonly TestObject _elementQ;
        private readonly TestObject _lnkForward;

        private readonly TestObject _eltProgressSalesMethodsSection;
        private readonly TestObject _eltProgressSalesMethodsCheckmark;
        private readonly TestObject _eltProgressSalesMethodsCheckmarkCircle;
        private readonly TestObject _eltProgressSalesMethodsLabel;

        private readonly TestObject _eltProgressLanguagesSection;
        private readonly TestObject _eltProgressLanguagesCheckmark;
        private readonly TestObject _eltProgressLanguagesCheckmarkCircle;
        private readonly TestObject _eltProgressLanguagesLabel;

        private readonly TestObject _eltProgressSaleAuthSection;
        private readonly TestObject _eltProgressSaleAuthCheckmark;
        private readonly TestObject _eltProgressSaleAuthCheckmarkCircle;
        private readonly TestObject _eltProgressSaleAuthLabel;

        private readonly TestObject _eltProgressSaleTeamSection;
        private readonly TestObject _eltProgressSaleTeamCheckmark;
        private readonly TestObject _eltProgressSaleTeamCheckmarkCircle;
        private readonly TestObject _eltProgressSaleTeamLabel;

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

        public AgentProposalForSellFunnel(Browser browser) : base()
        {
            BeginAgentProposal = new BeginAgentProposal(browser, BtnBegin, EltBeginProposalHeading);

            SalesMethods = new SalesMethods(browser, BtnPrivateSale, BtnAuction, BtnOffMarket, BtnFixedDate,
                                            BtnNextSalesMethods, LnkForward, LnkBack, EltSalesMethodsSlide, EltSaleMethodsQuestion);

            Languages = new Languages(browser, EltLanguagesSlide, BtnArabic, BtnCantonese, BtnCroatian,
                                     BtnDutch, BtnFrench, BtnGreek, BtnHebrew, BtnHindi, BtnHungarian,
                                     BtnIndonesian, BtnEnglish, BtnItalian, BtnJapanese, BtnKorean,
                                     BtnLebanese, BtnMacedonian, BtnMaltese, BtnMandarin, BtnPersian,
                                     BtnPolish, BtnPortuguese, BtnRussian, BtnSerbian, BtnSpanish, BtnSriLankan,
                                     BtnTagalog, BtnThai, BtnTurkish, BtnVietnamese, BtnNextLanguages, EltLanguageSelectionQuestion);

            SaleAuthority = new SaleAuthority(browser, EltSalesAuthSlide, BtnNextSaleAuthority, 
                                              DDSaleAuthority, LnkBack, LnkForward,
                                              EltStandardSaleAuthQuestion);

            SalesTeamSelection = new SalesTeamSelection(browser, EltSalesTeamSlide,
                                                        BtnNextSaleTeamSize, LnkBack, LnkForward, 
                                                        DDSaleTeamSize, EltSalesTeamSizeQuestion);

            PostCodeSelection = new PostCodeSelection(browser, EltPostCodeSelectionSlide,
                                                     BtnNextPostCodes, TxtPostCode1, TxtPostCode2, 
                                                     TxtPostCode3, TxtPostCode4, 
                                                     TxtPostCode5, LnkBack, LnkForward,
                                                     EltPostcodesSelectionQuestion);

            AgentBiography = new AgentBiography(browser,EltAgentBiographySlide, 
                                                LnkForward, LnkBack, BtnNextBiography, LnkAboutYou, 
                                                TxtAboutYouDetails, LnkAboutYourAgency, 
                                                TxtAboutYourAgencyDetails, LnkMarketingSellingApproach,
                                                TxtMarketingSellingApproachDetails, EltAgentBiographyQuestion);

            AgentFeeStructure = new AgentFeeStructure(browser, EltAgentFeeStructureSlide, 
                                                      BtnNext, LnkBack, LnkForward,
                                                      EltAgentFeeStructureQuestion, LstPropertiesBetween,
                                                      LstCommissionTypes, LstMarketingBudget, BtnAddHigherRange,
                                                      EltFeeStructureSection, LstFirstFeeStrPropertiesBetweenLB,
                                                      LstFirstFeeStrPropertiesBetweenUB, LstFirstFeeStrCommissionType,
                                                      TxtFirstFeeStrCommissionPercentage, TxtFirstFeeStrCommissionFixed,
                                                      LstFirstFeeStrMarketingBudget, LstSecondFeeStrPropertiesBetweenLB,
                                                      LstSecondFeeStrPropertiesBetweenUB, LstSecondFeeStrCommissionType,
                                                      TxtSecondFeeStrCommissionPercentage, TxtSecondFeeStrCommissionFixed,
                                                      LstSecondFeeStrMarketingBudget, LstThirdFeeStrPropertiesBetweenLB,
                                                      LstThirdFeeStrPropertiesBetweenUB, LstThirdFeeStrCommissionType,
                                                      TxtThirdFeeStrCommissionPercentage, TxtThirdFeeStrCommissionFixed,
                                                      LstThirdFeeStrMarketingBudget, BtnDeleteRange,
                                                      BtnFeeStructureSubmit, EltErrors);

            SalesProposalConfirmation = new SalesProposalConfirmation(browser, EltConfirmationMessage, BtnGoToYourPortal, EltAgentDashboardWelcomeMsg);

            _elementQ = new TestObject(browser, EltQuestion);
            _lnkForward = new TestObject(browser, LnkForward);


            _eltProgressSalesMethodsSection = new TestObject(browser, EltProgressSalesMethodsSection);
            _eltProgressSalesMethodsCheckmark = new TestObject(browser, EltProgressSalesMethodsCheckmark);
            _eltProgressSalesMethodsCheckmarkCircle = new TestObject(browser, EltProgressSalesMethodsCheckmarkCircle);
            _eltProgressSalesMethodsLabel = new TestObject(browser, EltProgressSalesMethodsLabel);

            _eltProgressLanguagesSection = new TestObject(browser, EltProgressLanguagesSection);
            _eltProgressLanguagesCheckmark = new TestObject(browser, EltProgressLanguagesCheckmark);
            _eltProgressLanguagesCheckmarkCircle = new TestObject(browser, EltProgressLanguagesCheckmarkCircle);
            _eltProgressLanguagesLabel = new TestObject(browser, EltProgressLanguagesLabel);

            _eltProgressSaleAuthSection = new TestObject(browser, EltProgressSaleAuthSection);
            _eltProgressSaleAuthCheckmark = new TestObject(browser, EltProgressSaleAuthCheckmark);
            _eltProgressSaleAuthCheckmarkCircle = new TestObject(browser, EltProgressSaleAuthCheckmarkCircle);
            _eltProgressSaleAuthLabel = new TestObject(browser, EltProgressSaleAuthLabel);

            _eltProgressSaleTeamSection = new TestObject(browser, EltProgressSaleTeamSection);
            _eltProgressSaleTeamCheckmark = new TestObject(browser, EltProgressSaleTeamCheckmark);
            _eltProgressSaleTeamCheckmarkCircle = new TestObject(browser, EltProgressSaleTeamCheckmarkCircle);
            _eltProgressSaleTeamLabel = new TestObject(browser, EltProgressSaleTeamLabel);

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
            _eltProgressFeesLabel = new TestObject(browser, EltProgressFeesLabel);
        }

        public void ClickForward()
        {
            _lnkForward.Click();
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

        public void ShouldNavigateToSaleMethodsPage()
        {
            BeginAgentProposal.SelectBegin();
            SalesMethods.IsDisplayed();
        }

        public void ShouldNavigateToLanguageSelectionAfterEnteringDetailsAs(VendorProposalFields vendPropFields)
        {
            ShouldNavigateToSaleMethodsPage();
            SalesMethods.SelectSaleMethodsAs(vendPropFields.SaleMethods);
            SalesMethods.ClickNext();
            Languages.IsDisplayed();
        }

        public void ShouldNavigateToSaleAuthoritySelectionAfterEnteringDetailsAs(VendorProposalFields vendPropFields)
        {
            ShouldNavigateToLanguageSelectionAfterEnteringDetailsAs(vendPropFields);
            Languages.SelectLanguagesAs(vendPropFields.Languages);
            Languages.ClickNext();
            SaleAuthority.IsDisplayed();
        }

        public void ShouldNavigateToSaleTeamSizeSelectionAfterEnteringDetailsAs(VendorProposalFields vendPropFields)
        {
            ShouldNavigateToSaleAuthoritySelectionAfterEnteringDetailsAs(vendPropFields);
            SaleAuthority.SetSaleAuthPeriodAs(vendPropFields.SaleAuthoritySize);
            SalesTeamSelection.IsDisplayed();
        }

        public void ShouldNavigateToPostcodesSelectionAfterEnteringDetailsAs(VendorProposalFields vendPropFields)
        {
            ShouldNavigateToSaleTeamSizeSelectionAfterEnteringDetailsAs(vendPropFields);
            SalesTeamSelection.SetSaleTeamSizeAs(vendPropFields.SaleTeamSize);
            PostCodeSelection.IsDisplayed();
        }

        public void ShouldNavigateToAgentBiographySectionAfterEnteringDetailsAs(VendorProposalFields vendPropFields)
        {
            ShouldNavigateToPostcodesSelectionAfterEnteringDetailsAs(vendPropFields);
            PostCodeSelection.SetValueInPostCodes(vendPropFields.PostCodes);
            PostCodeSelection.ClickNext();
            AgentBiography.IsDisplayed();
        }

        public void ShouldNavigateToAgentFeeStructureSectionAfterEnteringDetailsAs(VendorProposalFields vendPropFields)
        {
            ShouldNavigateToAgentBiographySectionAfterEnteringDetailsAs(vendPropFields);
            AgentBiography.SetAgentBiographyDetailsAs(vendPropFields.AboutYouDetails, vendPropFields.AboutYourAgencyDetails, 
                                                      vendPropFields.MarketingSellingApproach);
            AgentFeeStructure.IsDisplayed();
        }

        public void ShouldNavigateToSalesMethodsSelectionAfterEnteringDetailsAs()
        {
            BeginAgentProposal.SelectBegin();
            SalesMethods.IsDisplayed();
        }

        public void ShouldNavigateToSalesProposalConfirmationAfterEnteringDetailsAs(VendorProposalFields vendPropFields)
        {
            ShouldNavigateToAgentFeeStructureSectionAfterEnteringDetailsAs(vendPropFields);
            AgentFeeStructure.ShouldEntertheFirstFeeStructureDetailsAs(vendPropFields);
            AgentFeeStructure.ShouldEntertheSecondFeeStructureDetailsAs(vendPropFields);
            AgentFeeStructure.ShouldEntertheThirdFeeStructureDetailsAs(vendPropFields);
            AgentFeeStructure.ClickSubmit();
            SalesProposalConfirmation.IsDisplayed();
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

        public VerificationInfo ShouldVerifyTheLabelOfSalesMethodsSelectionProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressSalesMethodsLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatSalesMethodsIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressSalesMethodsCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressSalesMethodsCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressSalesMethodsCheckmark.GetClassAttributeValue() + "-" + _eltProgressSalesMethodsCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyThatSalesMethodsCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressSalesMethodsSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressFeesSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfLanguagesSelectionProgressBarWith(string label)
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
                   && _eltProgressSalesMethodsCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;


            info.Actual = _eltProgressLanguagesCheckmark.GetClassAttributeValue() + "-" + _eltProgressSalesMethodsCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
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

        public VerificationInfo ShouldVerifyTheLabelOfSaleAuthSelectionProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressSaleAuthLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatSaleAuthIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressSaleAuthCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressSaleAuthCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressSaleAuthCheckmark.GetClassAttributeValue() + "-" + _eltProgressSaleAuthCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;

            return info;

        }
        public VerificationInfo ShouldVerifyThatSaleAuthCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressSaleAuthSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressSaleAuthSection.GetClassAttributeValue();
            return info;
        }


        public VerificationInfo ShouldVerifyTheLabelOfSaleTeamSelectionProgressBarWith(string label)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = label;
            info.Actual = _eltProgressSaleTeamLabel.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyThatSaleTeamIsActiveInProgressBar()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressSaleTeamCheckmark.GetClassAttributeValue().Contains("active")
                   && _eltProgressSaleTeamCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressSaleTeamCheckmark.GetClassAttributeValue() + "-" + _eltProgressSaleTeamCheckmarkCircle.VerifyAgentRegProgressCircleColorForActive().Actual;
            return info;
        }
        public VerificationInfo ShouldVerifyThatSaleTeamCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressSaleTeamSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressSaleAuthSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfPostCodesSelectionProgressBarWith(string label)
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
        public VerificationInfo ShouldVerifyThatPostCodesIsActiveInProgressBar()
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
        public VerificationInfo ShouldVerifyThatPostCodesCircleIsChecked()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltProgressPostCodesSection.GetClassAttributeValue().Contains("complete"))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltProgressPostCodesSection.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheLabelOfBiographySelectionProgressBarWith(string label)
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

        public VerificationInfo ShouldVerifyTheLabelOfFeesSelectionProgressBarWith(string label)
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


    }
}
