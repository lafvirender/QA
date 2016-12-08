using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentProposalForRent.AgentProposalForRentSteps
{
    [Binding]
    public class RentalBeginYourProposalFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public RentalBeginYourProposalFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("RentalBeginYourProposalFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigates to Agent_Reg Page")]
        public void GivenUserNavigatesToAgent_RegPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }


        [Given(@"User navigates to Begin_Proposal after registering Agent with details")]
        public void GivenUserNavigatesToBegin_ProposalAfterRegisteringAgentWithDetails(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [Then(@"Heading Text ""(.*)"" should be displayed")]
        public void ThenHeadingTextShouldBeDisplayed(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.BeginAgentProposal.ShouldVerifyTheQuestionWith(qText));
        }

        [Given(@"User clicks on Begin")]
        public void GivenUserClicksOnBegin()
        {
            BasePage.AgentProposalForRentFunnel.BeginAgentProposal.SelectBegin();
        }

        [Then(@"Property Managment Team Size selection section is dislayed")]
        public void ThenPropertyManagmentTeamSizeSelectionSectionIsDislayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.PropertyManagementTeam.IsDisplayed());
        }

    }
}
