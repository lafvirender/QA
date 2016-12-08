using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration.Slides
{
    public class KeyInfo
    {
        private readonly TestObject _acceptAndContinue;
        private readonly TestObject _keyInfoSlide;
        private readonly TestObject _keyInfoHeading;
        private readonly TestObject _rentalKeyInfo;
        private readonly TestObject _salesKeyInfo;

        public KeyInfo(Browser browser, TestObjectProperties eltKeyInfoSlide, TestObjectProperties btnAcceptAndContinue,
                            TestObjectProperties eltKeyInfoHeading, TestObjectProperties eltRentalKeyInfo,
                            TestObjectProperties eltSalesKeyInfo)
        {
            _acceptAndContinue = new TestObject(browser, btnAcceptAndContinue);
            _keyInfoSlide = new TestObject(browser, eltKeyInfoSlide);
            _keyInfoHeading = new TestObject(browser, eltKeyInfoHeading);
            _rentalKeyInfo = new TestObject(browser, eltRentalKeyInfo);
            _salesKeyInfo = new TestObject(browser, eltSalesKeyInfo);
        }

        public VerificationInfo ShouldVerifyRentalKeyInformationIsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_rentalKeyInfo.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifySalesKeyInformationIsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_salesKeyInfo.IsDisplayed())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string questionString)
        {
            VerificationInfo info = new VerificationInfo();
            info.Actual = questionString;
            info.Expected = GetQuestionText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private string GetQuestionText()
        {
            return _keyInfoHeading.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_keyInfoSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _keyInfoSlide.GetClassAttributeValue();
            return info;
        }

        public void SelectAcceptAndContinue()
        {
            _acceptAndContinue.Click();
        }

        public VerificationInfo KeyInformationSectionForBothSalesAndRentalsAreDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (ShouldVerifyRentalKeyInformationIsDisplayed().Result 
               && ShouldVerifySalesKeyInformationIsDisplayed().Result)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
