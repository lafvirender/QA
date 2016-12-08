using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentProposalForSellSteps
{
    [Binding]
    public class AgentBiographyFieldsVerificationSteps: TestInitialization
    {
        Reporter Reporter;
        public AgentBiographyFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("AgentBiographyFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User is on Agent_Registraion Page")]
        public void GivenUserIsOnAgent_RegistraionPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }


        [Given(@"User navigates to BeginProposal Page after registering agent with details as below")]
        public void GivenUserNavigatesToBeginProposalPageAfterRegisteringAgentWithDetailsAsBelow(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Your Biography section after entering details as")]
        public void WhenUserNavigatesToYourBiographySectionAfterEnteringDetailsAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToAgentBiographySectionAfterEnteringDetailsAs(vendPropFields);
        }

        [Then(@"Heading Text ""(.*)"" is displayed for Agent Biography section")]
        public void ThenHeadingTextIsDisplayedForAgentBiographySection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentBiography.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User clicks Next after entering biography details As")]
        public void WhenUserClicksNextAfterEnteringBiographyDetailsAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.AgentBiography.SetAgentBiographyDetailsAs(vendPropFields.AboutYouDetails,vendPropFields.AboutYourAgencyDetails, vendPropFields.MarketingSellingApproach);
        }

        [Then(@"Agent Fee Structure section is displayed")]
        public void ThenAgentFeeStructureSectionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentFeeStructure.IsDisplayed());
        }

        [Then(@"Biography circle should be displayed as Active")]
        public void ThenBiographyCircleShouldBeDisplayedAsActive()
        {
           Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatBiographyIsActiveInProgressBar());
        }

        [Then(@"Biography circle should be displayed as Checked")]
        public void ThenBiographyCircleShouldBeDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatBiographyCircleIsChecked());
        }

        [Then(@"Tabs About You, About Your Agency and Marketing & Renting approch should be displayed")]
        public void ThenTabsAboutYouAboutYourAgencyAndMarketingRentingApprochShouldBeDisplayed()
        {
            BasePage.AgentProposalForSellFunnel.AgentBiography.ShouldVerifyThatTabsForEnteringBiographyShouldBeDisplayed();
        }

    }
}
