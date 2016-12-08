using System;
using System.Linq;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForSell.Slides
{
    public class PostCodeSelection
    {
        private readonly TestObject _postCodeSelectionSlide;
        private readonly TestObject _next;
        private readonly TestObject _back;
        private readonly TestObject _forward;
        private readonly TestObject _postCode1;
        private readonly TestObject _postCode2;
        private readonly TestObject _postCode3;
        private readonly TestObject _postCode4;
        private readonly TestObject _postCode5;
        private readonly TestObject _postcodesSelectionQ;

        public PostCodeSelection(Browser browser, TestObjectProperties eltPostCodeSelectionSlide,
            TestObjectProperties btnNext, TestObjectProperties txtPostCode1,
            TestObjectProperties txtPostCode2, TestObjectProperties txtPostCode3,
            TestObjectProperties txtPostCode4, TestObjectProperties txtPostCode5,
            TestObjectProperties lnkBack, TestObjectProperties lnkForward,
            TestObjectProperties eltPostcodesSelectionQuestion)
        {
            _postCodeSelectionSlide = new TestObject(browser, eltPostCodeSelectionSlide);
            _next = new TestObject(browser, btnNext);
            _back = new TestObject(browser, lnkBack);
            _forward = new TestObject(browser, lnkForward);

            _postCode1 = new TestObject(browser, txtPostCode1);
            _postCode2 = new TestObject(browser, txtPostCode2);
            _postCode3 = new TestObject(browser, txtPostCode3);
            _postCode4 = new TestObject(browser, txtPostCode4);
            _postCode5 = new TestObject(browser, txtPostCode5);
            _postcodesSelectionQ = new TestObject(browser, eltPostcodesSelectionQuestion);
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
            return _postcodesSelectionQ.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _postCodeSelectionSlide.VerifyDisplayStyleWith("block");
        }

        public void SetValueInFirstPostCode(string postCode)
        {
            if (!string.IsNullOrEmpty(postCode))
                     _postCode1.SendKeys(postCode);
        }

        public void SetValueInSecondPostCode(string postCode)
        {
            if (!string.IsNullOrEmpty(postCode))
                _postCode2.SendKeys(postCode);
        }
        public void SetValueInThirdPostCode(string postCode)
        {
            if (!string.IsNullOrEmpty(postCode))
                _postCode3.SendKeys(postCode);
        }
        public void SetValueInFourthPostCode(string postCode)
        {
            if (!string.IsNullOrEmpty(postCode))
                _postCode4.SendKeys(postCode);
        }
        public void SetValueInFifthPostCode(string postCode)
        {
            if (!string.IsNullOrEmpty(postCode))
                _postCode5.SendKeys(postCode);
        }

        public void SetValueInPostCodes(string allPostCodes)
        {
            if (!string.IsNullOrEmpty(allPostCodes))
            {
                var postCodes = allPostCodes.Split(',');
                try
                {
                    if (!string.IsNullOrEmpty(postCodes[0]))
                        _postCode1.SendKeys(postCodes[0]);

                    if (!string.IsNullOrEmpty(postCodes[1]))
                        _postCode2.SendKeys(postCodes[1]);

                    if (!string.IsNullOrEmpty(postCodes[2]))
                        _postCode3.SendKeys(postCodes[2]);

                    if (!string.IsNullOrEmpty(postCodes[3]))
                        _postCode4.SendKeys(postCodes[3]);

                    if (!string.IsNullOrEmpty(postCodes[4]))
                        _postCode5.SendKeys(postCodes[4]);
                }
                catch (IndexOutOfRangeException)
                {

                }
            }
        }

        public void ClickNext()
        {
            _next.Click();
        }
    }
}
