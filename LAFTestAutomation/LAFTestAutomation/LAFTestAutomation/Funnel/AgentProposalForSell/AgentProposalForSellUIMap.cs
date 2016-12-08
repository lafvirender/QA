using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForSell
{
    public class AgentProposalForSellUIMap
    {
        public TestObjectProperties EltBeginProposalSlide = new TestObjectProperties(Locator.CssSelector,
                                                                ".slide[data-slick-index='0']");
        public TestObjectProperties EltSalesMethodsSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#SaleQuestions > div:nth-child(2)");
        public TestObjectProperties EltLanguagesSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#SaleQuestions > div:nth-child(3)");
        public TestObjectProperties EltSalesAuthSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#SaleQuestions > div:nth-child(4)");
        public TestObjectProperties EltSalesTeamSlide = new TestObjectProperties(Locator.CssSelector,
                                                                "#SaleQuestions > div:nth-child(5)");
        public TestObjectProperties EltPostCodeSelectionSlide = new TestObjectProperties(Locator.CssSelector,
                                                               "#SaleQuestions > div:nth-child(6)");
        public TestObjectProperties EltAgentBiographySlide = new TestObjectProperties(Locator.CssSelector,
                                                              "#SaleQuestions > div:nth-child(7)");

        public TestObjectProperties EltAgentFeeStructureSlide = new TestObjectProperties(Locator.CssSelector,
                                                              "#SaleQuestions > div:nth-child(8)");

        public TestObjectProperties LnkBack = new TestObjectProperties(Locator.CssSelector,
                                               ".nav-section.prev-section>a");
        public TestObjectProperties LnkForward = new TestObjectProperties(Locator.CssSelector,
                                                 ".nav-section.next-section>a");

        public TestObjectProperties EltQuestion = new TestObjectProperties(Locator.CssSelector,
                                    "div[aria-hidden=false]>.question");
        public TestObjectProperties BtnBegin = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Next]");

        public TestObjectProperties EltBeginProposalHeading = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(1) > h6");
        public TestObjectProperties EltLanguageSelectionQuestion = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(3) > h6");
        public TestObjectProperties EltStandardSaleAuthQuestion = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(4) > h6");
        public TestObjectProperties EltSalesTeamSizeQuestion = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(5) > h6");
        public TestObjectProperties EltPostcodesSelectionQuestion = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(6) > h6");
        public TestObjectProperties EltAgentBiographyQuestion = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(7) > h6");
        public TestObjectProperties EltAgentFeeStructureQuestion = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(8) > h6");
        //Agent Proposal for Vendors

        public TestObjectProperties EltSaleMethodsQuestion = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(2) > h6");
        public TestObjectProperties BtnPrivateSale = new TestObjectProperties(Locator.Id, "SaleOptions.SaleTypes_PrivateTreaty");
        public TestObjectProperties BtnAuction = new TestObjectProperties(Locator.Id, "SaleOptions.SaleTypes_Auction");
        public TestObjectProperties BtnFixedDate = new TestObjectProperties(Locator.Id, "SaleOptions.SaleTypes_FixedDate");
        public TestObjectProperties BtnOffMarket = new TestObjectProperties(Locator.Id, "SaleOptions.SaleTypes_OffMarket");
        public TestObjectProperties BtnNext = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Next]");
        public TestObjectProperties BtnNextSalesMethods = new TestObjectProperties(Locator.CssSelector, "a[data-event=SaleOptions_SaleTypes][data-parameter=Next]");
        public TestObjectProperties BtnNextLanguages = new TestObjectProperties(Locator.CssSelector, "a[data-event=SaleOptions_Languages][data-parameter=Next]");
        public TestObjectProperties BtnNextSaleAuthority= new TestObjectProperties(Locator.CssSelector, "a[data-event=SaleOptions_ExclusiveAuthorityPeriodMonths][data-parameter=Next]");
        public TestObjectProperties BtnNextSaleTeamSize = new TestObjectProperties(Locator.CssSelector, "a[data-event=SaleOptions_SizeOfSalesTeam][data-parameter=Next]");
        public TestObjectProperties BtnNextPostCodes= new TestObjectProperties(Locator.CssSelector, "a[data-event=AgentPostcodes][data-parameter=Next]");
        public TestObjectProperties BtnNextBiography = new TestObjectProperties(Locator.CssSelector, "a[data-event=SaleSummary][data-parameter=Next]");

        public TestObjectProperties EltLanguages = new TestObjectProperties(Locator.CssSelector, ".col-xs-12.col-md-9.languages");
        public TestObjectProperties EltLanguageLabel = new TestObjectProperties(Locator.CssSelector, ".col-xs-12.col-md-9.languages label");
        public TestObjectProperties BtnArabic = new TestObjectProperties(Locator.Id, "SalesLanguage_6");
        public TestObjectProperties BtnCantonese = new TestObjectProperties(Locator.Id, "SalesLanguage_5");
        public TestObjectProperties BtnCroatian = new TestObjectProperties(Locator.Id, "SalesLanguage_13");
        public TestObjectProperties BtnDutch = new TestObjectProperties(Locator.Id, "SalesLanguage_18");
        public TestObjectProperties BtnFrench = new TestObjectProperties(Locator.Id, "SalesLanguage_9");
        public TestObjectProperties BtnGreek = new TestObjectProperties(Locator.Id, "SalesLanguage_4");
        public TestObjectProperties BtnHebrew = new TestObjectProperties(Locator.Id, "SalesLanguage_32");
        public TestObjectProperties BtnHindi = new TestObjectProperties(Locator.Id, "SalesLanguage_16");
        public TestObjectProperties BtnHungarian = new TestObjectProperties(Locator.Id, "SalesLanguage_26");
        public TestObjectProperties BtnIndonesian = new TestObjectProperties(Locator.Id, "SalesLanguage_21");
        public TestObjectProperties BtnEnglish = new TestObjectProperties(Locator.Id, "SalesLanguage_1");
        public TestObjectProperties BtnItalian = new TestObjectProperties(Locator.Id, "SalesLanguage_2");
        public TestObjectProperties BtnJapanese = new TestObjectProperties(Locator.Id, "SalesLanguage_24");
        public TestObjectProperties BtnKorean = new TestObjectProperties(Locator.Id, "SalesLanguage_20");
        public TestObjectProperties BtnLebanese = new TestObjectProperties(Locator.Id, "SalesLanguage_35");
        public TestObjectProperties BtnMacedonian = new TestObjectProperties(Locator.Id, "SalesLanguage_34");
        public TestObjectProperties BtnMaltese = new TestObjectProperties(Locator.Id, "SalesLanguage_31");
        public TestObjectProperties BtnMandarin = new TestObjectProperties(Locator.Id, "SalesLanguage_7");
        public TestObjectProperties BtnPersian = new TestObjectProperties(Locator.Id, "SalesLanguage_25");
        public TestObjectProperties BtnPolish = new TestObjectProperties(Locator.Id, "SalesLanguage_14");
        public TestObjectProperties BtnPortuguese = new TestObjectProperties(Locator.Id, "SalesLanguage_28");
        public TestObjectProperties BtnRussian = new TestObjectProperties(Locator.Id, "SalesLanguage_23");
        public TestObjectProperties BtnSerbian = new TestObjectProperties(Locator.Id, "SalesLanguage_12");
        public TestObjectProperties BtnSpanish = new TestObjectProperties(Locator.Id, "SalesLanguage_10");
        public TestObjectProperties BtnSriLankan = new TestObjectProperties(Locator.Id, "SalesLanguage_33");
        public TestObjectProperties BtnTagalog = new TestObjectProperties(Locator.Id, "SalesLanguage_19");
        public TestObjectProperties BtnThai = new TestObjectProperties(Locator.Id, "SalesLanguage_36");
        public TestObjectProperties BtnTurkish = new TestObjectProperties(Locator.Id, "SalesLanguage_15");
        public TestObjectProperties BtnVietnamese = new TestObjectProperties(Locator.Id, "SalesLanguage_3");


        public TestObjectProperties DDSaleAuthority = new TestObjectProperties(Locator.Id, "SaleOptions_ExclusiveAuthorityPeriodMonths");
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

        public TestObjectProperties LnkAboutYou = new TestObjectProperties(Locator.CssSelector, ".form-label[for=SaleLevels_AgentOverview]");
        public TestObjectProperties TxtAboutYouDetails = new TestObjectProperties(Locator.CssSelector, "#SaleLevels_AgentOverview");
        public TestObjectProperties LnkAboutYourAgency = new TestObjectProperties(Locator.CssSelector, ".form-label[for=SaleLevels_AgencyOverview]");
        public TestObjectProperties TxtAboutYourAgencyDetails = new TestObjectProperties(Locator.CssSelector, "#SaleLevels_AgencyOverview");
        public TestObjectProperties LnkMarketingSellingApproach = new TestObjectProperties(Locator.CssSelector, ".form-label[for=SaleLevels_MarketingPlan]");
        public TestObjectProperties TxtMarketingSellingApproachDetails = new TestObjectProperties(Locator.CssSelector, "#SaleLevels_MarketingPlan");



        public TestObjectProperties LstPropertiesBetween = new TestObjectProperties(Locator.CssSelector, "#SaleLevels[0].UpperBound");
        public TestObjectProperties LstCommissionTypes = new TestObjectProperties(Locator.CssSelector, "#SelectedCommissionType");
        public TestObjectProperties BtnAddHigherRange = new TestObjectProperties(Locator.CssSelector, ".add-range.button3");
        public TestObjectProperties BtnDeleteRange = new TestObjectProperties(Locator.CssSelector, ".delete-range.button3");
        public TestObjectProperties EltFeeStructureSection = new TestObjectProperties(Locator.CssSelector, ".col-xs-12.suppress-col-gutters.sale-entry");
        public TestObjectProperties BtnFeeStructureSubmit = new TestObjectProperties(Locator.CssSelector, "#continue-button");

        public TestObjectProperties LstFirstFeeStrPropertiesBetweenLB = new TestObjectProperties(Locator.Name, "SaleLevels[0].LowerBound");
        public TestObjectProperties LstFirstFeeStrPropertiesBetweenUB = new TestObjectProperties(Locator.Name, "SaleLevels[0].UpperBound");
        public TestObjectProperties LstFirstFeeStrCommissionType = new TestObjectProperties(Locator.Name, "SaleLevels[0].CommissionTypes");
        public TestObjectProperties TxtFirstFeeStrCommissionPercentage = new TestObjectProperties(Locator.Name, "SaleLevels[0].CommissionPercentage");
        public TestObjectProperties TxtFirstFeeStrCommissionFixed = new TestObjectProperties(Locator.Name, "SaleLevels[0].CommissionFixed");
        public TestObjectProperties LstFirstFeeStrMarketingBudget = new TestObjectProperties(Locator.Name, "SaleLevels[0].MarketingBudget");

        public TestObjectProperties LstSecondFeeStrPropertiesBetweenLB = new TestObjectProperties(Locator.Name, "SaleLevels[1].LowerBound");
        public TestObjectProperties LstSecondFeeStrPropertiesBetweenUB = new TestObjectProperties(Locator.Name, "SaleLevels[1].UpperBound");
        public TestObjectProperties LstSecondFeeStrCommissionType = new TestObjectProperties(Locator.Name, "SaleLevels[1].CommissionTypes");
        public TestObjectProperties TxtSecondFeeStrCommissionPercentage = new TestObjectProperties(Locator.Name, "SaleLevels[1].CommissionPercentage");
        public TestObjectProperties TxtSecondFeeStrCommissionFixed = new TestObjectProperties(Locator.Name, "SaleLevels[1].CommissionFixed");
        public TestObjectProperties LstSecondFeeStrMarketingBudget = new TestObjectProperties(Locator.Name, "SaleLevels[1].MarketingBudget");

        public TestObjectProperties LstThirdFeeStrPropertiesBetweenLB = new TestObjectProperties(Locator.Name, "SaleLevels[2].LowerBound");
        public TestObjectProperties LstThirdFeeStrPropertiesBetweenUB = new TestObjectProperties(Locator.Name, "SaleLevels[2].UpperBound");
        public TestObjectProperties LstThirdFeeStrCommissionType = new TestObjectProperties(Locator.Name, "SaleLevels[2].CommissionTypes");
        public TestObjectProperties TxtThirdFeeStrCommissionPercentage = new TestObjectProperties(Locator.Name, "SaleLevels[2].CommissionPercentage");
        public TestObjectProperties TxtThirdFeeStrCommissionFixed = new TestObjectProperties(Locator.Name, "SaleLevels[2].CommissionFixed");
        public TestObjectProperties LstThirdFeeStrMarketingBudget = new TestObjectProperties(Locator.Name, "SaleLevels[2].MarketingBudget");

        public TestObjectProperties EltErrors = new TestObjectProperties(Locator.CssSelector, ".validation-summary-errors li");

        public TestObjectProperties LstLettingFee = new TestObjectProperties(Locator.Id, "RentLevels[0].LettingFee");
        public TestObjectProperties LstManagementFee = new TestObjectProperties(Locator.Id, "RentLevels[0].ManagementCommissionPercentage");
        public TestObjectProperties LstMarketingBudget = new TestObjectProperties(Locator.Id, "RentLevels[0].MarketingBudget");
        public TestObjectProperties LnkDiscardChanges = new TestObjectProperties(Locator.LinkText, "Discard changes");

        public TestObjectProperties EltConfirmationMessage = new TestObjectProperties(Locator.CssSelector, "div.modal-body > div > h2");
        public TestObjectProperties BtnGoToYourPortal = new TestObjectProperties(Locator.CssSelector, ".button.welcome-button");

        public TestObjectProperties EltAgentDashboardWelcomeMsg = new TestObjectProperties(Locator.CssSelector, ".col-xs-12.col-sm-4.welcome>h2");

        public TestObjectProperties EltSalutation1 = new TestObjectProperties(Locator.CssSelector, ".modal-title>.salutations-1");
        public TestObjectProperties EltSalutation2 = new TestObjectProperties(Locator.CssSelector, ".modal-title>.salutations-2");
        public TestObjectProperties BtnGotIt = new TestObjectProperties(Locator.CssSelector, ".btn.btn-default.btn-accept.swelcome-button");


        public TestObjectProperties EltProgressSalesMethodsSection = new TestObjectProperties(Locator.CssSelector,
                                                                    ".progress-section>.section.methods");
        public TestObjectProperties EltProgressSalesMethodsCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.methods>.progress-point.checkmark");
        public TestObjectProperties EltProgressSalesMethodsCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.methods>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressSalesMethodsLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.methods>.section-label");


        public TestObjectProperties EltProgressLanguagesSection = new TestObjectProperties(Locator.CssSelector,
                                                                    ".progress-section>.section.languages");
        public TestObjectProperties EltProgressLanguagesCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.languages>.progress-point.checkmark");
        public TestObjectProperties EltProgressLanguagesCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.languages>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressLanguagesLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.languages>.section-label");


        public TestObjectProperties EltProgressSaleAuthSection = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.authority");
        public TestObjectProperties EltProgressSaleAuthCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.authority>.progress-point.checkmark");
        public TestObjectProperties EltProgressSaleAuthCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.authority>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressSaleAuthLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.authority>.section-label");

        public TestObjectProperties EltProgressSaleTeamSection = new TestObjectProperties(Locator.CssSelector,
                                                           ".progress-section>.section.team-size");
        public TestObjectProperties EltProgressSaleTeamCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.team-size>.progress-point.checkmark");
        public TestObjectProperties EltProgressSaleTeamCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.team-size>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressSaleTeamLabel = new TestObjectProperties(Locator.CssSelector,
                                                            ".progress-section>.section.team-size>.section-label");

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
