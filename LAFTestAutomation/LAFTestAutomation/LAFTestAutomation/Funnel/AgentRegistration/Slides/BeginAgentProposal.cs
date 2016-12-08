using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration.Slides
{
    public class BeginAgentProposal
    {
        private readonly TestObject _begin;
        private readonly TestObject _beginProposalHeading;

        public BeginAgentProposal(Browser browser, TestObjectProperties btnBegin,
                                   TestObjectProperties EltBeginProposalHeading)
        {
            _begin = new TestObject(browser, btnBegin);
            _beginProposalHeading = new TestObject(browser, EltBeginProposalHeading);
        }

        public void SelectBegin()
        {
            _begin.Click();
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = GetQuestionText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private string GetQuestionText()
        {
            return _beginProposalHeading.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_begin.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
