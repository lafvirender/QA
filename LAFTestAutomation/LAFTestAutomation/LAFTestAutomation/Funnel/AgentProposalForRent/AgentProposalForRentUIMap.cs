using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForRent
{
    public class AgentProposalForRentUIMap
    {
        public TestObjectProperties EltBeginProposalSlide = new TestObjectProperties(Locator.CssSelector,
                                                                ".slide[data-slick-index='0']");
        public TestObjectProperties EltPropertyManagmentTeamSizeSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#RentalQuestions > div:nth-child(2)");
        public TestObjectProperties EltPropPerPropManagerSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#RentalQuestions > div:nth-child(3)");
        public TestObjectProperties EltLanguagesSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#RentalQuestions > div:nth-child(4)");
        public TestObjectProperties EltEmergencyContactSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#RentalQuestions > div:nth-child(5)");
        public TestObjectProperties EltLandlordInsuranceAdviceSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#RentalQuestions > div:nth-child(6)");
        public TestObjectProperties EltInspectionFreqSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#RentalQuestions > div:nth-child(7)");
        public TestObjectProperties EltPostCodeSelectionSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#RentalQuestions > div:nth-child(8)");
        public TestObjectProperties EltAgentBiographySlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#RentalQuestions > div:nth-child(9)");
        public TestObjectProperties EltAgentRentalFeeStructureSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#RentalQuestions > div:nth-child(10)");

        public TestObjectProperties LnkBack = new TestObjectProperties(Locator.CssSelector,
                                               ".nav-section.prev-section>a");
        public TestObjectProperties LnkForward = new TestObjectProperties(Locator.CssSelector,
                                                 ".nav-section.next-section>a");

        public TestObjectProperties EltQuestion = new TestObjectProperties(Locator.CssSelector,
                                    "div[aria-hidden=false]>.question");
        public TestObjectProperties BtnBegin = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Next]");

        public TestObjectProperties EltBeginProposalHeading = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(1) > h6");
        public TestObjectProperties EltPropertyMgmtTeamSizeQuestion = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(2) > h6");
        public TestObjectProperties EltPropertyPerPropManagerQ = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(3) > h6");
        public TestObjectProperties EltLanguageSelectionQuestion = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(4) > h6");
        public TestObjectProperties EltEmergencyContactQuestion = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(5) > h6");
        public TestObjectProperties EltLandlordInsuranceAdviceQuestion = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(6) > h6");
        public TestObjectProperties EltInspectionFreqQuestion = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(7) > h6");
        public TestObjectProperties EltPostcodesSelectionQuestion = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(8) > h6");
        public TestObjectProperties EltAgentBiographyQuestion = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(9) > h6");
        public TestObjectProperties EltAgentRentalFeeStructureQuestion = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(10) > h6");
        //Agent Proposal for Vendors

        public TestObjectProperties TxtPropMgmtTeamSize = new TestObjectProperties(Locator.Id, "RentalOptions_SizeOfPropertyManagementTeam");
        public TestObjectProperties TxtPropPerPropManager = new TestObjectProperties(Locator.CssSelector, "#RentalOptions_PropertiesPerPropertyManager");


        public TestObjectProperties EltSaleMethodsQuestion = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(2) > h6");
        public TestObjectProperties BtnPrivateSale = new TestObjectProperties(Locator.Id, "SaleOptions.SaleTypes_PrivateTreaty");
        public TestObjectProperties BtnAuction = new TestObjectProperties(Locator.Id, "SaleOptions.SaleTypes_Auction");
        public TestObjectProperties BtnFixedDate = new TestObjectProperties(Locator.Id, "SaleOptions.SaleTypes_FixedDate");
        public TestObjectProperties BtnOffMarket = new TestObjectProperties(Locator.Id, "SaleOptions.SaleTypes_OffMarket");
        public TestObjectProperties BtnNext = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Next]");
        public TestObjectProperties BtnNextPropMgmtTeam = new TestObjectProperties(Locator.CssSelector, "a[data-event=RentalOptions_SizeOfPropertyManagementTeam][data-parameter=Next]");
        public TestObjectProperties BtnNextPropPerPropManager = new TestObjectProperties(Locator.CssSelector, "a[data-event=RentalOptions_PropertiesPerPropertyManager][data-parameter=Next]");
        public TestObjectProperties BtnNextLanguages = new TestObjectProperties(Locator.CssSelector, "a[data-event=RentalOptions_Languages][data-parameter=Next]");
        public TestObjectProperties BtnNextInspection = new TestObjectProperties(Locator.CssSelector, "a[data-event=RentalOptions_InspectionFrequencyMonths][data-parameter=Next]");
        public TestObjectProperties BtnNextPostcodes = new TestObjectProperties(Locator.CssSelector, "a[data-event=AgentPostcodes][data-parameter=Next]");
        public TestObjectProperties BtnNextBiography = new TestObjectProperties(Locator.CssSelector, "a[data-event=RentSummary][data-parameter=Next]");

        public TestObjectProperties BtnYourBiographyNext = new TestObjectProperties(Locator.CssSelector, "#RentalQuestions > div:nth-child(9) > a");

        public TestObjectProperties EltLanguages = new TestObjectProperties(Locator.CssSelector, ".col-xs-12.col-md-9.languages");
        public TestObjectProperties EltLanguageLabel = new TestObjectProperties(Locator.CssSelector, ".col-xs-12.col-md-9.languages label");
        public TestObjectProperties BtnArabic = new TestObjectProperties(Locator.Id, "RentalLanguage_6");
        public TestObjectProperties BtnCantonese = new TestObjectProperties(Locator.Id, "RentalLanguage_5");
        public TestObjectProperties BtnCroatian = new TestObjectProperties(Locator.Id, "RentalLanguage_13");
        public TestObjectProperties BtnDutch = new TestObjectProperties(Locator.Id, "RentalLanguage_18");
        public TestObjectProperties BtnFrench = new TestObjectProperties(Locator.Id, "RentalLanguage_9");
        public TestObjectProperties BtnGreek = new TestObjectProperties(Locator.Id, "RentalLanguage_4");
        public TestObjectProperties BtnHebrew = new TestObjectProperties(Locator.Id, "RentalLanguage_32");
        public TestObjectProperties BtnHindi = new TestObjectProperties(Locator.Id, "RentalLanguage_16");
        public TestObjectProperties BtnHungarian = new TestObjectProperties(Locator.Id, "RentalLanguage_26");
        public TestObjectProperties BtnIndonesian = new TestObjectProperties(Locator.Id, "RentalLanguage_21");
        public TestObjectProperties BtnEnglish = new TestObjectProperties(Locator.Id, "RentalLanguage_1");
        public TestObjectProperties BtnItalian = new TestObjectProperties(Locator.Id, "RentalLanguage_2");
        public TestObjectProperties BtnJapanese = new TestObjectProperties(Locator.Id, "RentalLanguage_24");
        public TestObjectProperties BtnKorean = new TestObjectProperties(Locator.Id, "RentalLanguage_20");
        public TestObjectProperties BtnLebanese = new TestObjectProperties(Locator.Id, "RentalLanguage_35");
        public TestObjectProperties BtnMacedonian = new TestObjectProperties(Locator.Id, "RentalLanguage_34");
        public TestObjectProperties BtnMaltese = new TestObjectProperties(Locator.Id, "RentalLanguage_31");
        public TestObjectProperties BtnMandarin = new TestObjectProperties(Locator.Id, "RentalLanguage_7");
        public TestObjectProperties BtnPersian = new TestObjectProperties(Locator.Id, "RentalLanguage_25");
        public TestObjectProperties BtnPolish = new TestObjectProperties(Locator.Id, "RentalLanguage_14");
        public TestObjectProperties BtnPortuguese = new TestObjectProperties(Locator.Id, "RentalLanguage_28");
        public TestObjectProperties BtnRussian = new TestObjectProperties(Locator.Id, "RentalLanguage_23");
        public TestObjectProperties BtnSerbian = new TestObjectProperties(Locator.Id, "RentalLanguage_12");
        public TestObjectProperties BtnSpanish = new TestObjectProperties(Locator.Id, "RentalLanguage_10");
        public TestObjectProperties BtnSriLankan = new TestObjectProperties(Locator.Id, "RentalLanguage_33");
        public TestObjectProperties BtnTagalog = new TestObjectProperties(Locator.Id, "RentalLanguage_19");
        public TestObjectProperties BtnThai = new TestObjectProperties(Locator.Id, "RentalLanguage_36");
        public TestObjectProperties BtnTurkish = new TestObjectProperties(Locator.Id, "RentalLanguage_15");
        public TestObjectProperties BtnVietnamese = new TestObjectProperties(Locator.Id, "RentalLanguage_3");

        public TestObjectProperties BtnEmergencyContactYes = new TestObjectProperties(Locator.Id, "RentalOptions.Emergency24HourContact_True");
        public TestObjectProperties BtnEmergencyContactNo = new TestObjectProperties(Locator.Id, "RentalOptions.Emergency24HourContact_False");
        public TestObjectProperties BtnLandlordInsuranceAdviceYes = new TestObjectProperties(Locator.Id, "RentalOptions.LandlordInsurance_True");
        public TestObjectProperties BtnLandlordInsuranceAdviceNo = new TestObjectProperties(Locator.Id, "RentalOptions.LandlordInsurance_False");

        public TestObjectProperties LstInspectionFreqPeriod = new TestObjectProperties(Locator.Id, "RentalOptions_InspectionFrequencyMonths");

        public TestObjectProperties RbtnTieredCommissionsYes = new TestObjectProperties(Locator.Id, "SaleOptions.TieredCommissionsOption_True");
        public TestObjectProperties RbtnTieredCommissionsNo = new TestObjectProperties(Locator.Id, "TieredCommissionsOption_False");
        public TestObjectProperties DDSaleTeamSize = new TestObjectProperties(Locator.Id, "SaleOptions_SizeOfSalesTeam");
        public TestObjectProperties TxtSalesProposalSummary = new TestObjectProperties(Locator.Id, "SaleOptions_Summary");
        public TestObjectProperties TxtAgencyIntro = new TestObjectProperties(Locator.Id, "SaleLevels_AgencyOverview");
        public TestObjectProperties TxtMarketingApproach = new TestObjectProperties(Locator.Id, "SaleLevels_MarketingPlan");
        public TestObjectProperties TxtWhyShortlist = new TestObjectProperties(Locator.Id, "SaleLevels_WhyShortlist");

        public TestObjectProperties TxtPostCode1 = new TestObjectProperties(Locator.Id, "AgentPostcodes_0_");
        public TestObjectProperties TxtPostCode2 = new TestObjectProperties(Locator.Id, "AgentPostcodes_1_");
        public TestObjectProperties TxtPostCode3 = new TestObjectProperties(Locator.Id, "AgentPostcodes_2_");
        public TestObjectProperties TxtPostCode4 = new TestObjectProperties(Locator.Id, "AgentPostcodes_3_");
        public TestObjectProperties TxtPostCode5 = new TestObjectProperties(Locator.Id, "AgentPostcodes_4_");

        public TestObjectProperties LnkAboutYou = new TestObjectProperties(Locator.CssSelector, ".form-label[for=RentLevels_AgentOverview]");
        public TestObjectProperties TxtAboutYouDetails = new TestObjectProperties(Locator.Name, "RentLevels.AgentOverview");
        public TestObjectProperties LnkAboutYourAgency = new TestObjectProperties(Locator.CssSelector, ".form-label[for=RentLevels_AgencyOverview]");
        public TestObjectProperties TxtAboutYourAgencyDetails = new TestObjectProperties(Locator.Name, "RentLevels.AgencyOverview");
        public TestObjectProperties LnkMarketingSellingApproach = new TestObjectProperties(Locator.CssSelector, ".form-label[for=RentLevels_MarketingPlan]");
        public TestObjectProperties TxtMarketingSellingApproachDetails = new TestObjectProperties(Locator.Name, "RentLevels.MarketingPlan");



        public TestObjectProperties LstPropertiesBetween = new TestObjectProperties(Locator.CssSelector, "#SaleLevels[0].UpperBound");
        public TestObjectProperties LstCommissionTypes = new TestObjectProperties(Locator.CssSelector, "#SelectedCommissionType");
        public TestObjectProperties BtnAddHigherRange = new TestObjectProperties(Locator.CssSelector, ".add-range.button2.sml");
        public TestObjectProperties BtnDeleteRange = new TestObjectProperties(Locator.CssSelector, ".delete-range.button2.sml");
        public TestObjectProperties EltFeeStructureSection = new TestObjectProperties(Locator.CssSelector, ".col-xs-12.suppress-col-gutters.sale-entry");
        public TestObjectProperties BtnRentalFeeStructureSubmit = new TestObjectProperties(Locator.CssSelector, "#continue-button");

        public TestObjectProperties EltErrors = new TestObjectProperties(Locator.CssSelector, ".validation-summary-errors li");

        public TestObjectProperties LstLettingFee = new TestObjectProperties(Locator.Name, "RentLevels[0].LettingFee");
        public TestObjectProperties TxtManagementFee = new TestObjectProperties(Locator.Name, "RentLevels[0].ManagementCommissionPercentage");
        public TestObjectProperties LstMarketingBudget = new TestObjectProperties(Locator.Name, "RentLevels[0].MarketingBudget");

        public TestObjectProperties EltConfirmationMessage = new TestObjectProperties(Locator.CssSelector, "div.modal-body > div > h2");
        public TestObjectProperties BtnGoToYourPortal = new TestObjectProperties(Locator.CssSelector, ".button.welcome-button");

        public TestObjectProperties EltAgentDashboardWelcomeMsg = new TestObjectProperties(Locator.CssSelector, ".welcome-header h3");

        public TestObjectProperties EltSalutation1 = new TestObjectProperties(Locator.CssSelector, ".modal-title>.salutations-1");
        public TestObjectProperties EltSalutation2 = new TestObjectProperties(Locator.CssSelector, ".modal-title>.salutations-2");
        public TestObjectProperties BtnGotIt = new TestObjectProperties(Locator.CssSelector, ".btn.btn-default.btn-accept.swelcome-button");

        public TestObjectProperties EltProgressTeamSizeSection = new TestObjectProperties(Locator.CssSelector,
                                                                   ".progress-section>.section.team-size");
        public TestObjectProperties EltProgressTeamSizeCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.team-size>.progress-point.checkmark");
        public TestObjectProperties EltProgressTeamSizeCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.team-size>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressTeamSizeLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.team-size>.section-label");

        public TestObjectProperties EltProgressPropPerManagerSection = new TestObjectProperties(Locator.CssSelector,
                                                                 ".progress-section>.section.properties-per-manager");
        public TestObjectProperties EltProgressPropPerManagerCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.properties-per-manager>.progress-point.checkmark");
        public TestObjectProperties EltProgressPropPerManagerCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.properties-per-manager>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressPropPerManagerLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.properties-per-manager>.section-label");

        public TestObjectProperties EltProgressLanguagesSection = new TestObjectProperties(Locator.CssSelector,
                                                                    ".progress-section>.section.languages");
        public TestObjectProperties EltProgressLanguagesCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.languages>.progress-point.checkmark");
        public TestObjectProperties EltProgressLanguagesCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.languages>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressLanguagesLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.languages>.section-label");

        public TestObjectProperties EltProgressEmergencyContactSection = new TestObjectProperties(Locator.CssSelector,
                                                                   ".progress-section>.section.emergencies");
        public TestObjectProperties EltProgressEmergencyContactCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.emergencies>.progress-point.checkmark");
        public TestObjectProperties EltProgressEmergencyContactCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.emergencies>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressEmergencyContactLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.emergencies>.section-label");

        public TestObjectProperties EltProgressLandlordInsuranceAdvSection = new TestObjectProperties(Locator.CssSelector,
                                                                   ".progress-section>.section.insurance");
        public TestObjectProperties EltProgressLandlordInsuranceAdvCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.insurance>.progress-point.checkmark");
        public TestObjectProperties EltProgressLandlordInsuranceAdvCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.insurance>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressLandlordInsuranceAdvLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.insurance>.section-label");

        public TestObjectProperties EltProgressInspectionFreqSection = new TestObjectProperties(Locator.CssSelector,
                                                                   ".progress-section>.section.inspections");
        public TestObjectProperties EltProgressInspectionFreqCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.inspections>.progress-point.checkmark");
        public TestObjectProperties EltProgressInspectionFreqCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.inspections>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressInspectionFreqLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.inspections>.section-label");

        public TestObjectProperties EltProgressPostCodesSection = new TestObjectProperties(Locator.CssSelector,
                                                           ".progress-section>.section.postcodes");
        public TestObjectProperties EltProgressPostCodesCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.postcodes>.progress-point.checkmark");
        public TestObjectProperties EltProgressPostCodesCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.postcodes>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressPostCodesLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.postcodes>.section-label");

        public TestObjectProperties EltProgressBiographySection = new TestObjectProperties(Locator.CssSelector,
                                                          ".progress-section>.section.biography");
        public TestObjectProperties EltProgressBiographyCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.biography>.progress-point.checkmark");
        public TestObjectProperties EltProgressBiographyCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.biography>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressBiographyLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.biography>.section-label");

        public TestObjectProperties EltProgressFeesSection = new TestObjectProperties(Locator.CssSelector,
                                                          ".progress-section>.section.fees");
        public TestObjectProperties EltProgressFeesCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.fees>.progress-point.checkmark");
        public TestObjectProperties EltProgressFeesCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.fees>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressFeesLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.fees>.section-label");

    }
}
