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
    public class ContactedAgenciesFieldsVerificationSteps:TestInitialization
    {
        Reporter Reporter;
        public ContactedAgenciesFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("ContactedAgenciesFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }


        [Given(@"I am on PropertyListing Page")]
        public void GivenIAmOnPropertyListingPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Contacted Agencies section after entering details")]
        public void GivenINavigateToContactedAgenciesSectionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToContactedAgenciesSectionAfterEnteringDetailsAs(propRegFields);
        }

        [Then(@"Q ""(.*)"" should be displayed for Contacted Agencies")]
        public void ThenQShouldBeDisplayedForContactedAgencies(string qText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Moving Forward Link is not enabled")]
        public void ThenMovingForwardLinkIsNotEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Progress section displays filling of Specific Agencies Details")]
        public void ThenProgressSectionDisplaysFillingOfSpecificAgenciesDetails()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfSpecificAgency());
        }

        [Then(@"Option Yes  with text ""(.*)"" is displayed")]
        public void ThenOptionYesWithTextIsDisplayed(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ContactedAgencies.ShouldVerifyoptionYesTextWith(sText));
        }

        [Then(@"Option No  with text ""(.*)"" is displayed")]
        public void ThenOptionNoWithTextIsDisplayed(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ContactedAgencies.ShouldVerifyoptionNoTextWith(sText));
        }

        [When(@"I Select option as ""(.*)"" for Contacted Agencies")]
        public void WhenISelectOptionAsForContactedAgencies(string details)
        {
            BasePage.PropertyRegistrationFunnel.ContactedAgencies.EnterContactedAgenciesInformation(details,"");
        }

        [Then(@"Urgency section should be displayed")]
        public void ThenUrgencySectionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.Urgency.IsDisplayed());
        }


        [When(@"I Click Option YES for Contacted Agencies Details")]
        public void WhenIClickOptionYESForContactedAgenciesDetails()
        {
            BasePage.PropertyRegistrationFunnel.ContactedAgencies.SelectYes();
        }

        [Then(@"Field for entering Contacted Agencies Details should be available")]
        public void ThenFieldForEnteringContactedAgenciesDetailsShouldBeAvailable()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ContactedAgencies.ShouldVerifyThatContactedAgenciesDetailsfieldisAvailable());
        }

        [When(@"I Click Next without entering Contacted Agencies Details")]
        public void WhenIClickNextWithoutEnteringContactedAgenciesDetails()
        {
            BasePage.PropertyRegistrationFunnel.ContactedAgencies.ClickNext();
        }


        [Then(@"Error is displayed for empty Contacted Agencies Details field")]
        public void ThenErrorIsDisplayedForEmptyContactedAgenciesDetailsField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ContactedAgencies.ShouldVerifyErrorForContactedAgenciesDetailsField());
        }

    }
}
