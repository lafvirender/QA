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
    public class RentalAgentFeeStructureFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public RentalAgentFeeStructureFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("RentalAgentFeeStructureFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigate to Agent_Reg Page")]
        public void GivenUserNavigateToAgent_RegPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User goes to Begin_Proposal Page after registering agent with details as below")]
        public void GivenUserGoesToBegin_ProposalPageAfterRegisteringAgentWithDetailsAsBelow(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Rental Agent Fee Structure section after entering details as")]
        public void WhenUserNavigatesToRentalAgentFeeStructureSectionAfterEnteringDetailsAs(Table table)
        {
            var landlordPropFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.ShouldNavigateToAgentRentalFeeStructureSectionAfterEnteringDetailsAs(landlordPropFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Rental Agent Fee Structure section")]
        public void ThenQuestionIsDisplayedForRentalAgentFeeStructureSection(string text)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.ShouldVerifyTheQuestionWith(text));
        }

        [Then(@"Below options should be available under  Letting Fee drop down")]
        public void ThenBelowOptionsShouldBeAvailableUnderLettingFeeDropDown(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.ShouldDisplayTheLettingFeeValuesAs(values));
        }

        [Then(@"Below options should be available under Marketing Budget")]
        public void ThenBelowOptionsShouldBeAvailableUnderMarketingBudget(Table table)
        {
            IList<string> values = new List<string>();
            foreach (var row in table.Rows)
            {
                values.Add((row[0].ToString()));
            }
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.ShouldDisplayTheMarketingBudgetValuesAs(values));
        }

        [Then(@"User Clicks Submit")]
        public void ThenUserClicksSubmit()
        {
            BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.ClickSubmit();
        }

        [Then(@"Confirmation for Rental Proposal Submission is displayed")]
        public void ThenConfirmationForRentalProposalSubmissionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.RentalProposalConfirmation.IsDisplayed());
        }

        [Then(@"User enters Rental Fee Details as")]
        public void ThenUserEntersRentalFeeDetailsAs(Table table)
        {
            var landlordPropFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.ShouldEntertheRentalFeeStructureDetailsAs(landlordPropFields);
        }

        [When(@"User enters Rental Fee Details as")]
        public void WhenUserEntersRentalFeeDetailsAs(Table table)
        {
            var landlordPropFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.ShouldEntertheRentalFeeStructureDetailsAs(landlordPropFields);
        }

        [When(@"User enters Management Fee as")]
        public void WhenUserEntersManagementFeeAs(Table table)
        {
            var landlordPropFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.ShouldEntertheRentalFeeStructureDetailsAs(landlordPropFields);
        }

        [When(@"User Clicks on Submit")]
        public void WhenUserClicksOnSubmit()
        {
            BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.ClickSubmit();
        }
 
        [Then(@"Error Message ""(.*)"" should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed(string errText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.ShouldVerifyThatErrorIsDisplayed(errText));
        }

        [Then(@"Fees circle is displayed as Active")]
        public void ThenFeesCircleIsDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatFeesIsActiveInProgressBar());
        }


    }
}
