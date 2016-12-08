using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentProposalForSellSteps
{
    [Binding]
    public class SalesAuthSizeSelectionFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public SalesAuthSizeSelectionFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("SalesAuthSizeSelectionFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigates to Agent_Registration_Page")]
        public void GivenUserNavigatesToAgent_Registration_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }


        [Given(@"User navigates to BeginProposal after registering agent with")]
        public void GivenUserNavigatesToBeginProposalAfterRegisteringAgentWith(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Sales Authority Size Selection after selecting details as")]
        public void WhenUserNavigatesToSalesAuthoritySizeSelectionAfterSelectingDetailsAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToSaleAuthoritySelectionAfterEnteringDetailsAs(vendPropFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Authority Team Size selection")]
        public void ThenQuestionIsDisplayedForAuthorityTeamSizeSelection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SaleAuthority.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User clicks Next after selecting Sales Authority Size As")]
        public void WhenUserClicksNextAfterSelectingSalesAuthoritySizeAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.SaleAuthority.SetSaleAuthPeriodAs(vendPropFields.SaleAuthoritySize);
        }

        [Then(@"Sales Team selection question is displayed")]
        public void ThenSalesTeamSelectionQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesTeamSelection.IsDisplayed());
        }

        [Then(@"Authority circle should be displayed as Active")]
        public void ThenAuthorityCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatSaleAuthIsActiveInProgressBar());
        }

        [Then(@"Authority circle should be displayed as Checked")]
        public void ThenAuthorityCircleShouldBeDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatSaleAuthCircleIsChecked());
        }

        [Then(@"Below options should be available under Sale Authority Selection drop down")]
        public void ThenBelowOptionsShouldBeAvailableUnderSaleAuthoritySelectionDropDown(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SaleAuthority.ShouldDisplayTheSaleAuthorityValuesAs(values));
        }

    }
}
