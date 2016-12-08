using LAFTestAutomationFramework.Helpers;


namespace LAFTestAutomationFramework.Funnel.AgentProposalForRent.Slides
{
    public class RentalProposalConfirmation
    {

        private readonly TestObject _confirmationMessage;
        private readonly TestObject _goToYourPortal;
        private readonly TestObject _agentDashboardWelcomeMsg;

        public RentalProposalConfirmation(Browser browser, TestObjectProperties eltConfirmationMessage,
                                           TestObjectProperties btnGoToYourPortal, TestObjectProperties eltAgentDashboardWelcomeMsg)
        {
            _confirmationMessage = new TestObject(browser, eltConfirmationMessage);
            _goToYourPortal = new TestObject(browser, btnGoToYourPortal);
            _agentDashboardWelcomeMsg = new TestObject(browser, eltAgentDashboardWelcomeMsg);
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "Your proposal is complete!";
            info.Actual = _confirmationMessage.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatAgentDashboardIsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "Welcome to your dashboard.";
            if (_agentDashboardWelcomeMsg.IsDisplayed())
            {
                info.Actual = _agentDashboardWelcomeMsg.GetText();
                if (_agentDashboardWelcomeMsg.GetText() == "Welcome to your dashboard.")
                    info.Result = true;
                else
                    info.Result = false;
            }
            else
                info.Result = false;
            return info;
        }

        public void ClickGotoYourPortal()
        {
            _goToYourPortal.Click();
        }
    }
}
