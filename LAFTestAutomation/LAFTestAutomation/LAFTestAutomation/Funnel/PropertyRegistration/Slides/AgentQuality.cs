using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class AgentQuality
    {
        private readonly TestObject _agentQualitySlide;
        private readonly TestObject _abilityToGetBestOutcome;
        private readonly TestObject _localKnowledegeAndExpertise;
        private readonly TestObject _trustworthinessAndReliability;
        private readonly TestObject _patienceAndUnderstanding;
        private readonly TestObject _back;
        private readonly TestObject _forward;


        public AgentQuality(Browser browser, TestObjectProperties eltAgentQualitySSlide,
                        TestObjectProperties lnkAbilityToGetBestOutcome, TestObjectProperties lnkLocalKnowledegeAndExpertise,
                        TestObjectProperties lnkTrustworthinessAndReliability, TestObjectProperties lnkPatienceAndUnderstanding,
                        TestObjectProperties lnkBack, TestObjectProperties lnkForward)
        {
            _agentQualitySlide = new TestObject(browser, eltAgentQualitySSlide);
            _abilityToGetBestOutcome = new TestObject(browser, lnkAbilityToGetBestOutcome);
            _localKnowledegeAndExpertise = new TestObject(browser, lnkLocalKnowledegeAndExpertise);
            _trustworthinessAndReliability = new TestObject(browser, lnkTrustworthinessAndReliability);
            _patienceAndUnderstanding = new TestObject(browser, lnkPatienceAndUnderstanding);
            _back = new TestObject(browser, lnkBack);
            _forward = new TestObject(browser, lnkForward);
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_agentQualitySlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfAbilityToGetBestOutcomeOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _abilityToGetBestOutcome.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLocalKnowledegeAndExpertiseOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _localKnowledegeAndExpertise.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfTrustworthinessAndReliabilityOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _trustworthinessAndReliability.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfPatienceAndUnderstandingOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _patienceAndUnderstanding.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void MoveBackToPropertyDescription()
        {
            _back.Click();
        }

        public void SelectAgentQualityAs(string quality)
        {
            if (string.IsNullOrEmpty(quality)) return;
            var option = (AgentQualityEnum)Enum.Parse(typeof(AgentQualityEnum), quality);
            switch (option)
            {
                case AgentQualityEnum.AbilityToGetBestOutcome:
                    SelectAbilityToGetBestOutcome();
                    break;

                case AgentQualityEnum.LocalKnowledegeAndExpertise:
                    SelectLocalKnowledegeAndExpertise();
                    break;

                case AgentQualityEnum.PatienceAndUnderstanding:
                    SelectPatienceAndUnderstanding();
                    break;

                case AgentQualityEnum.TrustworthinessAndReliability:
                    SelectTrustworthinessAndReliability();
                    break;

                default:
                    return;
            }
        }

        private void SelectAbilityToGetBestOutcome()
        {
            _abilityToGetBestOutcome.WaitForSlideOptionToBecomeActive();
            _abilityToGetBestOutcome.Click();
        }

        private void SelectLocalKnowledegeAndExpertise()
        {
            _localKnowledegeAndExpertise.WaitForSlideOptionToBecomeActive();
            _localKnowledegeAndExpertise.Click();

        }
        private void SelectTrustworthinessAndReliability()
        {
            _trustworthinessAndReliability.WaitForSlideOptionToBecomeActive();
            _trustworthinessAndReliability.Click();
        }
        private void SelectPatienceAndUnderstanding()
        {
            _patienceAndUnderstanding.WaitForSlideOptionToBecomeActive();
            _patienceAndUnderstanding.Click();
        }

        public VerificationInfo ShouldVerifyAbilityToGetBestOutcomeOptionTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _abilityToGetBestOutcome.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }


        public VerificationInfo ShouldVerifyLocalKnowledegeAndExpertiseOptionTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _localKnowledegeAndExpertise.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTrustworthinessAndReliabilityOptionTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _trustworthinessAndReliability.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyPatienceAndUnderstandingOptionTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _patienceAndUnderstanding.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void MoveForwardToSpecificAgenciesSelection()
        {
            _abilityToGetBestOutcome.IsEnabled();
            _forward.Click();
        }
    }
}
