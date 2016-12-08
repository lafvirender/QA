using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForRent.Slides
{
    public class LandlordInsuranceAdvice
    {
        private readonly TestObject _landlordInsuranceAdviceSlide;
        private readonly TestObject _landlordInsuranceAdviceQuestion;
        private readonly TestObject _landlordInsuranceAdviceYes;
        private readonly TestObject _landlordInsuranceAdviceNo;
        private readonly TestObject _forward;
        private readonly TestObject _back;



        public LandlordInsuranceAdvice(Browser browser, TestObjectProperties eltlandlordInsuranceAdviceSlide,
            TestObjectProperties eltlandlordInsuranceAdviceQuestion, TestObjectProperties btnlandlordInsuranceAdviceYes,
            TestObjectProperties btnlandlordInsuranceAdviceNo, TestObjectProperties lnkForward, TestObjectProperties lnkBack)
        {
            _landlordInsuranceAdviceSlide = new TestObject(browser, eltlandlordInsuranceAdviceSlide);
            _landlordInsuranceAdviceQuestion = new TestObject(browser, eltlandlordInsuranceAdviceQuestion);
            _landlordInsuranceAdviceYes = new TestObject(browser, btnlandlordInsuranceAdviceYes);
            _landlordInsuranceAdviceNo = new TestObject(browser, btnlandlordInsuranceAdviceNo);
            _forward = new TestObject(browser, lnkForward);
            _back = new TestObject(browser, lnkBack);

        }

        public void GoBackToEmergencyContact()
        {
            _back.Click();
        }


        public void ClickForwardLink()
        {
            _forward.Click();
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
            return _landlordInsuranceAdviceQuestion.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _landlordInsuranceAdviceSlide.VerifyDisplayStyleWith("block");
        }


        public void SelectYes()
        {
            _landlordInsuranceAdviceYes.Click();
        }

        public void SelectNo()
        {
            _landlordInsuranceAdviceNo.Click();
        }

        public VerificationInfo ShouldVerifyTheColorOfYesOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _landlordInsuranceAdviceYes.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfNoOptionWith(string expectedColorHexValue)
        {

            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _landlordInsuranceAdviceNo.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }


        public void SelectOptionAs(string option)
        {
            if (option == "Yes")
                SelectYes();

            if (option == "No")
                SelectNo();
        }
    }
}
