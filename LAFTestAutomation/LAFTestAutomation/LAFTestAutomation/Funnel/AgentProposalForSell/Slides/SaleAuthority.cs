using LAFTestAutomationFramework.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForSell.Slides
{
    public class SaleAuthority
    {
        private readonly TestObject _salesAuthSlide;
        private readonly TestObject _next;
        private readonly TestObject _salesAuthPeriod;
        private readonly TestObject _back;
        private readonly TestObject _forward;
        private readonly TestObject _standardSaleAuthQ;

        public SaleAuthority(Browser browser, TestObjectProperties eltSalesAuthSlide,
            TestObjectProperties btnNext, TestObjectProperties ddsalesAuthPeriod,
            TestObjectProperties LnkBack, TestObjectProperties LnkForward,
            TestObjectProperties eltStandardSaleAuthQuestion)
        {
            _salesAuthPeriod = new TestObject(browser, ddsalesAuthPeriod);
            _next = new TestObject(browser, btnNext);
            _salesAuthSlide = new TestObject(browser, eltSalesAuthSlide);
            _back = new TestObject(browser, LnkBack);
            _forward = new TestObject(browser, LnkForward);
            _standardSaleAuthQ = new TestObject(browser, eltStandardSaleAuthQuestion);
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
            return _standardSaleAuthQ.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _salesAuthSlide.VerifyDisplayStyleWith("block");
        }

        public void SetSaleAuthPeriodAs(string size)
        {
            _salesAuthPeriod.Select(size);
            ClickNext();
        }

        public void ClickNext()
        {
            _next.Click();
        }

        public void MoveBackToLanguages()
        {
            _back.Click();
        }

        public VerificationInfo ShouldDisplayTheSaleAuthorityValuesAs(IList<string> values)
        {
            IList<string> valuesDisplayedOnPage = _salesAuthPeriod.GetAllOptionsText();


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
