using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForRent.Slides
{
    public class PropertyPerPropertyManager
    {
        private readonly TestObject _propPerPropManagerSlide;
        private readonly TestObject _propertyPerPropManagerQ;
        private readonly TestObject _propPerPropManager;
        private readonly TestObject _next;
        private readonly TestObject _errors;


        public PropertyPerPropertyManager(Browser browser, TestObjectProperties eltPropPerPropManagerSlide,
            TestObjectProperties eltPropertyPerPropManagerQ, TestObjectProperties txtPropPerPropManager,
            TestObjectProperties btnNext, TestObjectProperties eltErrors)
        {
            _propPerPropManagerSlide = new TestObject(browser, eltPropPerPropManagerSlide);
            _propertyPerPropManagerQ = new TestObject(browser, eltPropertyPerPropManagerQ);
            _propPerPropManager = new TestObject(browser, txtPropPerPropManager);
            _next = new TestObject(browser, btnNext);
            _errors = new TestObject(browser, eltErrors);
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

        public bool ShouldVerifyThatErrorIsDisplayed(string errText)
        {
            return _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText);
        }

        private string GetQuestionText()
        {
            return _propertyPerPropManagerQ.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _propPerPropManagerSlide.VerifyDisplayStyleWith("block");
        }

        public void SetPropPerPropManagerFieldAs(string size)
        {
            _propPerPropManager.SendKeys(size);
            ClickNext();
        }

        public void ClickNext()
        {
            _next.Click();
        }
    }
}
