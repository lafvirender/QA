using LAFTestAutomationFramework.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForRent.Slides
{
    public class InspectionFrequency
    {
        private readonly TestObject _inspectionFreqSlide;
        private readonly TestObject _inspectionFreqQ;
        private readonly TestObject _inspectionFreqPeriod;
        private readonly TestObject _next;

        private readonly TestObject _back;
        private readonly TestObject _forward;

        public InspectionFrequency(Browser browser, TestObjectProperties eltInspectionFreqSlide,
            TestObjectProperties eltInspectionFreqQ, TestObjectProperties lstInspectionFreqPeriod,
            TestObjectProperties btnNext, TestObjectProperties lnkForward, TestObjectProperties lnkBack)
        {
            _inspectionFreqSlide = new TestObject(browser, eltInspectionFreqSlide);
            _inspectionFreqQ = new TestObject(browser, eltInspectionFreqQ);
            _inspectionFreqPeriod = new TestObject(browser, lstInspectionFreqPeriod);
            _next = new TestObject(browser, btnNext);

            _back = new TestObject(browser, lnkBack);
            _forward = new TestObject(browser, lnkForward);
        }

        public void ClickForwardLink()
        {
            _forward.Click();
        }

        public void GoBackToLandlordInsuranceQ()
        {
            _back.Click();
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
            return _inspectionFreqQ.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _inspectionFreqSlide.VerifyDisplayStyleWith("block");
        }

        public void SetInspectionFrequencyPeriodAs(string size)
        {
            _inspectionFreqPeriod.Select(size);
            ClickNext();
        }

        public void ClickNext()
        {
            _next.Click();
        }

        public VerificationInfo ShouldDisplayTheInspectionFreqDropDownValuesAs(IList<string> values)
        {
            IList<string> valuesDisplayedOnPage = _inspectionFreqPeriod.GetAllOptionsText();
           

            VerificationInfo info = new VerificationInfo();
            info.Expected = string.Join(",", values.ToArray());
            info.Actual = string.Join(",", valuesDisplayedOnPage.ToArray());
            if (values.All(value => valuesDisplayedOnPage.Contains(value.Trim())))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
