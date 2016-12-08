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
    public class RentalAgentBiographyFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public RentalAgentBiographyFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("RentalAgentBiographyFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigates to Agent_SignUp_Page")]
        public void GivenUserNavigatesToAgent_SignUp_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to BeginProposal Page after entering details for agent as")]
        public void GivenUserNavigatesToBeginProposalPageAfterEnteringDetailsForAgentAs(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Your Biography section after entering details")]
        public void WhenUserNavigatesToYourBiographySectionAfterEnteringDetails(Table table)
        {
            var landlordProposalFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.ShouldNavigateToAgentBiographySectionAfterEnteringDetailsAs(landlordProposalFields);
        }

        [Then(@"Heading Text ""(.*)"" should be displayed for Agent Biography section")]
        public void ThenHeadingTextShouldBeDisplayedForAgentBiographySection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.RentalAgentBiography.ShouldVerifyTheQuestionWith(qText));
        }

        [When(@"User clicks Next after entering details As")]
        public void WhenUserClicksNextAfterEnteringDetailsAs(Table table)
        {
            var landlordPropFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.RentalAgentBiography.SetAgentBiographyDetailsAs(landlordPropFields.RentalsAboutYouDetails, 
                                                            landlordPropFields.RentalsAboutYourAgencyDetails, landlordPropFields.RentalsMarketingSellingApproach);
        }

        [Then(@"Agent Rental Fee Structure section is displayed")]
        public void ThenAgentRentalFeeStructureSectionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.AgentRentalFeeStructure.IsDisplayed());
        }

        [Then(@"Biography circle is displayed as Active")]
        public void ThenBiographyCircleIsDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatBiographyIsActiveInProgressBar());
        }

        [Then(@"Biography circle is displayed as Checked")]
        public void ThenBiographyCircleIsDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatBiographyCircleIsChecked());
        }

        [Then(@"Tabs About You, About Your Agency and Marketing & Renting approch is displayed")]
        public void ThenTabsAboutYouAboutYourAgencyAndMarketingRentingApprochIsDisplayed()
        {
            BasePage.AgentProposalForRentFunnel.RentalAgentBiography.ShouldVerifyThatTabsForEnteringBiographyShouldBeDisplayed();
        }

    }
}
