using TechTalk.SpecFlow;
using LAFTestAutomationFramework.Pages;
using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.PropertyRegistrationSteps
{
    [Binding]
    public class CustomerDetailsFieldsVerificationSteps :TestInitialization
    {
        Reporter Reporter;
        public CustomerDetailsFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("CustomerDetailsFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"I am on Property_Listing Page")]
        public void GivenIAmOnProperty_ListingPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Customer Details section after entering details")]
        public void GivenINavigateToCustomerDetailsSectionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToCustomerDetailsSectionAfterEnteringDetailsAs(propRegFields);
        }

        [Given(@"I navigate to Direct Connect section after entering details")]
        public void GivenINavigateToDirectConnectSectionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToDirectConnectSectionAfterEnteringDetailsAs(propRegFields);
        }


        [Then(@"Forward Link is not enabled")]
        public void ThenForwardLinkIsNotEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Selection of Contacted Agencies is displayed in Progress section")]
        public void ThenSelectionOfContactedAgenciesIsDisplayedInProgressSection()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfContactedAgency());
        }

        [Then(@"You is the progress section is displayed as activated")]
        public void ThenYouIsTheProgressSectionIsDisplayedAsActivated()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatYouIsActiveInProgressBar());
        }

        [When(@"Enter values in Customer Details Fields as")]
        public void WhenEnterValuesInCustomerDetailsFieldsAs(Table table)
        {
            var custDetails = table.CreateInstance<CustomerDetailsFields>();
            BasePage.PropertyRegistrationFunnel.PersonalDetails.EnterPersonalDetailsAs(custDetails.FirstName, custDetails.LastName,
                                                                                     custDetails.Email, custDetails.Mobile);
        }

        [Then(@"Error is displayed for empty First Name field")]
        public void ThenErrorIsDisplayedForEmptyFirstNameField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PersonalDetails.ShouldVerifyErrorForFirstNameField());
        }

        [Then(@"Error is displayed for empty Last Name field")]
        public void ThenErrorIsDisplayedForEmptyLastNameField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PersonalDetails.ShouldVerifyErrorForLastNameField());
        }

        [Then(@"Error is displayed for empty Email field")]
        public void ThenErrorIsDisplayedForEmptyEmailField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PersonalDetails.ShouldVerifyErrorForEmailField());
        }

        [Then(@"Error is displayed for empty Mobile Number field")]
        public void ThenErrorIsDisplayedForEmptyMobileNumberField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PersonalDetails.ShouldVerifyErrorForMobileField());
        }

        [Given(@"I Provide the details in Property Registration")]
        public void GivenIProvideTheDetailsInPropertyRegistration(Table table)
        {
            var propertyDetails = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ListingCategory.SelectListingCategoryAs(propertyDetails.Category.ToString());
            BasePage.PropertyRegistrationFunnel.PropertyType.SelectPropertyTypeAs(propertyDetails.PropType.ToString());
            BasePage.PropertyRegistrationFunnel.Bedrooms.SelectBedroomAs(propertyDetails.Beds.ToString());
            BasePage.PropertyRegistrationFunnel.PropertyValue.SelectApproxValueAs(propertyDetails.ApproxValue.ToString());
            BasePage.PropertyRegistrationFunnel.PropertyAddress.EnterAddressManuallyAs(propertyDetails.UnitAppNo, propertyDetails.StreetNo, propertyDetails.Street,
                                                                                    propertyDetails.Suburb, propertyDetails.State, propertyDetails.PostCode);
            BasePage.PropertyRegistrationFunnel.PropertyDescription.EnterLeasedInformation(propertyDetails.Leased.ToString(), propertyDetails.LeasingDetails);
            BasePage.PropertyRegistrationFunnel.SpecificAgencies.EnterSpecificAgenciesInformation(propertyDetails.SpecificAgency.ToString(), propertyDetails.SpecificAgenciesDetails);
            BasePage.PropertyRegistrationFunnel.ContactedAgencies.EnterContactedAgenciesInformation(propertyDetails.ContactedAgency.ToString(), propertyDetails.ContactedAgenciesDetails);
        }

        [Then(@"Message ""(.*)"" is displayed after submitting the customer details who is selling property")]
        public void ThenMessageIsDisplayedAfterSubmittingTheCustomerDetailsWhoIsSellingProperty(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PersonalDetails.ShouldVerifySalutationForCustomerWhoIsSellingWith(sText));
        }

        [Then(@"Message ""(.*)"" is displayed after submitting the customer details who is renting property")]
        public void ThenMessageIsDisplayedAfterSubmittingTheCustomerDetailsWhoIsRentingProperty(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PersonalDetails.ShouldVerifySalutationForCustomerWhoIsRentingWith(sText));
        }


        [Given(@"I select option No for Direct Connect")]
        public void GivenISelectOptionNoForDirectConnect()
        {
            BasePage.PropertyRegistrationFunnel.PersonalDetails.SelectNo();
        }

        [Then(@"Field for entering Direct Connect Details is not displayed")]
        public void ThenFieldForEnteringDirectConnectDetailsIsNotDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PersonalDetails.ShouldVerifyThatDirectConnectDetailsfieldisAvailable());
        }

        [Given(@"I select option Yes for Direct Connect")]
        public void GivenISelectOptionYesForDirectConnect()
        {
            BasePage.PropertyRegistrationFunnel.PersonalDetails.SelectYes();
        }

        [Then(@"Field for entering Direct Connect Details is displayed")]
        public void ThenFieldForEnteringDirectConnectDetailsIsDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PersonalDetails.ShouldVerifyThatDirectConnectDetailsfieldisAvailable());
        }

    }
}
