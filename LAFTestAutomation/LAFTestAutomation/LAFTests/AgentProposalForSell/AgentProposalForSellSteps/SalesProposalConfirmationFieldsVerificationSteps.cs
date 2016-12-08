using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentProposalForSell.AgentProposalForSellSteps
{
    [Binding]
    public class SalesProposalConfirmationFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public SalesProposalConfirmationFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("SalesProposalConfirmationFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigates to Agent_Registration Page")]
        public void GivenUserNavigatesToAgent_RegistrationPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to Begin_Proposal Page after registering agent with details as below")]
        public void GivenUserNavigatesToBegin_ProposalPageAfterRegisteringAgentWithDetailsAsBelow(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"Submits the Sales proposal after entering details as")]
        public void WhenSubmitsTheSalesProposalAfterEnteringDetailsAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToSalesProposalConfirmationAfterEnteringDetailsAs(vendPropFields);
        }

        [When(@"User clicks on Go To Your Portal Button on Sales Confirm popup")]
        public void WhenUserClicksOnGoToYourPortalButtonOnSalesConfirmPopup()
        {
            BasePage.AgentProposalForSellFunnel.SalesProposalConfirmation.ClickGotoYourPortal();
        }

        [Then(@"Agent Dashboard is displayed")]
        public void ThenAgentDashboardIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesProposalConfirmation.ShouldVerifyThatAgentDashboardIsDisplayed());
        }

    }
}
