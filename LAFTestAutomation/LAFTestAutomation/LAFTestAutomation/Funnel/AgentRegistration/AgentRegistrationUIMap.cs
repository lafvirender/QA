using System.Linq.Expressions;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration
{
    public class AgentRegistrationUIMap
    {

        public TestObjectProperties EltErrors = new TestObjectProperties(Locator.CssSelector, ".validation-summary-errors li");
        // public TestObjectProperties EltbeforeYouStartSlide = new TestObjectProperties(Locator.CssSelector,
        //                                                         ".slide[data-slick-index='0']");
        public TestObjectProperties EltbeforeYouStartSlide = new TestObjectProperties(Locator.Id,"tab1");

        //public TestObjectProperties EltpropCategorySlide = new TestObjectProperties(Locator.CssSelector,
        //                                                        ".slide.propertycategory[data-slick-index='1']");
        public TestObjectProperties EltpropCategorySlide = new TestObjectProperties(Locator.Id, "tab2");

        //public TestObjectProperties EltaboutYouSlide = new TestObjectProperties(Locator.CssSelector,
        //                                                        ".slide.propertycategory[data-slick-index='2']");
        public TestObjectProperties EltaboutYouSlide = new TestObjectProperties(Locator.Id, "tab3");

        //public TestObjectProperties EltagencyDetailsSlide = new TestObjectProperties(Locator.CssSelector,
        //                                                        ".slide.propertycategory[data-slick-index='3']");
        public TestObjectProperties EltagencyDetailsSlide = new TestObjectProperties(Locator.Id, "tab4");

        //public TestObjectProperties EltAreYouThePrincipalSlide = new TestObjectProperties(Locator.CssSelector,
        //                                                ".slide.propertycategory[data-slick-index='4']");
        public TestObjectProperties EltAreYouThePrincipalSlide = new TestObjectProperties(Locator.Id, "tab5");


        //public TestObjectProperties EltKeyInfoSlide = new TestObjectProperties(Locator.CssSelector,
        //                                               ".slide.propertycategory[data-slick-index='5']");

        public TestObjectProperties EltKeyInfoSlide = new TestObjectProperties(Locator.Id, "tab6");

        //public TestObjectProperties EltTermsAndCondSlide = new TestObjectProperties(Locator.CssSelector,
        //                                               ".slide.propertycategory[data-slick-index='6']");
        public TestObjectProperties EltTermsAndCondSlide = new TestObjectProperties(Locator.Id, "tab7");

        //public TestObjectProperties EltAgentWelcomeSlide = new TestObjectProperties(Locator.CssSelector,
        //                                               ".slide.propertycategory[data-slick-index='7']");

        public TestObjectProperties EltAgentWelcomeSlide = new TestObjectProperties(Locator.Id, "tab8");
        public TestObjectProperties EltAgentRegCompleteMessage = new TestObjectProperties(Locator.CssSelector, ".col-xs-12>h2");
        public TestObjectProperties EltAgentWelcomeTextContFirstName = new TestObjectProperties(Locator.CssSelector, ".col-xs-12 p");
           
        public TestObjectProperties EltQuestion = new TestObjectProperties(Locator.CssSelector,
                                                       "div[aria-hidden=false]>.question");

        public TestObjectProperties EltBeforeYouStartHeading = new TestObjectProperties(Locator.CssSelector,
                                                                         "#tab1 .form-section>h2");
        public TestObjectProperties EltAgentInterestQuestion = new TestObjectProperties(Locator.CssSelector,
                                                                         "#tab2 .col-xs-12>h2");

        public TestObjectProperties EltAgentPersonalDetailsQuestion = new TestObjectProperties(Locator.CssSelector,
                                                                         "#tab3 .form-section>h2");

        public TestObjectProperties EltAgencyDetailsHeading = new TestObjectProperties(Locator.CssSelector,
                                                                         "#tab4 .form-section>h2");

        public TestObjectProperties EltAreYouPrincipalQuestion = new TestObjectProperties(Locator.CssSelector,
                                                                         "#tab5 .form-section h2");

        public TestObjectProperties EltKeyInfoHeading = new TestObjectProperties(Locator.CssSelector,
                                                                         "#tab6 .form-section>h2");


        public TestObjectProperties EltProgressAboutYouSection = new TestObjectProperties(Locator.CssSelector,
                                                                     ".progress-section>.section.your-details");
        public TestObjectProperties EltProgressAboutYouCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.your-details>.progress-point.checkmark");
        public TestObjectProperties EltProgressAboutYouCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                        ".progress-section>.section.your-details>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressAboutYouLabel = new TestObjectProperties(Locator.CssSelector,
                                    ".progress-section>.section.your-details>.section-label");

        public TestObjectProperties EltProgressAgentSignUpLineAgentDetails = new TestObjectProperties(Locator.CssSelector,
                ".progress-section>.section.your-details>.progress-point.line[data-parameter=Agent]");
        public TestObjectProperties EltProgressAgentSignUpLineSectionAgentDetails = new TestObjectProperties(Locator.CssSelector,
                ".progress-section>.section.your-details>.progress-point.line[data-parameter=Agent]>.line-section");

        public TestObjectProperties EltProgressAgencySection = new TestObjectProperties(Locator.CssSelector,
                                                                        ".progress-section>.section.your-agency");
        public TestObjectProperties EltProgressAgencyCheckmark = new TestObjectProperties(Locator.CssSelector,
                                                 ".progress-section>.section.your-agency>.progress-point.checkmark");
        public TestObjectProperties EltProgressAgencyCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
                                                   ".progress-section>.section.your-agency>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressAgencyLabel = new TestObjectProperties(Locator.CssSelector,
                                                   ".progress-section>.section.your-agency>.section-label");

        public TestObjectProperties EltProgressAgentSignUpLinePrincipalDetails = new TestObjectProperties(Locator.CssSelector,
        ".progress-section>.section.your-details>.progress-point.line[data-parameter=Principal]");
        public TestObjectProperties EltProgressAgentSignUpLineSectionPrincipalDetails = new TestObjectProperties(Locator.CssSelector,
                ".progress-section>.section.your-details>.progress-point.line[data-parameter=Principal]>.line-section");

        public TestObjectProperties EltProgressKeyInfoSection = new TestObjectProperties(Locator.CssSelector,
                            ".progress-section>.section.key-info");
        public TestObjectProperties EltProgressKeyInfoCheckmark = new TestObjectProperties(Locator.CssSelector,
        ".progress-section>.section.key-info>.progress-point.checkmark");
        public TestObjectProperties EltProgressKeyInfoCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.key-info>.progress-point.checkmark>.checkmark_circle");
        public TestObjectProperties EltProgressKeyInfoLabel = new TestObjectProperties(Locator.CssSelector,
                           ".progress-section>.section.key-info>.section-label");

        public TestObjectProperties EltProgressTermsAndCondSection = new TestObjectProperties(Locator.CssSelector,
                            ".progress-section>.section.tcs");
        public TestObjectProperties EltProgressTermsAndCondCheckmark = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.tcs>.progress-point.checkmark");
        public  TestObjectProperties EltProgressTermsAndCondCheckmarkCircle = new TestObjectProperties(Locator.CssSelector,
            ".progress-section>.section.tcs>.progress-point.checkmark>.checkmark_circle");
        public  TestObjectProperties EltProgressTermsAndCondLabel = new TestObjectProperties(Locator.CssSelector,
                ".progress-section>.section.tcs>.section-label");

        public TestObjectProperties LnkSales = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Sales]");
        public TestObjectProperties LnkRentals = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Rentals]");
        public TestObjectProperties LnkBoth = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Both]");
        public TestObjectProperties LnkNext = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Next]");
        public TestObjectProperties LnkNextAboutYou = new TestObjectProperties(Locator.CssSelector, "a[data-event=Agent][data-parameter=Next]");
        public TestObjectProperties LnkNextAboutYourAgency = new TestObjectProperties(Locator.CssSelector, "a[data-event=Agency][data-parameter=Next]");
        public TestObjectProperties LnkNextPrincipalDetails = new TestObjectProperties(Locator.CssSelector, "a[data-event=Principal][data-parameter=Next]");
        public TestObjectProperties LnkNextKeyInfo = new TestObjectProperties(Locator.CssSelector, "a[data-event=KeyInformation][data-parameter=Next]");

        public TestObjectProperties LnkBack = new TestObjectProperties(Locator.CssSelector,
                                                 ".nav-section.prev-section>a");
        public TestObjectProperties LnkForward = new TestObjectProperties(Locator.CssSelector,
                                                 ".nav-section.next-section>a");
        public TestObjectProperties LnkManualAddress = new TestObjectProperties(Locator.CssSelector, "a.input-address-manually");

        //Agency Address
        public TestObjectProperties LnkAgencyAddressTab = new TestObjectProperties(Locator.LinkText, "AGENCY ADDRESS");

        public TestObjectProperties TxtAddressSearch = new TestObjectProperties(Locator.Id, "search");
        public TestObjectProperties LnkEnterAddressManually = new TestObjectProperties(Locator.CssSelector, ".input-address-manually");
        public TestObjectProperties LnkNextAgencyAddress = new TestObjectProperties(Locator.Id, "continue-button-1");
        public TestObjectProperties TxtUnitAppNo = new TestObjectProperties(Locator.Id, "AppartmentNo");
        public TestObjectProperties TxtStreetNo = new TestObjectProperties(Locator.Id, "StreetNo");
        public TestObjectProperties TxtStreet = new TestObjectProperties(Locator.Id, "Street");
        public TestObjectProperties TxtSuburb = new TestObjectProperties(Locator.Id, "Suburb");
        public TestObjectProperties TxtState = new TestObjectProperties(Locator.Id, "State");
        public TestObjectProperties TxtPostcode = new TestObjectProperties(Locator.Id, "Postcode");
        public TestObjectProperties EltMatchingAddressListItem = new TestObjectProperties(Locator.CssSelector, ".pca.pcalist>.pcaitem");

        //Agency Details
        public TestObjectProperties LnkAgencyDetailsTab = new TestObjectProperties(Locator.LinkText, "AGENCY DETAILS");
        public TestObjectProperties TxtAgencyName = new TestObjectProperties(Locator.Id, "CompanyName");
        public TestObjectProperties TxtBranchName = new TestObjectProperties(Locator.Id, "BranchName");
        public TestObjectProperties RbtnRentals = new TestObjectProperties(Locator.Id, "SupportedCategories_0_");
        public TestObjectProperties RbtnSales = new TestObjectProperties(Locator.Id, "SupportedCategories_1_");
        public TestObjectProperties RbtnBoth = new TestObjectProperties(Locator.Id, "SupportedCategories_2_");
        public TestObjectProperties TxtAgentPostCode1 = new TestObjectProperties(Locator.Id, "AgentPostcodes_0_");
        public TestObjectProperties TxtAgentPostCode2 = new TestObjectProperties(Locator.Id, "AgentPostcodes_1_");
        public TestObjectProperties TxtAgentPostCode3 = new TestObjectProperties(Locator.Id, "AgentPostcodes_2_");
        public TestObjectProperties TxtAgentPostCode4 = new TestObjectProperties(Locator.Id, "AgentPostcodes_3_");
        public TestObjectProperties TxtAgentPostCode5 = new TestObjectProperties(Locator.Id, "AgentPostcodes_4_");
        public TestObjectProperties LnkNextAgencyDetails = new TestObjectProperties(Locator.Id, "continue-button-2");

        //Agent Details
        public TestObjectProperties LnkYourDetailsTab = new TestObjectProperties(Locator.LinkText, "YOUR DETAILS");
        public TestObjectProperties TxtAgentFirstName = new TestObjectProperties(Locator.Id, "FirstName");
        public TestObjectProperties TxtAgentLastName = new TestObjectProperties(Locator.Id, "LastName");
        public TestObjectProperties TxtAgentPhoneNumber = new TestObjectProperties(Locator.Id, "WorkPhone");
        public TestObjectProperties TxtAgentMobile = new TestObjectProperties(Locator.Id, "Mobile");
        public TestObjectProperties TxtAgentEmail = new TestObjectProperties(Locator.Id, "Email");
        public TestObjectProperties LstAgentPosition = new TestObjectProperties(Locator.Id, "Title");

        public TestObjectProperties BtnIsPrincipalYes = new TestObjectProperties(Locator.CssSelector, "a[id=IsPrincipal]");
        public TestObjectProperties BtnIsPrincipalNo = new TestObjectProperties(Locator.CssSelector, "a[id=IsNotPrincipal]");
        public TestObjectProperties TxtPrincipalFirstName = new TestObjectProperties(Locator.Id, "PrincipalFirstName");
        public TestObjectProperties TxtPrincipalLastName = new TestObjectProperties(Locator.Id, "PrincipalLastName");
        public TestObjectProperties TxtPrincipalEmail = new TestObjectProperties(Locator.Id, "PrincipalEmail");

        //Key Info
        public TestObjectProperties BtnAcceptAndContinue = new TestObjectProperties(Locator.CssSelector, "a[option-parameter=KeyInformation][data-parameter=Next]");
        public TestObjectProperties EltSalesKeyInfo = new TestObjectProperties(Locator.CssSelector, ".sale-circle");
        public TestObjectProperties EltRentalsKeyInfo = new TestObjectProperties(Locator.CssSelector, ".rent-circle");
        public TestObjectProperties BtnBack = new TestObjectProperties(Locator.LinkText, "Back");
        public TestObjectProperties BtnContinueToTermsAndCond = new TestObjectProperties(Locator.Id, "continue-button");

        public TestObjectProperties LnkExpandTermsandCond = new TestObjectProperties(Locator.CssSelector, ".icon.popup-tcs");
        public TestObjectProperties ChkAcceptTermsandCond = new TestObjectProperties(Locator.CssSelector, "#AcceptTsAndCs");
        public TestObjectProperties BtnAcceptTerms = new TestObjectProperties(Locator.Id, "AcceptTerms");
        public TestObjectProperties EltTermsContainer = new TestObjectProperties(Locator.CssSelector, "#full-terms>div.full-terms-container>p:nth-child(5)");

        public TestObjectProperties BtnCreateMyProfile = new TestObjectProperties(Locator.CssSelector, ".col-xs-12 > a.option.large");
        public TestObjectProperties BtnBegin = new TestObjectProperties(Locator.CssSelector, "a[data-parameter=Next]");
        public TestObjectProperties EltBeginProposalHeading = new TestObjectProperties(Locator.CssSelector, "#SaleQuestions > div:nth-child(1) > h6");

        public TestObjectProperties EltTermsHeading = new TestObjectProperties(Locator.CssSelector, "section.terms > h2");
        public TestObjectProperties BtnCloseTermsPopup = new TestObjectProperties(Locator.CssSelector, ".mfp-close");
    }
}
