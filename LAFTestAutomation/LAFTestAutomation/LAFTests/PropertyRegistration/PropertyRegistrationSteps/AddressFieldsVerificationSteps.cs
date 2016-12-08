using System;
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
    public class AddressFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        private AddressFields Address;
        public AddressFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("AddressFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"I am on Prop_Registration Page")]
        public void GivenIAmOnProp_RegistrationPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Address Section after entering details")]
        public void GivenINavigateToAddressSectionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToAddressSectionAfterEnteringDetailsAs(propRegFields);
        }


        [Then(@"Q ""(.*)"" should be displayed for Address")]
        public void ThenQShouldBeDisplayedForAddress(string qText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Option for entering the address manually with text ""(.*)"" should be displayed")]
        public void ThenOptionForEnteringTheAddressManuallyWithTextShouldBeDisplayed(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyManualAddressOptionTextWith(sText));
        }

        [Then(@"Search field should be available for searching address")]
        public void ThenSearchFieldShouldBeAvailableForSearchingAddress()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyThatAddressSearchfieldisAvailable());
        }

        [Then(@"Selection of Property Value is displayed in Progress section")]
        public void ThenSelectionOfPropertyValueIsDisplayedInProgressSection()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfPropValue());
        }


        [Then(@"Next button is available")]
        public void ThenNextButtonIsAvailable()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyThatNextButtonisAvailable());
        }

        [When(@"I select option for entering address manually")]
        public void WhenISelectOptionForEnteringAddressManually()
        {
            BasePage.PropertyRegistrationFunnel.PropertyAddress.SelectManualAddress();
        }

        [Then(@"Fields Unit/App No\., StreetNo\., Street, Suburb, State and PostCode should be displayed")]
        public void ThenFieldsUnitAppNo_StreetNo_StreetSuburbStateAndPostCodeShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyThatAddressFieldsForManualAddressEntryAreDisplayed());
        }

        [When(@"Enter values in UnitNo, Street, Suburb, State and Postcode fields")]
        public void WhenEnterValuesInUnitNoStreetSuburbStateAndPostcodeFields()
        {
            BasePage.PropertyRegistrationFunnel.PropertyAddress.EnterAddressManuallyAs("", "StreetNum", "StreetValue", "Suburb", "VIC", "3082");
        }

        [When(@"Enter values in Address Fields as")]
        public void WhenEnterValuesInAddressFieldsAs(Table table)
        {
            var address = table.CreateInstance<AddressFields>();
            BasePage.PropertyRegistrationFunnel.PropertyAddress.EnterAddressManuallyAs(address.UnitAppNo,address.StreetNo, 
                                                                                     address.Street,address.Suburb, 
                                                                                     address.State, address.PostCode);
        }


        [Then(@"Error is displayed for empty Street No field")]
        public void ThenErrorIsDisplayedForEmptyStreetNoField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyErrorForStreetNoField());
        }

        [Then(@"Error is displayed for empty Street field")]
        public void ThenErrorIsDisplayedForEmptyStreetField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyErrorForStreetField());
        }

        [Then(@"Error is displayed for empty Suburb field")]
        public void ThenErrorIsDisplayedForEmptySuburbField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyErrorForSuburbField());
        }

        [Then(@"Error is displayed for empty State field")]
        public void ThenErrorIsDisplayedForEmptyStateField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyErrorForStateField());
        }

        [Then(@"Error is displayed for empty PostCode field")]
        public void ThenErrorIsDisplayedForEmptyPostCodeField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyErrorForPostCodeField());
        }


        [Then(@"Error is displayed for empty Unit_AppNo field")]
        public void ThenErrorIsDisplayedForEmptyUnit_AppNoField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyErrorForUnit_AppNoField());
        }

        [Then(@"Property Description Question is Displayed")]
        public void ThenPropertyDescriptionQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyDescription.IsDisplayed());
        }

        [When(@"I enter search keyword as ""(.*)""")]
        public void WhenIEnterSearchKeywordAs(string schKeyword)
        {
            BasePage.PropertyRegistrationFunnel.PropertyAddress.SetValueInAddressSearchFieldAs(schKeyword);
        }

        [Then(@"Addresses in the address list should start with searched keyword ""(.*)""")]
        public void ThenAddressesInTheAddressListShouldStartWithSearchedKeyword(string schKeyword)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyThatAddressOptionsInListStartsWith(schKeyword));
        }

        [When(@"I select ""(.*)"" Option in the populated Address List")]
        public void WhenISelectOptionInThePopulatedAddressList(int listItemNumber)
        {
            Address = new AddressFields();
            Address = BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldSelectAddressInTheListFor(listItemNumber);
        }

        [Then(@"Correct Street No should be populated for selected address")]
        public void ThenCorrectStreetNoShouldBePopulatedForSelectedAddress()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyThatStreetNoFieldValueIs(Address.StreetNo));
        }

        [Then(@"Correct Street should be populated for selected address")]
        public void ThenCorrectStreetShouldBePopulatedForSelectedAddress()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyThatStreetFieldValueIs(Address.Street));
        }

        [Then(@"Correct Suburb should be populated for selected address")]
        public void ThenCorrectSuburbShouldBePopulatedForSelectedAddress()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyThatSuburbFieldValueIs(Address.Suburb));
        }

        [Then(@"Correct State should be populated for selected address")]
        public void ThenCorrectStateShouldBePopulatedForSelectedAddress()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyThatStateFieldValueIs(Address.State));
        }

        [Then(@"Correct PostCode should be populated for selected address")]
        public void ThenCorrectPostCodeShouldBePopulatedForSelectedAddress()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyThatPostCodeFieldValueIs(Address.PostCode));
        }

        [When(@"I Click Next")]
        public void WhenIClickNext()
        {
            BasePage.PropertyRegistrationFunnel.PropertyAddress.ClickNext();
        }

        [Then(@"Error is displayed for empty Address Search field")]
        public void ThenErrorIsDisplayedForEmptyAddressSearchField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyAddress.ShouldVerifyErrorForAddressSearchField());
        }

        [Then(@"Link for Moving Forward should not be enabled")]
        public void ThenLinkForMovingForwardShouldNotBeEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [When(@"I move back to Address section from Property Description section")]
        public void WhenIMoveBackToAddressSectionFromPropertyDescriptionSection()
        {
            BasePage.PropertyRegistrationFunnel.PropertyAddress.MoveBackToAddressSelection();
        }

        [Then(@"Progress line indicates entry of Address fields")]
        public void ThenProgressLineIndicatesEntryOfAddressFields()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfAddress());
        }

    }
}
