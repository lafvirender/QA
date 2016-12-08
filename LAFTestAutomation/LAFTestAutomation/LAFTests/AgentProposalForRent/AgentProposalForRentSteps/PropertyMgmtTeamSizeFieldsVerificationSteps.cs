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
    public class PropertyMgmtTeamSizeFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public PropertyMgmtTeamSizeFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("PropertyMgmtTeamSizeFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User goes to Agent_Reg_Page")]
        public void GivenUserGoesToAgent_Reg_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User goes to BeginProposal after registering agent with")]
        public void GivenUserGoesToBeginProposalAfterRegisteringAgentWith(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Property Managment Team Size selection")]
        public void ThenQuestionIsDisplayedForPropertyManagmentTeamSizeSelection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.PropertyManagementTeam.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Error with message ""(.*)"" is displayed")]
        public void ThenErrorWithMessageIsDisplayed(string errText)
        {
            Assert.IsTrue(BasePage.AgentProposalForRentFunnel.PropertyManagementTeam.ShouldVerifyThatErrorIsDisplayed(errText));
        }

        [When(@"User navigates to Property Management Team Size Selection page")]
        public void WhenUserNavigatesToPropertyManagementTeamSizeSelectionPage()
        {
            BasePage.AgentProposalForRentFunnel.ShouldNavigateToPropertyManagementTeamSizeSelectionPage();
        }

        [When(@"User clicks Next after selecting Property Management Team Size As")]
        public void WhenUserClicksNextAfterSelectingPropertyManagementTeamSizeAs(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.PropertyManagementTeam.SetPropMgmtTeamSizeAs(landlordProposalFields.PropertyMgmtTeamSize);
        }

        [Then(@"Property Per Property Manager selection question is displayed")]
        public void ThenPropertyPerPropertyManagerSelectionQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.PropertyPerPropertyManager.IsDisplayed());
        }

        [When(@"User clicks Next")]
        public void WhenUserClicksNext()
        {
            BasePage.AgentProposalForRentFunnel.PropertyManagementTeam.ClickNext();
        }

        [Then(@"Team Size circle is displayed as Active")]
        public void ThenTeamSizeCircleIsDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatTeamSizeIsActiveInProgressBar());
        }

        [Then(@"Team Size circle is displayed as Checked")]
        public void ThenTeamSizeCircleIsDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatTeamSizeCircleIsChecked());
        }

    }
}
