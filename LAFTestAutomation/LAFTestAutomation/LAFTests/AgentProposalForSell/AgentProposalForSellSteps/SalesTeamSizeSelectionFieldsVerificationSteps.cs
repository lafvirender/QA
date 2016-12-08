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
    public class SalesTeamSizeSelectionFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;

        public SalesTeamSizeSelectionFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("SalesTeamSizeSelectionFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigates to Begin Proposal after registering agent with")]
        public void GivenUserNavigatesToBeginProposalAfterRegisteringAgentWith(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [Given(@"User navigates to Agent_Reg_Page")]
        public void GivenUserNavigatesToAgent_Reg_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }


        [When(@"User navigates to Sales Team Size Selection after selecting details as")]
        public void WhenUserNavigatesToSalesTeamSizeSelectionAfterSelectingDetailsAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToSaleTeamSizeSelectionAfterEnteringDetailsAs(vendPropFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Sales Team Size selection")]
        public void ThenQuestionIsDisplayedForSalesTeamSizeSelection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesTeamSelection.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User clicks Next after selecting Sales Team Size As")]
        public void WhenUserClicksNextAfterSelectingSalesTeamSizeAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.SalesTeamSelection.SetSaleTeamSizeAs(vendPropFields.SaleTeamSize);
        }

        [Then(@"Postcode selection question is displayed")]
        public void ThenPostcodeSelectionQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.PostCodeSelection.IsDisplayed());
        }

        [Given(@"User navigates to Sales Team Size Selection after selecting details as")]
        public void GivenUserNavigatesToSalesTeamSizeSelectionAfterSelectingDetailsAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToSaleTeamSizeSelectionAfterEnteringDetailsAs(vendPropFields);
        }

        [Then(@"Team Size circle should be displayed as Active")]
        public void ThenTeamSizeCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatSaleTeamIsActiveInProgressBar());
        }

        [Then(@"Team Size circle should be displayed as Checked")]
        public void ThenTeamSizeCircleShouldBeDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatSaleTeamCircleIsChecked());
        }

    }
}
