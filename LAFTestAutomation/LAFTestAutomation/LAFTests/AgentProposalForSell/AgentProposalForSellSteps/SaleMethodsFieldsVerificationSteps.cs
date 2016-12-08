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
    public class SaleMethodsFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public SaleMethodsFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("SaleMethodsFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigates to Sale Methods selection after registering Agent with details")]
        public void GivenUserNavigatesToSaleMethodsSelectionAfterRegisteringAgentWithDetails(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToSaleMethodsPage();
        }

        [Given(@"User is on Agent_Reg Page")]
        public void GivenUserIsOnAgent_RegPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [When(@"I Click on Next")]
        public void WhenIClickOnNext()
        {
            BasePage.AgentProposalForSellFunnel.SalesMethods.ClickNext();
        }


        [Given(@"User navigates to Sale_Methods selection after registering Agent with details")]
        public void GivenUserNavigatesToSale_MethodsSelectionAfterRegisteringAgentWithDetails(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToSalesMethodsSelectionAfterEnteringDetailsAs();
        }


        [Then(@"Question ""(.*)"" is displayed for Sales Methods selection")]
        public void ThenQuestionIsDisplayedForSalesMethodsSelection(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Method Private Sale with text ""(.*)"" should be available on Registration Page")]
        public void ThenMethodPrivateSaleWithTextShouldBeAvailableOnRegistrationPage(string text)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.ShouldVerifyOptionPrivateSaleTextWith(text));
        }

        [Then(@"Method auctions with text ""(.*)"" should be available on Registration Page")]
        public void ThenMethodAuctionsWithTextShouldBeAvailableOnRegistrationPage(string text)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.ShouldVerifyOptionAuctionsTextWith(text));
        }

        [Then(@"Method off market with text ""(.*)"" should be available on Registration Page")]
        public void ThenMethodOffMarketWithTextShouldBeAvailableOnRegistrationPage(string text)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.ShouldVerifyOptionOffMarketTextWith(text));
        }

        [Then(@"Method Fixed Date with text ""(.*)"" should be available on Registration Page")]
        public void ThenMethodFixedDateWithTextShouldBeAvailableOnRegistrationPage(string text)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.ShouldVerifyOptionFixedDateTextWith(text));
        }

        [When(@"I Select method as")]
        public void WhenISelectMethodAs(Table table)
        {
            var vendorProposalFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.SalesMethods.SelectSaleMethodsAs(vendorProposalFields.SaleMethods);
        }

        [Then(@"Languages selection question is displayed")]
        public void ThenLanguagesSelectionQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.IsDisplayed());
        }

        [When(@"I move back to Sale Method Selection from Language selection")]
        public void WhenIMoveBackToSaleMethodSelectionFromLanguageSelection()
        {
            BasePage.AgentProposalForSellFunnel.SalesMethods.GoBackToLanguageSelection();
        }

        [Then(@"Link for moving forward is enabled")]
        public void ThenLinkForMovingForwardIsEnabled()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.IsForwardLinkEnabled());
        }

        [When(@"I Click on Forward link")]
        public void WhenIClickOnForwardLink()
        {
            BasePage.AgentProposalForSellFunnel.SalesMethods.ClickForwardLink();
        }

        [Then(@"Language selection question is displayed")]
        public void ThenLanguageSelectionQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.IsDisplayed());
        }

        [Then(@"Color of the Private Sale option should be ""(.*)""")]
        public void ThenColorOfThePrivateSaleOptionShouldBe(string expColor)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.ShouldVerifyTheColorOfPrivateSaleOptionWith(expColor));
        }

        [Then(@"Color of the Auctions option should be ""(.*)""")]
        public void ThenColorOfTheAuctionsOptionShouldBe(string expColor)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.ShouldVerifyTheColorOfAuctionsOptionWith(expColor));
        }

        [Then(@"Color of the Off Market option should be ""(.*)""")]
        public void ThenColorOfTheOffMarketOptionShouldBe(string expColor)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.ShouldVerifyTheColorOfOffMarketOptionWith(expColor));
        }

        [Then(@"Color of the Fixed Date option should be ""(.*)""")]
        public void ThenColorOfTheFixedDateOptionShouldBe(string expColor)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SalesMethods.ShouldVerifyTheColorOfFixedOptionWith(expColor));
        }

        [Then(@"Links for Moving Forward should be disabled")]
        public void ThenLinksForMovingForwardShouldBeDisabled()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.IsForwardLinkDisabled());
        }

        [Then(@"Label ""(.*)"" should be displayed for Sales Methods Selection progress")]
        public void ThenLabelShouldBeDisplayedForSalesMethodsSelectionProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyTheLabelOfSalesMethodsSelectionProgressBarWith(label));
        }

        [Then(@"METHODS circle should be displayed as active")]
        public void ThenMETHODSCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatSalesMethodsIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Languages Selection progress")]
        public void ThenLabelShouldBeDisplayedForLanguagesSelectionProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyTheLabelOfLanguagesSelectionProgressBarWith(label));
        }

        [Then(@"Languages circle should be displayed as inactive")]
        public void ThenLanguagesCircleShouldBeDisplayedAsInactive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatLanguagesIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Sale Authority Selection progress")]
        public void ThenLabelShouldBeDisplayedForSaleAuthoritySelectionProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyTheLabelOfSaleAuthSelectionProgressBarWith(label));
        }

        [Then(@"Sale Authority circle should be displayed as inactive")]
        public void ThenSaleAuthorityCircleShouldBeDisplayedAsInactive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatSaleAuthIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Sale Team Selection progress")]
        public void ThenLabelShouldBeDisplayedForSaleTeamSelectionProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyTheLabelOfSaleTeamSelectionProgressBarWith(label));
        }

        [Then(@"Team Size circle should be displayed as inactive")]
        public void ThenTeamSizeCircleShouldBeDisplayedAsInactive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatSaleTeamIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for PostCodes Selection progress")]
        public void ThenLabelShouldBeDisplayedForPostCodesSelectionProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyTheLabelOfPostCodesSelectionProgressBarWith(label));
        }

        [Then(@"PostCodes circle should be displayed as inactive")]
        public void ThenPostCodesCircleShouldBeDisplayedAsInactive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatPostCodesIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Biography Details Entry progress")]
        public void ThenLabelShouldBeDisplayedForBiographyDetailsEntryProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyTheLabelOfBiographySelectionProgressBarWith(label));
        }

        [Then(@"BIOGRAPHY circle should be displayed as inactive")]
        public void ThenBIOGRAPHYCircleShouldBeDisplayedAsInactive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatBiographyIsActiveInProgressBar());
        }

        [Then(@"Label ""(.*)"" should be displayed for Fees Details Entry progress")]
        public void ThenLabelShouldBeDisplayedForFeesDetailsEntryProgress(string label)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyTheLabelOfFeesSelectionProgressBarWith(label));
        }

        [Then(@"Fees circle should be displayed as inactive")]
        public void ThenFeesCircleShouldBeDisplayedAsInactive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatFeesIsActiveInProgressBar());
        }

        [Then(@"Methods circle should be displayed as Checked")]
        public void ThenMethodsCircleShouldBeDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatSalesMethodsCircleIsChecked());
        }

    }
}
