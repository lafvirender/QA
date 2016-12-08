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
    public class RentalPostCodeSelectionFieldsVerificationSteps : TestInitialization 
    {
        Reporter Reporter;
        public RentalPostCodeSelectionFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("RentalPostCodeSelectionFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User is on Agent_SignUp_Page")]
        public void GivenUserIsOnAgent_SignUp_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to Begin_Proposal_Page after registering agent with")]
        public void GivenUserNavigatesToBegin_Proposal_PageAfterRegisteringAgentWith(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigate to Postcodes Selection after entering details as")]
        public void WhenUserNavigateToPostcodesSelectionAfterEnteringDetailsAs(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.ShouldNavigateToPostcodesSelectionAfterEnteringDetailsAs(landlordProposalFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Postcodes")]
        public void ThenQuestionIsDisplayedForPostcodes(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.PostCodeSelection.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User clicks on Next after entering postcodes As")]
        public void WhenUserClicksOnNextAfterEnteringPostcodesAs(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.PostCodeSelection.SetValueInPostCodes(landlordProposalFields.RentalPostCodes);
        }

        [Then(@"Your Biography section should be displayed")]
        public void ThenYourBiographySectionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.RentalAgentBiography.IsDisplayed());
        }

        [Then(@"Postcodes circle should be displayed as Active")]
        public void ThenPostcodesCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatPostcodesIsActiveInProgressBar());
        }

        [Then(@"Postcodes circle is displayed as Checked")]
        public void ThenPostcodesCircleIsDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatPostcodesCircleIsChecked());
        }

        [When(@"User clicks on Next after entering postcodes")]
        public void WhenUserClicksOnNextAfterEnteringPostcodes(Table table)
        {
            var landlordPropFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.PostCodeSelection.SetValueInPostCodes(landlordPropFields.RentalPostCodes);
            BasePage.AgentProposalForRentFunnel.PostCodeSelection.ClickNext();
        }

    }
}
