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
    public class LanguagesRentalPropFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public LanguagesRentalPropFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("LanguagesRentalPropFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"User navigate to Agent_Registration Page")]
        public void GivenUserNavigateToAgent_RegistrationPage()
        {
            BasePage.ShouldTakeMeToAgentRegistrationFunnelStartSlide();
        }

        [Given(@"User navigates to Beg_Proposal after registering agent with details")]
        public void GivenUserNavigatesToBeg_ProposalAfterRegisteringAgentWithDetails(Table table)
        {
            var agentRegFields = table.CreateInstance<AgentRegistrationFields>();
            BasePage.AgentRegistrationFunnel.ShouldNavigateToBeginProposalAfterEnteringDetailsAs(agentRegFields);
        }

        [When(@"User navigates to Language Selection after entering details as")]
        public void WhenUserNavigatesToLanguageSelectionAfterEnteringDetailsAs(Table table)
        {
            var landlordPropFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.ShouldNavigateToLanguageSelectionPageAfterEnteringDetailsAs(landlordPropFields);
        }

        [Then(@"Question ""(.*)"" is displayed for Language selection page")]
        public void ThenQuestionIsDisplayedForLanguageSelectionPage(string qText)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Links for navigating Forward and Backward are disabled")]
        public void ThenLinksForNavigatingForwardAndBackwardAreDisabled()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I Click on forward")]
        public void WhenIClickOnForward()
        {
            BasePage.AgentProposalForRentFunnel.ClickForward();
        }


        [When(@"User clicks on Next after selecting Languages as")]
        public void WhenUserClicksOnNextAfterSelectingLanguagesAs(Table table)
        {
            var landlordPropFields = table.CreateInstance<LandlordProposalFields>();
            BasePage.AgentProposalForRentFunnel.Languages.SelectLanguagesAs(landlordPropFields.Languages);
        }

        [Then(@"Emergency Contact question is displayed")]
        public void ThenEmergencyContactQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.EmergencyContact.IsDisplayed());
        }

        [When(@"I move back to Languages Selection")]
        public void WhenIMoveBackToLanguagesSelection()
        {
            BasePage.AgentProposalForRentFunnel.EmergencyContact.MoveBackToLanguages();
        }

        [Then(@"Forward link is displayed enabled")]
        public void ThenForwardLinkIsDisplayedEnabled()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.IsForwardLinkEnabled());
        }


        [Then(@"Color of the French option is ""(.*)""")]
        public void ThenColorOfTheFrenchOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionFrenchWith(color));
        }

        [Then(@"Color of the Hebrew option is ""(.*)""")]
        public void ThenColorOfTheHebrewOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionHebrewWith(color));
        }

        [Then(@"Color of the Hindi option is ""(.*)""")]
        public void ThenColorOfTheHindiOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionHindiWith(color));
        }

        [Then(@"Color of the Indonesian option is ""(.*)""")]
        public void ThenColorOfTheIndonesianOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionIndonesianWith(color));
        }

        [Then(@"Color of the English option is ""(.*)""")]
        public void ThenColorOfTheEnglishOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionEnglishWith(color));
        }

        [Then(@"Color of the Italian option is ""(.*)""")]
        public void ThenColorOfTheItalianOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionItalianWith(color));
        }

        [Then(@"Color of the Japanese option is ""(.*)""")]
        public void ThenColorOfTheJapaneseOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionJapaneseWith(color));
        }

        [Then(@"Color of the Korean option is ""(.*)""")]
        public void ThenColorOfTheKoreanOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionKoreanWith(color));
        }

        [Then(@"Color of the Lebanese option is ""(.*)""")]
        public void ThenColorOfTheLebaneseOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionLebaneseWith(color));
        }

        [Then(@"Color of the Macedonian option is ""(.*)""")]
        public void ThenColorOfTheMacedonianOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionMacedonianWith(color));
        }

        [Then(@"Color of the Maltese option is ""(.*)""")]
        public void ThenColorOfTheMalteseOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionMalteseWith(color));
        }

        [Then(@"Color of the Mandarin option is ""(.*)""")]
        public void ThenColorOfTheMandarinOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionMandarinWith(color));
        }

        [Then(@"Color of the Persian option is ""(.*)""")]
        public void ThenColorOfThePersianOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionPersianWith(color));
        }

        [Then(@"Color of the Polish option is ""(.*)""")]
        public void ThenColorOfThePolishOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionPolishWith(color));
        }

        [Then(@"Color of the Portuguese option is ""(.*)""")]
        public void ThenColorOfThePortugueseOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionPortugueseWith(color));
        }

        [Then(@"Color of the Russian option is ""(.*)""")]
        public void ThenColorOfTheRussianOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionRussianWith(color));
        }

        [Then(@"Color of the Serbian option is ""(.*)""")]
        public void ThenColorOfTheSerbianOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionSerbianWith(color));
        }

        [Then(@"Color of the Spanish option is ""(.*)""")]
        public void ThenColorOfTheSpanishOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionSpanishWith(color));
        }

        [Then(@"Color of the Srilankan option is ""(.*)""")]
        public void ThenColorOfTheSrilankanOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionSrilankanWith(color));
        }

        [Then(@"Color of the Tagalog option is ""(.*)""")]
        public void ThenColorOfTheTagalogOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionTagalogWith(color));
        }

        [Then(@"Color of the Thai option is ""(.*)""")]
        public void ThenColorOfTheThaiOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionThaiWith(color));
        }

        [Then(@"Color of the Turkish option is ""(.*)""")]
        public void ThenColorOfTheTurkishOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionTurkishWith(color));
        }

        [Then(@"Color of the Vietnamese option is ""(.*)""")]
        public void ThenColorOfTheVietnameseOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionVietnameseWith(color));
        }

        [Then(@"Color of the Arabic option is ""(.*)""")]
        public void ThenColorOfTheArabicOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionArabicWith(color));
        }

        [Then(@"Color of the Cantonese option is ""(.*)""")]
        public void ThenColorOfTheCantoneseOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionCantoneseWith(color));
        }

        [Then(@"Color of the Croatian option is ""(.*)""")]
        public void ThenColorOfTheCroatianOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionCroatianWith(color));
        }

        [Then(@"Color of the Dutch option is ""(.*)""")]
        public void ThenColorOfTheDutchOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionDutchWith(color));
        }

        [Then(@"Color of the Greek option is ""(.*)""")]
        public void ThenColorOfTheGreekOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionGreekWith(color));
        }

        [Then(@"Color of the Hungarian option is ""(.*)""")]
        public void ThenColorOfTheHungarianOptionIs(string color)
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.Languages.ShouldVerifyTheColorOfLanguageOptionHungarianWith(color));
        }

        [Then(@"Languages circle should be displayed as Active")]
        public void ThenLanguagesCircleShouldBeDisplayedAsActive()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatLanguagesIsActiveInProgressBar());
        }

        [Then(@"Languages circle is displayed as Checked")]
        public void ThenLanguagesCircleIsDisplayedAsChecked()
        {
            Reporter.ReportResult(BasePage.AgentProposalForRentFunnel.ShouldVerifyThatLanguagesCircleIsChecked());
        }

    }
}
