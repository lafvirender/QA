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
    public class SpecificAgenciesFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public SpecificAgenciesFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("SpecificAgenciesFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }


        [Given(@"I am on Property_reg Page")]
        public void GivenIAmOnProperty_RegPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Specific Agencies section after entering details")]
        public void GivenINavigateToSpecificAgenciesSectionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToSpecificAgenciesSectionAfterEnteringDetailsAs(propRegFields);
        }

        [Then(@"Q ""(.*)"" should be displayed for Specific Agencies")]
        public void ThenQShouldBeDisplayedForSpecificAgencies(string qText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Moving Forward should not be enabled")]
        public void ThenMovingForwardShouldNotBeEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Agent Circle in the Progress is displayed as Filled")]
        public void ThenAgentCircleInTheProgressIsDisplayedAsFilled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatAgentCircleIsFilledInProgressBar());
        }

        [Then(@"Option Yes  with text ""(.*)"" should be displayed")]
        public void ThenOptionYesWithTextShouldBeDisplayed(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.SpecificAgencies.ShouldVerifyoptionYesTextWith(sText));
        }

        [Then(@"Option No  with text ""(.*)"" should be displayed")]
        public void ThenOptionNoWithTextShouldBeDisplayed(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.SpecificAgencies.ShouldVerifyoptionNoTextWith(sText));
        }

        [When(@"I Select option as ""(.*)"" for Specific Agencies")]
        public void WhenISelectOptionAsForSpecificAgencies(string option)
        {
            BasePage.PropertyRegistrationFunnel.SpecificAgencies.EnterSpecificAgenciesInformation(option,"");
        }

        [Then(@"Contacted Agencies question should be displayed")]
        public void ThenContactedAgenciesQuestionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ContactedAgencies.IsDisplayed());
        }

        [Then(@"Field for entering Specific Agencies Details should be available")]
        public void ThenFieldForEnteringSpecificAgenciesDetailsShouldBeAvailable()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.SpecificAgencies.ShouldVerifyThatSpecificAgenciesDetailsfieldisAvailable());
        }

        [When(@"I Click Option YES for Specific Agencies Details")]
        public void WhenIClickOptionYESForSpecificAgenciesDetails()
        {
            BasePage.PropertyRegistrationFunnel.SpecificAgencies.SelectYes();
        }

        [When(@"I Click Next without entering Specific Agencies Details")]
        public void WhenIClickNextWithoutEnteringSpecificAgenciesDetails()
        {
            BasePage.PropertyRegistrationFunnel.SpecificAgencies.ClickNext();
        }

        [Then(@"Error is displayed for empty Specific Agencies Details field")]
        public void ThenErrorIsDisplayedForEmptySpecificAgenciesDetailsField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.SpecificAgencies.ShouldVerifyErrorForSpecificAgenciesDetailsField());
        }

    }
}
