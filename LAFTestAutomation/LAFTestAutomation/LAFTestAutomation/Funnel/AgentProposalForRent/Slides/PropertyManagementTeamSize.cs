using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForRent.Slides
{
    public class PropertyManagementTeamSize
    {
        private readonly TestObject _propManagementTeamSlide;
        private readonly TestObject _propertyMgmtTeamSizeQ;
        private readonly TestObject _propMgmtTeamSize;
        private readonly TestObject _next;
        private readonly TestObject _errors;


        public PropertyManagementTeamSize(Browser browser, TestObjectProperties eltPropertyManagmentTeamSizeSlide,
            TestObjectProperties eltPropertyMgmtTeamSizeQuestion, TestObjectProperties txtPropMgmtTeamSize,
            TestObjectProperties btnNext, TestObjectProperties EltErrors)
        {
            _propManagementTeamSlide = new TestObject(browser, eltPropertyManagmentTeamSizeSlide);
            _propertyMgmtTeamSizeQ = new TestObject(browser, eltPropertyMgmtTeamSizeQuestion);
            _propMgmtTeamSize = new TestObject(browser, txtPropMgmtTeamSize);
            _next = new TestObject(browser, btnNext);
            _errors = new TestObject(browser, EltErrors);
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
            return _propertyMgmtTeamSizeQ.GetText();
        }

        public bool ShouldVerifyThatErrorIsDisplayed(string errText)
        {
            return _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText);
        }

        public VerificationInfo IsDisplayed()
        {
            return _propManagementTeamSlide.VerifyDisplayStyleWith("block");
        }

        public void SetPropMgmtTeamSizeAs(string size)
        {
            _propMgmtTeamSize.SendKeys(size);
            ClickNext();
        }

        public void ClickNext()
        {
            _next.Click();
        }
    }
}
