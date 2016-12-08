using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForSell.Slides
{
    public class SalesTeamSelection
    {
        private readonly TestObject _salesTeamSlide;
        private readonly TestObject _next;
        private readonly TestObject _back;
        private readonly TestObject _forward;
        private readonly TestObject _salesTeamSize;
        private readonly TestObject _salesTeamSizeQ;

        public SalesTeamSelection(Browser browser, TestObjectProperties eltSalesTeamSlide, TestObjectProperties btnNext,
            TestObjectProperties lnkBack, TestObjectProperties lnkForward, TestObjectProperties ddSalesTeamSize, TestObjectProperties eltSalesTeamSizeQ)
        {
            _next = new TestObject(browser, btnNext);
            _back = new TestObject(browser, lnkBack);
            _forward = new TestObject(browser, lnkForward);
            _salesTeamSize = new TestObject(browser, ddSalesTeamSize);
            _salesTeamSlide = new TestObject(browser, eltSalesTeamSlide);
            _salesTeamSizeQ = new TestObject(browser, eltSalesTeamSizeQ);
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string questionString)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = questionString;
            info.Actual = GetQuestionText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        private string GetQuestionText()
        {
            return _salesTeamSizeQ.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _salesTeamSlide.VerifyDisplayStyleWith("block");
        }

        public void SetSaleTeamSizeAs(string size)
        {
            _salesTeamSize.SendKeys(size);
            ClickNext();
        }

        public void ClickNext()
        {
            _next.Click();
        }
    }
}
