using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.AgentRegSteps
{
    [Binding]
    public class AgentInterestsFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public AgentInterestsFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("AgentInterestsFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }


        [Given(@"User is on Agent SignUp Page")]
        public void GivenUserIsOnAgentSignUpPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to Interests Selection")]
        public void GivenUserNavigatesToInterestsSelection()
        {
            BasePage.AgentRegistrationFunnel.ShouldNavigateToAgentInterestsSection();
        }

        [Then(@"Question ""(.*)"" should be displayed for Interests Selection")]
        public void ThenQuestionShouldBeDisplayedForInterestsSelection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentInterests.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Category Sales with text ""(.*)"" should be available on Interests Selection")]
        public void ThenCategorySalesWithTextShouldBeAvailableOnInterestsSelection(string catText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentInterests.ShouldVerifyPropertyCategorySalesTextWith(catText));
        }

        [Then(@"Category Rentals with text ""(.*)"" should be available on Interests Selection")]
        public void ThenCategoryRentalsWithTextShouldBeAvailableOnInterestsSelection(string catText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentInterests.ShouldVerifyPropertyCategoryRentalsTextWith(catText));
        }


        [Then(@"Category Both with text ""(.*)"" should be available on Interests Selection")]
        public void ThenCategoryBothWithTextShouldBeAvailableOnInterestsSelection(string catText)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentInterests.ShouldVerifyPropertyCategoryBothTextWith(catText));
        }

        [Then(@"About You Progress Circle should be displayed as not filled")]
        public void ThenAboutYouProgressCircleShouldBeDisplayedAsNotFilled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatAboutYouCircleIsFilledInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for User Details filling progress")]
        public void ThenLabelShouldBeDisplayedForUserDetailsFillingProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyTheLabelOfAgentPersonalDetailsTrackingInProgressBarWith(label));
        }

        [Then(@"No progress should be displayed for Agency by default")]
        public void ThenNoProgressShouldBeDisplayedForAgencyByDefault()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatAgencyIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Agency Details filling progress")]
        public void ThenLabelShouldBeDisplayedForAgencyDetailsFillingProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyTheLabelOfAgencyDetailsTrackingInProgressBarWith(label));
        }

        [Then(@"No progress should be displayed for Key Info by default")]
        public void ThenNoProgressShouldBeDisplayedForKeyInfoByDefault()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatKeyInfoIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for key information filling progress")]
        public void ThenLabelShouldBeDisplayedForKeyInformationFillingProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyTheLabelOfKeyInfoTrackingInProgressBarWith(label));
        }

        [Then(@"No progress should be displayed for Terms and Conditions by default")]
        public void ThenNoProgressShouldBeDisplayedForTermsAndConditionsByDefault()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatTermsAndCondIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Terms and Conditions filling progress")]
        public void ThenLabelShouldBeDisplayedForTermsAndConditionsFillingProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyTheLabelOfTermsAndCondTrackingInProgressBarWith(label));
        }

        [Given(@"User navigates to Basic Details Entry after selecting option")]
        public void GivenUserNavigatesToBasicDetailsEntryAfterSelectingOption(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToAgentPersonalDetailsSectionAfterEnteringDetailsAs(agentRegFields);
        }

        [Then(@"Basic Details Entry question should be displayed")]
        public void ThenBasicDetailsEntryQuestionShouldBeDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentDetails.IsDisplayed());
        }

        [Given(@"I move back to Interest Selection")]
        public void GivenIMoveBackToInterestSelection()
        {
            BasePage.AgentRegistrationFunnel.AgentDetails.MoveBackToAgentInterestSection();
        }

        [Then(@"Forward link is enabled")]
        public void ThenForwardLinkIsEnabled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Given(@"User move back to Interest Selection")]
        public void GivenUserMoveBackToInterestSelection()
        {
            BasePage.AgentRegistrationFunnel.AgentDetails.MoveBackToAgentInterestSection();
        }

        [When(@"User click Forward Link")]
        public void WhenUserClickForwardLink()
        {
            BasePage.AgentRegistrationFunnel.AgentInterests.MoveForwardToAgentDetails();
        }

        [Then(@"Color of the Sales option on Interest Selection should be ""(.*)""")]
        public void ThenColorOfTheSalesOptionOnInterestSelectionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentInterests.ShouldVerifyTheColorOfSalesOptionWith(expectedColorHexValue));
        }


        [Then(@"Color of the Rent option on Interest Selection should be ""(.*)""")]
        public void ThenColorOfTheRentOptionOnInterestSelectionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentInterests.ShouldVerifyTheColorOfRentalsOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the Both option on Interest Selection should be ""(.*)""")]
        public void ThenColorOfTheBothOptionOnInterestSelectionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.AgentInterests.ShouldVerifyTheColorOfBothOptionWith(expectedColorHexValue));
        }

        [Then(@"Forward link should be disabled")]
        public void ThenForwardLinkShouldBeDisabled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Link for moving Back should be enabled")]
        public void ThenLinkForMovingBackShouldBeEnabled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.IsBackLinkDisabled());
        }

        [Then(@"About You Progress Circle should be displayed as filled")]
        public void ThenAboutYouProgressCircleShouldBeDisplayedAsFilled()
        {
            Reporter.ReportResult(BasePage.AgentRegistrationFunnel.ShouldVerifyThatAboutYouCircleIsFilledInProgressBar());
        }

    }
}
