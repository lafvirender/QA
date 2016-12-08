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
    public class PropertyDescriptionFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public PropertyDescriptionFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("PropertyDescriptionFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"I am on Prop_Reg Page")]
        public void GivenIAmOnProp_RegPage()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Property Description after entering details")]
        public void GivenINavigateToPropertyDescriptionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToPropertyDescAfterEnteringDetailsAs(propRegFields);
        }


        [Then(@"Q ""(.*)"" should be displayed for Property Description section")]
        public void ThenQShouldBeDisplayedForPropertyDescriptionSection(string qText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Progress line indicates selection of Address")]
        public void ThenProgressLineIndicatesSelectionOfAddress()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatProgressLineIndicatesFillingOfAddress());
        }

        [Then(@"Link for Moving Forward is disabled")]
        public void ThenLinkForMovingForwardIsDisabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Agent Details Progress should be displayed as activated")]
        public void ThenAgentDetailsProgressShouldBeDisplayedAsActivated()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatAgentIsActiveInProgressBar());
        }

        [Then(@"Agent Details Progress Circle should be displayed as not Filled")]
        public void ThenAgentDetailsProgressCircleShouldBeDisplayedAsNotFilled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyThatAgentCircleIsNotFilledInProgressBar());
        }

        [Then(@"Option My Home  with text ""(.*)"" should be displayed")]
        public void ThenOptionMyHomeWithTextShouldBeDisplayed(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyDescription.ShouldVerifyoptionMyHomeTextWith(sText));
        }

        [Then(@"Option Vacant Property  with text ""(.*)"" should be displayed")]
        public void ThenOptionVacantPropertyWithTextShouldBeDisplayed(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyDescription.ShouldVerifyoptionVacantPropertyTextWith(sText));
        }

        [Then(@"Option Tenanted Property  with text ""(.*)"" should be displayed")]
        public void ThenOptionTenantedPropertyWithTextShouldBeDisplayed(string sText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyDescription.ShouldVerifyoptionTenantedPropertyTextWith(sText));
        }

        [When(@"I Select option as ""(.*)""")]
        public void WhenISelectOptionAs(string propDescOption)
        {
            BasePage.PropertyRegistrationFunnel.PropertyDescription.SelectLeasedOptionAs(propDescOption);
        }

        [Then(@"Specific Agencies question should be displayed")]
        public void ThenSpecificAgenciesQuestionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.SpecificAgencies.IsDisplayed());
        }

        [Then(@"Field for entering Leasing Details should be available")]
        public void ThenFieldForEnteringLeasingDetailsShouldBeAvailable()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyDescription.ShouldVerifyThatLeasingDetailsfieldisAvailable());
        }

        [When(@"Click Next")]
        public void WhenClickNext()
        {
            BasePage.PropertyRegistrationFunnel.PropertyDescription.ClickNext();
        }

        [Then(@"Error is displayed for empty Leasing Details field")]
        public void ThenErrorIsDisplayedForEmptyLeasingDetailsField()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.PropertyDescription.ShouldVerifyErrorForLeasingDetailsField());
        }

        [When(@"I Select leased option as ""(.*)"" and enter leased details as ""(.*)""")]
        public void WhenISelectLeasedOptionAsAndEnterLeasedDetailsAs(string leaseOption, string leaseDetails)
        {
            BasePage.PropertyRegistrationFunnel.PropertyDescription.EnterLeasedInformation(leaseOption, leaseDetails);
        }


    }
}
