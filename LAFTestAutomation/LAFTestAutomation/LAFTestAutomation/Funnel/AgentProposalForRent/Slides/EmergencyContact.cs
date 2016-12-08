using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForRent.Slides
{
    public class EmergencyContact
    {
        private readonly TestObject _emergencyContactSlide;
        private readonly TestObject _eltEmergencyContactQuestion;
        private readonly TestObject _emergencyContactYes;
        private readonly TestObject _emergencyContactNo;
        private readonly TestObject _back;
        private readonly TestObject _forward;


        public EmergencyContact(Browser browser, TestObjectProperties eltEmergencyContactSlide,   
            TestObjectProperties eltEmergencyContactQuestion, TestObjectProperties btnEmergencyContactYes,
            TestObjectProperties btnEmergencyContactNo, TestObjectProperties lnkBack, TestObjectProperties lnkForward)
        {
            _emergencyContactSlide = new TestObject(browser, eltEmergencyContactSlide);
            _eltEmergencyContactQuestion = new TestObject(browser, eltEmergencyContactQuestion);
            _emergencyContactYes = new TestObject(browser, btnEmergencyContactYes);
            _emergencyContactNo = new TestObject(browser, btnEmergencyContactNo);
            _back = new TestObject(browser, lnkBack);
            _forward = new TestObject(browser, lnkForward);
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
            return _eltEmergencyContactQuestion.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _emergencyContactSlide.VerifyDisplayStyleWith("block");
        }


        public void SelectYes()
        {
            _emergencyContactYes.Click();
        }

        public void SelectNo()
        {
            _emergencyContactNo.Click();
        }

        public VerificationInfo ShouldVerifyTheColorOfYesOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _emergencyContactYes.GetBackgroundColorHexValue();
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
            info.Actual = _emergencyContactNo.GetBackgroundColorHexValue();
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

        public void MoveBackToLanguages()
        {
            _back.Click();
        }

    }
}
