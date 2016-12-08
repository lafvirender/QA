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
    public class EmergencyContactFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public EmergencyContactFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("EmergencyContactFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User_navigates to Agent_Registration_Page")]
        public void GivenUser_NavigatesToAgent_Registration_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User_navigates to Begin_Proposal after registering agent with")]
        public void GivenUser_NavigatesToBegin_ProposalAfterRegisteringAgentWith(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Emergency Contact page  after entering details as")]
        public void WhenUserNavigatesToEmergencyContactPageAfterEnteringDetailsAs(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.ShouldNavigateToEmergencyContactPageAfterEnteringDetailsAs(landlordProposalFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Emergency Contact")]
        public void ThenQuestionIsDisplayedForEmergencyContact(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.EmergencyContact.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User selects option Yes")]
        public void WhenUserSelectsOptionYes()
        {
            BasePage.AgentProposalForRentFunnel.EmergencyContact.SelectYes();
        }

        [When(@"User selects option No")]
        public void WhenUserSelectsOptionNo()
        {
            BasePage.AgentProposalForRentFunnel.EmergencyContact.SelectNo();
        }


        [Then(@"Question for Landlord Insurance Advice is displayed")]
        public void ThenQuestionForLandlordInsuranceAdviceIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.LandlordInsuranceAdvice.IsDisplayed());
        }

        [Then(@"EMERGENCY circle should be displayed as Active")]
        public void ThenEMERGENCYCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatEmergencyIsActiveInProgressBar());
        }

        [Then(@"EMERGENCY circle is displayed as Checked")]
        public void ThenEMERGENCYCircleIsDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatEmergencyCircleIsChecked());
        }

        [Then(@"Links for Moving Forward is disabled")]
        public void ThenLinksForMovingForwardIsDisabled()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.IsForwardLinkDisabled());
        }

        [When(@"I move back to Emergency Selection from Landlord Insurance Advice")]
        public void WhenIMoveBackToEmergencySelectionFromLandlordInsuranceAdvice()
        {
            BasePage.AgentProposalForRentFunnel.LandlordInsuranceAdvice.GoBackToEmergencyContact();
        }

        [Then(@"Link for moving forward should be enabled")]
        public void ThenLinkForMovingForwardShouldBeEnabled()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.IsForwardLinkEnabled());
        }

        [When(@"I Click on Forward_Link")]
        public void WhenIClickOnForward_Link()
        {
            BasePage.AgentProposalForRentFunnel.EmergencyContact.ClickForwardLink();
        }

        [Then(@"Color of the Yes option should be ""(.*)""")]
        public void ThenColorOfTheYesOptionShouldBe(string expColor)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.EmergencyContact.ShouldVerifyTheColorOfYesOptionWith(expColor));
        }

        [Then(@"Color of the No option should be ""(.*)""")]
        public void ThenColorOfTheNoOptionShouldBe(string expColor)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.EmergencyContact.ShouldVerifyTheColorOfNoOptionWith(expColor));
        }


    }
}
