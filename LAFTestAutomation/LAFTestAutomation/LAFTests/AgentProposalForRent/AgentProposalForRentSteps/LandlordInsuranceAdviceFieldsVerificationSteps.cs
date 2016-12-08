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
    public class LandlordInsuranceAdviceFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public LandlordInsuranceAdviceFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("LandlordInsuranceAdviceFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User_navigate to Agent_Registration_Page")]
        public void GivenUser_NavigateToAgent_Registration_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User_navigates to Begin_Proposal after registering agent with details")]
        public void GivenUser_NavigatesToBegin_ProposalAfterRegisteringAgentWithDetails(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }


        [When(@"User navigates to Landlord Insurance page  after entering details as")]
        public void WhenUserNavigatesToLandlordInsurancePageAfterEnteringDetailsAs(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.ShouldNavigateToLandlordInsuranceAdvicePageAfterEnteringDetailsAs(landlordProposalFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Landlord Insurance Advice")]
        public void ThenQuestionIsDisplayedForLandlordInsuranceAdvice(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.LandlordInsuranceAdvice.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User selects Yes")]
        public void WhenUserSelectsYes()
        {
            BasePage.AgentProposalForRentFunnel.LandlordInsuranceAdvice.SelectYes();
        }

        [Then(@"Question for selecting Inspection Frequency is displayed")]
        public void ThenQuestionForSelectingInspectionFrequencyIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.InspectionFrequency.IsDisplayed());
        }

        [When(@"User selects No")]
        public void WhenUserSelectsNo()
        {
            BasePage.AgentProposalForRentFunnel.LandlordInsuranceAdvice.SelectNo();
        }

        [Then(@"Insurance circle should be displayed as Active")]
        public void ThenInsuranceCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatInsuranceIsActiveInProgressBar());
        }

        [Then(@"Insurance circle is displayed as Checked")]
        public void ThenInsuranceCircleIsDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatInsuranceCircleIsChecked());
        }

        [Then(@"Links for Moving_Forward is disabled")]
        public void ThenLinksForMoving_ForwardIsDisabled()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.IsForwardLinkDisabled());
        }
        [When(@"I move back to Landlord Insurance Advice from Property Inspection Frequency question")]
        public void WhenIMoveBackToLandlordInsuranceAdviceFromPropertyInspectionFrequencyQuestion()
        {
            BasePage.AgentProposalForRentFunnel.InspectionFrequency.GoBackToLandlordInsuranceQ();
        }

        [When(@"I Click Forward_Link")]
        public void WhenIClickForward_Link()
        {
            BasePage.AgentProposalForRentFunnel.ClickForward();
        }


        [Then(@"Link for moving_forward is enabled")]
        public void ThenLinkForMoving_ForwardIsEnabled()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.IsForwardLinkEnabled());
        }

        [Then(@"Color of the Yes option is ""(.*)""")]
        public void ThenColorOfTheYesOptionIs(string expColor)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.LandlordInsuranceAdvice.ShouldVerifyTheColorOfYesOptionWith(expColor));
        }

        [Then(@"Color of the No option is ""(.*)""")]
        public void ThenColorOfTheNoOptionIs(string expColor)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.LandlordInsuranceAdvice.ShouldVerifyTheColorOfNoOptionWith(expColor));
        }

    }
}
