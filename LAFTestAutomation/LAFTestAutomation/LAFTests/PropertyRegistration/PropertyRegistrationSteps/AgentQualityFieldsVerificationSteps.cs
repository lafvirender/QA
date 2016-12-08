using System;
using TechTalk.SpecFlow;
using LAFTestAutomationFramework.Pages;
using System.Configuration;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using LAFTestAutomationFramework.Reporting;

namespace LAFTests.PropertyRegistration.PropertyRegistrationSteps
{
    [Binding]
    public class AgentQualityFieldsVerificationSteps : TestInitialization
    {
        Reporter Reporter;
        public AgentQualityFieldsVerificationSteps(BasePage basePage) :
            base(basePage, ConfigurationManager.AppSettings.Get("AgentQualityFieldsVerificationSteps"))
        {
            Reporter = new Reporter(TestContext.CurrentContext.Test.Name);
        }

        [Given(@"I am on Prop_Reg_Page")]
        public void GivenIAmOnProp_Reg_Page()
        {
            BasePage.ShouldTakeMeToPropertyRegistrationFunnelStartSlide();
        }

        [Given(@"I navigate to Agent Quality selection section after entering details")]
        public void GivenINavigateToAgentQualitySelectionSectionAfterEnteringDetails(Table table)
        {
            var propRegFields = table.CreateInstance<PropertyRegistrationFields>();
            BasePage.PropertyRegistrationFunnel.ShouldNavigateToAgentQualitySectionAfterEnteringDetailsAs(propRegFields);
        }

        [Then(@"Q ""(.*)"" should be displayed for Agent Quality selection")]
        public void ThenQShouldBeDisplayedForAgentQualitySelection(string qText)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.ShouldVerifyTheQuestionWith(qText));
        }

        [Then(@"Option Ability to get the best outcome with text ""(.*)"" should be available")]
        public void ThenOptionAbilityToGetTheBestOutcomeWithTextShouldBeAvailable(string text)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.AgentQuality.ShouldVerifyAbilityToGetBestOutcomeOptionTextWith(text));
        }

        [Then(@"Option Local knowledge and expertise with text ""(.*)"" should be available")]
        public void ThenOptionLocalKnowledgeAndExpertiseWithTextShouldBeAvailable(string text)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.AgentQuality.ShouldVerifyLocalKnowledegeAndExpertiseOptionTextWith(text));
        }

        [Then(@"Option Trustworthiness and reliability with text ""(.*)"" should be available")]
        public void ThenOptionTrustworthinessAndReliabilityWithTextShouldBeAvailable(string text)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.AgentQuality.ShouldVerifyTrustworthinessAndReliabilityOptionTextWith(text));
        }

        [Then(@"Option Patience and understanding with text ""(.*)"" should be available")]
        public void ThenOptionPatienceAndUnderstandingWithTextShouldBeAvailable(string text)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.AgentQuality.ShouldVerifyPatienceAndUnderstandingOptionTextWith(text));
        }

        [Then(@"Moving Forward Link is displayed disabled")]
        public void ThenMovingForwardLinkIsDisplayedDisabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkDisabled());
        }

        [When(@"I Select agent quality option as ""(.*)""")]
        public void WhenISelectAgentQualityOptionAs(string option)
        {
            BasePage.PropertyRegistrationFunnel.AgentQuality.SelectAgentQualityAs(option.ToString());
        }

        [Then(@"Specific Agencies question is displayed")]
        public void ThenSpecificAgenciesQuestionIsDisplayed()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.SpecificAgencies.IsDisplayed());
        }

        [Then(@"Color of the AbilityToGetBestOutcome option should be ""(.*)""")]
        public void ThenColorOfTheAbilityToGetBestOutcomeOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.AgentQuality.ShouldVerifyTheColorOfAbilityToGetBestOutcomeOptionWith(expectedColorHexValue));
        }

        [When(@"I move back to Agent Quality  Question")]
        public void WhenIMoveBackToAgentQualityQuestion()
        {
            
            BasePage.PropertyRegistrationFunnel.SpecificAgencies.MoveBackToAgentQualitySelection();
            BasePage.PropertyRegistrationFunnel.AgentQuality.IsDisplayed();
        }

        [Then(@"Color of the LocalKnowledegeAndExpertise option should be ""(.*)""")]
        public void ThenColorOfTheLocalKnowledegeAndExpertiseOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.AgentQuality.ShouldVerifyTheColorOfLocalKnowledegeAndExpertiseOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the TrustworthinessAndReliability option should be ""(.*)""")]
        public void ThenColorOfTheTrustworthinessAndReliabilityOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.AgentQuality.ShouldVerifyTheColorOfTrustworthinessAndReliabilityOptionWith(expectedColorHexValue));
        }

        [Then(@"Color of the PatienceAndUnderstanding option should be ""(.*)""")]
        public void ThenColorOfThePatienceAndUnderstandingOptionShouldBe(string expectedColorHexValue)
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.AgentQuality.ShouldVerifyTheColorOfPatienceAndUnderstandingOptionWith(expectedColorHexValue));
        }

        [Then(@"Link for Moving forward is enabled")]
        public void ThenLinkForMovingForwardIsEnabled()
        {
            Reporter.ReportResult(BasePage.PropertyRegistrationFunnel.IsForwardLinkEnabled());
        }
    
        [When(@"I click on Forward")]
        public void WhenIClickOnForward()
        {
            BasePage.PropertyRegistrationFunnel.AgentQuality.MoveForwardToSpecificAgenciesSelection();
        }

    }
}
