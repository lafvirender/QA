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
    public class LanguagesFieldsVerificationSteps: TestInitialization
    {
        Reporter Reporter;
        public LanguagesFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("LanguagesFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User is on Agent_Registration_Page")]
        public void GivenUserIsOnAgent_Registration_Page()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to Begin_Proposal after registering agent with details")]
        public void GivenUserNavigatesToBegin_ProposalAfterRegisteringAgentWithDetails(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Language Selection after selecting sales methods as")]
        public void WhenUserNavigatesToLanguageSelectionAfterSelectingSalesMethodsAs(Table table)
        {
            var vendorPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.ShouldNavigateToLanguageSelectionAfterEnteringDetailsAs(vendorPropFields);
        }

        [Then(@"Link for Moving Forward is displayed as enabled")]
        public void ThenLinkForMovingForwardIsDisplayedAsEnabled()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.IsForwardLinkEnabled());
        }


        [When(@"User clicks Next after selecting Languages as")]
        public void WhenUserClicksNextAfterSelectingLanguagesAs(Table table)
        {
            var vendPropFields = table.CreateInstance<VendorProposalFields>();
            BasePage.AgentProposalForSellFunnel.Languages.SelectLanguagesAs(vendPropFields.Languages);
            BasePage.AgentProposalForSellFunnel.Languages.ClickNext();
        }

        [Then(@"Question ""(.*)"" is displayed for Language selection")]
        public void ThenQuestionIsDisplayedForLanguageSelection(string qText)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Sale Autority Size question is displayed")]
        public void ThenSaleAutoritySizeQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.SaleAuthority.IsDisplayed());
        }

        [When(@"I move back to Languages Selection from Sale Authority Size section")]
        public void WhenIMoveBackToLanguagesSelectionFromSaleAuthoritySizeSection()
        {
            BasePage.AgentProposalForSellFunnel.SaleAuthority.MoveBackToLanguages();
        }

        [Then(@"Moving forward link is enabled")]
        public void ThenMovingForwardLinkIsEnabled()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.IsForwardLinkEnabled());
        }

        [When(@"I Click on link to move forward")]
        public void WhenIClickOnLinkToMoveForward()
        {
            BasePage.AgentProposalForSellFunnel.ClickForward();
        }

        [Then(@"Color of the Arabic option should be ""(.*)""")]
        public void ThenColorOfTheArabicOptionShouldBe(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionArabicWith(color));
        }

        [Then(@"Color of the Cantonese option should be ""(.*)""")]
        public void ThenColorOfTheCantoneseOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionCantoneseWith(color));
        }

        [Then(@"Color of the Croatian option should be ""(.*)""")]
        public void ThenColorOfTheCroatianOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionCroatianWith(color));
        }

        [Then(@"Color of the Dutch option should be ""(.*)""")]
        public void ThenColorOfTheDutchOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionDutchWith(color));
        }

        [Then(@"Color of the French option should be ""(.*)""")]
        public void ThenColorOfTheFrenchOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionFrenchWith(color));
        }

        [Then(@"Color of the Greek option should be ""(.*)""")]
        public void ThenColorOfTheGreekOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionGreekWith(color));
        }

        [Then(@"Color of the Hebrew option should be ""(.*)""")]
        public void ThenColorOfTheHebrewOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionHebrewWith(color));
        }

        [Then(@"Color of the Hindi option should be ""(.*)""")]
        public void ThenColorOfTheHindiOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionHindiWith(color));
        }

        [Then(@"Color of the Hungarian option should be ""(.*)""")]
        public void ThenColorOfTheHungarianOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionHungarianWith(color));
        }

        [Then(@"Color of the Indonesian option should be ""(.*)""")]
        public void ThenColorOfTheIndonesianOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionIndonesianWith(color));
        }

        [Then(@"Color of the English option should be ""(.*)""")]
        public void ThenColorOfTheEnglishOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionEnglishWith(color));
        }

        [Then(@"Color of the Italian option should be ""(.*)""")]
        public void ThenColorOfTheItalianOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionItalianWith(color));
        }

        [Then(@"Color of the Japanese option should be ""(.*)""")]
        public void ThenColorOfTheJapaneseOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionJapaneseWith(color));
        }

        [Then(@"Color of the Korean option should be ""(.*)""")]
        public void ThenColorOfTheKoreanOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionKoreanWith(color));
        }

        [Then(@"Color of the Lebanese option should be ""(.*)""")]
        public void ThenColorOfTheLebaneseOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionLebaneseWith(color));
        }

        [Then(@"Color of the Macedonian option should be ""(.*)""")]
        public void ThenColorOfTheMacedonianOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionMacedonianWith(color));
        }

        [Then(@"Color of the Maltese option should be ""(.*)""")]
        public void ThenColorOfTheMalteseOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionMalteseWith(color));
        }

        [Then(@"Color of the Mandarin option should be ""(.*)""")]
        public void ThenColorOfTheMandarinOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionMandarinWith(color));
        }

        [Then(@"Color of the Persian option should be ""(.*)""")]
        public void ThenColorOfThePersianOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionPersianWith(color));
        }

        [Then(@"Color of the Polish option should be ""(.*)""")]
        public void ThenColorOfThePolishOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionPolishWith(color));
        }

        [Then(@"Color of the Portuguese option should be ""(.*)""")]
        public void ThenColorOfThePortugueseOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionPortugueseWith(color));
        }

        [Then(@"Color of the Russian option should be ""(.*)""")]
        public void ThenColorOfTheRussianOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionRussianWith(color));
        }

        [Then(@"Color of the Serbian option should be ""(.*)""")]
        public void ThenColorOfTheSerbianOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionSerbianWith(color));
        }

        [Then(@"Color of the Spanish option should be ""(.*)""")]
        public void ThenColorOfTheSpanishOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionSpanishWith(color));
        }

        [Then(@"Color of the Srilankan option should be ""(.*)""")]
        public void ThenColorOfTheSrilankanOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionSrilankanWith(color));
        }

        [Then(@"Color of the Tagalog option should be ""(.*)""")]
        public void ThenColorOfTheTagalogOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionTagalogWith(color));
        }

        [Then(@"Color of the Thai option should be ""(.*)""")]
        public void ThenColorOfTheThaiOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionThaiWith(color));
        }

        [Then(@"Color of the Turkish option should be ""(.*)""")]
        public void ThenColorOfTheTurkishOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionTurkishWith(color));
        }

        [Then(@"Color of the Vietnamese option should be ""(.*)""")]
        public void ThenColorOfTheVietnameseOptionShouldBe(string color)
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionVietnameseWith(color));
        }

        [Then(@"Languages circle should be displayed as active")]
        public void ThenLanguagesCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatLanguagesIsActiveInProgressBar());
        }

        [Then(@"Languages circle should be displayed as Checked")]
        public void ThenLanguagesCircleShouldBeDisplayedAsChecked()
        {
             Reporter.ReportResult(BasePage.AgentProposalForSellFunnel.ShouldVerifyThatLanguagesCircleIsChecked());
        }

    }
}
