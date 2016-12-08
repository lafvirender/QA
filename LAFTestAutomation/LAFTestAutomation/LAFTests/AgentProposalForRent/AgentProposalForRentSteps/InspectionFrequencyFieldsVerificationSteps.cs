using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentProposalForRent.AgentProposalForRentSteps
{
    [Binding]
    public class InspectionFrequencyFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public InspectionFrequencyFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("InspectionFrequencyFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User_navigate to Agent Registration_Page")]
        public void GivenUser_NavigateToAgentRegistration_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to BeginProposal after registering agent with details")]
        public void GivenUserNavigatesToBeginProposalAfterRegisteringAgentWithDetails(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Inspection Frequency Selection after entering details as")]
        public void WhenUserNavigatesToInspectionFrequencySelectionAfterEnteringDetailsAs(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.ShouldNavigateToInspectionFreqPeriodPageAfterEnteringDetailsAs(landlordProposalFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Inspection Frequency selection")]
        public void ThenQuestionIsDisplayedForInspectionFrequencySelection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.InspectionFrequency.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User clicks Next after selecting Inspection Frequency As")]
        public void WhenUserClicksNextAfterSelectingInspectionFrequencyAs(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.InspectionFrequency.SetInspectionFrequencyPeriodAs(landlordProposalFields.InspectionFrequencyPeriod);
        }

        [Then(@"Question for Postcode selection is displayed")]
        public void ThenQuestionForPostcodeSelectionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.PostCodeSelection.IsDisplayed());
        }

        [Then(@"Inspection circle should be displayed as Active")]
        public void ThenInspectionCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatInspectionIsActiveInProgressBar());
        }

        [Then(@"Inspection circle is displayed as Checked")]
        public void ThenInspectionCircleIsDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatInspectionCircleIsChecked());
        }

        [Then(@"Below options should be available under Inspection Frequency drop down")]
        public void ThenBelowOptionsShouldBeAvailableUnderInspectionFrequencyDropDown(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.InspectionFrequency.ShouldDisplayTheInspectionFreqDropDownValuesAs(values));
        }

        [Then(@"Question for Postcode selection is not displayed")]
        public void ThenQuestionForPostcodeSelectionIsNotDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.PostCodeSelection.IsNotDisplayed());
        }

    }
}
