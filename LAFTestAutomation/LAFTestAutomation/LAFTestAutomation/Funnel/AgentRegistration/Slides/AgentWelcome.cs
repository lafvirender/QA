using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration.Slides
{
    public class AgentWelcome
    {
        private readonly TestObject _createMyProposal;
        private readonly TestObject _agentRegCompleteMessage;
        private readonly TestObject _eltAgentWelcomeTextContFirstName;

        public AgentWelcome(Browser browser, TestObjectProperties eltAgentRegCompleteMessage, 
                            TestObjectProperties btnCreateProfile, TestObjectProperties eltAgentWelcomeTextContFirstName)
        {
            _createMyProposal = new TestObject(browser, btnCreateProfile);
            _agentRegCompleteMessage = new TestObject(browser, eltAgentRegCompleteMessage);
            _eltAgentWelcomeTextContFirstName = new TestObject(browser, eltAgentWelcomeTextContFirstName);
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "Your registration is complete!";
            info.Actual = _agentRegCompleteMessage.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void SelectCreateProfile()
        {
            _createMyProposal.Click();
        }

        public VerificationInfo ShouldVerifyTheHeadingWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = GetHeadingText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private string GetHeadingText()
        {
            return _agentRegCompleteMessage.GetText();
        }

        public VerificationInfo ShouldVerifyTheTextContainingFirstName(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _eltAgentWelcomeTextContFirstName.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
