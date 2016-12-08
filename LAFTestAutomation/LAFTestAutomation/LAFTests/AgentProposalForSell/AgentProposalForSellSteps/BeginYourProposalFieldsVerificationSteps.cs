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
    public class BeginYourProposalFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public BeginYourProposalFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("BeginYourProposalFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigates to Agent Registration Page")]
        public void GivenUserNavigatesToAgentRegistrationPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }


        [Given(@"User navigates to Begin Proposal after registering Agent with details")]
        public void GivenUserNavigatesToBeginProposalAfterRegisteringAgentWithDetails(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [Then(@"HeadingText ""(.*)"" is displayed")]
        public void ThenHeadingTextIsDisplayed(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.BeginAgentProposal.ShouldVerifyTheQuestionWith(qText));
        }

        [Given(@"User clicks Begin")]
        public void GivenUserClicksBegin()
        {
            BasePage.AgentProposalForSellFunnel.BeginAgentProposal.SelectBegin();
        }


        [Then(@"Sales Method Selection page is displayed")]
        public void ThenSalesMethodSelectionPageIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.IsDisplayed());
        }


    }
}
