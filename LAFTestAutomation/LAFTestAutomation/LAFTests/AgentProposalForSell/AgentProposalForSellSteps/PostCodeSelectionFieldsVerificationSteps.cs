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
    class PostCodeSelectionFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public PostCodeSelectionFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("PostCodeSelectionFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User is on Agent_Reg_Page")]
        public void GivenUserIsOnAgent_Reg_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to BeginProposal Page after registering agent with")]
        public void GivenUserNavigatesToBeginProposalPageAfterRegisteringAgentWith(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Postcodes Selection after entering details as")]
        public void WhenUserNavigatesToPostcodesSelectionAfterEnteringDetailsAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToPostcodesSelectionAfterEnteringDetailsAs(vendPropFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Postcodes selection")]
        public void ThenQuestionIsDisplayedForPostcodesSelection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.PostCodeSelection.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User clicks Next after entering postcodes As")]
        public void WhenUserClicksNextAfterEnteringPostcodesAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.PostCodeSelection.SetValueInPostCodes(vendPropFields.PostCodes);
            BasePage.AgentProposalForSellFunnel.PostCodeSelection.ClickNext();
        }

        [Then(@"Your Biography section is displayed")]
        public void ThenYourBiographySectionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.AgentBiography.IsDisplayed());
        }

        [Then(@"PostCodes circle should be displayed as Active")]
        public void ThenPostCodesCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatPostCodesIsActiveInProgressBar());
        }

        [Then(@"PostCodes circle should be displayed as Checked")]
        public void ThenPostCodesCircleShouldBeDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatPostCodesCircleIsChecked());
        }

    }
}
