using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentRegSteps
{
    [Binding]
    public class KeyInfoFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public KeyInfoFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("KeyInfoFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }


        [Given(@"User navigates to Agent_SignUp Page")]
        public void GivenUserNavigatesToAgent_SignUpPage()
        {
           BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Then(@"Heading ""(.*)"" is displayed")]
        public void ThenHeadingIsDisplayed(string qText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.KeyInfo.ShouldVerifyTheQuestionWith(qText));
        }

        [Given(@"User navigates to Key Information section after entering details as")]
        public void GivenUserNavigatesToKeyInformationSectionAfterEnteringDetailsAs(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToKeyInfoSectionAfterEnteringDetailsAs(agentRegFields);
        }

        [Given(@"User clicks on Accept & Continue button")]
        public void GivenUserClicksOnAcceptContinueButton()
        {
            BasePage.AgentRegistrationFunnel.KeyInfo.SelectAcceptAndContinue();
        }

        [Then(@"Terms and Conditions section should be displayed")]
        public void ThenTermsAndConditionsSectionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.TermsAndConditions.IsDisplayed());
        }
        [Then(@"Key Information section for both Sales and Rentals should be displayed")]
        public void ThenKeyInformationSectionForBothSalesAndRentalsShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.KeyInfo.KeyInformationSectionForBothSalesAndRentalsAreDisplayed());
        }

        [Then(@"Key Information section for Sales should be displayed")]
        public void ThenKeyInformationSectionForSalesShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.KeyInfo.ShouldVerifySalesKeyInformationIsDisplayed());
        }

        [Then(@"Key Information section for Rentals should be displayed")]
        public void ThenKeyInformationSectionForRentalsShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.KeyInfo.ShouldVerifyRentalKeyInformationIsDisplayed());
        }

    }
}
