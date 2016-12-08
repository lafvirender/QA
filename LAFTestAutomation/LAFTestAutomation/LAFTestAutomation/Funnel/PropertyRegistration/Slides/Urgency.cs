using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class Urgency
    {
        private readonly TestObject _urgencySlide;
        private readonly TestObject _immidiately;
        private readonly TestObject _zeroToThreeMonths;
        private readonly TestObject _threeToSixMonths;
        private readonly TestObject _sixPlusMonths;
        private readonly TestObject _back;
        private readonly TestObject _forward;


        public Urgency(Browser browser, TestObjectProperties eltUrgencySlide,
                        TestObjectProperties lnkImmidiately, TestObjectProperties lnkZeroToThreeMonths,
                        TestObjectProperties lnkThreeToSixMonths, TestObjectProperties lnkSixPlusMonths,
                        TestObjectProperties lnkBack, TestObjectProperties lnkForward)
        {
            _urgencySlide = new TestObject(browser, eltUrgencySlide);
            _immidiately = new TestObject(browser, lnkImmidiately);
            _zeroToThreeMonths = new TestObject(browser, lnkZeroToThreeMonths);
            _threeToSixMonths = new TestObject(browser, lnkThreeToSixMonths);
            _sixPlusMonths = new TestObject(browser, lnkSixPlusMonths);
            _back = new TestObject(browser, lnkBack);
            _forward = new TestObject(browser, lnkForward);
        }

        public void MoveForwardToPersonalDetailsSection()
        {
            _forward.Click();
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_urgencySlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;
            info.Actual = _urgencySlide.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfImmediatelyOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _immidiately.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfZeroToThreeMonthsOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _zeroToThreeMonths.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfThreeToSixMonthsOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _threeToSixMonths.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfSixPlusMonthsOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _sixPlusMonths.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void MoveBackToContactedAgenciesQ()
        {
            _back.Click();
        }

        public void SelectUrgencyAs(string urgency)
        {
            if (string.IsNullOrEmpty(urgency)) return;
            var option = (UrgencyEnum)Enum.Parse(typeof(UrgencyEnum), urgency);
            switch (option)
            {
                case UrgencyEnum.Immediately:
                    SelectImmediately();
                    break;

                case UrgencyEnum.ZeroToThreeMonths:
                    SelectZeroToThreeMonths();
                    break;

                case UrgencyEnum.ThreeToSixMonths:
                    SelectThreeToSixMonths();
                    break;

                case UrgencyEnum.SixPlusMonths:
                    SelectSixPlusMonths();
                    break;

                default:
                    return;
            }
        }

        private void SelectImmediately()
        {
            _immidiately.WaitForSlideOptionToBecomeActive();
            _immidiately.Click();
        }

        private void SelectZeroToThreeMonths()
        {
            _zeroToThreeMonths.WaitForSlideOptionToBecomeActive();
            _zeroToThreeMonths.Click();

        }
        private void SelectThreeToSixMonths()
        {
            _threeToSixMonths.WaitForSlideOptionToBecomeActive();
            _threeToSixMonths.Click();
        }
        private void SelectSixPlusMonths()
        {
            _sixPlusMonths.WaitForSlideOptionToBecomeActive();
            _sixPlusMonths.Click();
        }

        public VerificationInfo ShouldVerifyImmediatelyOptionTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _immidiately.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }


        public VerificationInfo ShouldVerifyZeroToThreeMonthsOptionTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _zeroToThreeMonths.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThreeToSixMonthsOptionTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _threeToSixMonths.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifySixPlusMonthsOptionTextWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = _sixPlusMonths.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
