using System;
using System.Collections.Generic;
using System.Linq;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class PropertyValue
    {
        private readonly TestObject _lessThan200K;
        private readonly TestObject _value200KTo400K;
        private readonly TestObject _value400KTo600K;
        private readonly TestObject _value600KTo800K;
        private readonly TestObject _value800KTo1M;
        private readonly TestObject _value1MTo1_5M;
        private readonly TestObject _value1_5MTo2M;
        private readonly TestObject _value2MPlus;

        private readonly TestObject _lessThan200;
        private readonly TestObject _value200To300;
        private readonly TestObject _value300To400;
        private readonly TestObject _value400To500;
        private readonly TestObject _value500To700;
        private readonly TestObject _value700To1000;
        private readonly TestObject _value1000To1500;
        private readonly TestObject _value1500Plus;

        private readonly TestObject _eltApproxValue;
        private readonly TestObject _lnkBack;

        private readonly TestObject _eltPropertyValueSlide;

        public PropertyValue(Browser browser, TestObjectProperties eltPropertyValueSlide, 
                             TestObjectProperties lnkLessThan200K, TestObjectProperties lnkValue200KTo400K,
                             TestObjectProperties lnkValue400KTo600K, TestObjectProperties lnkValue600KTo800K, 
                             TestObjectProperties lnkValue800KTo1M, TestObjectProperties lnkValue1MTo1_5M, 
                             TestObjectProperties lnkValue1_5MTo2M, TestObjectProperties lnkValue2MPlus, 
                             TestObjectProperties lnkLessThan200, TestObjectProperties lnkValue200To300, 
                             TestObjectProperties lnkValue300To400, TestObjectProperties lnkValue400To500,
                             TestObjectProperties lnkValue500To700, TestObjectProperties lnkValue700To1000, 
                             TestObjectProperties lnkValue1000To1500, TestObjectProperties lnkValue1500Plus, 
                             TestObjectProperties eltApproxValue, TestObjectProperties lnkBack)
        {
            _eltPropertyValueSlide = new TestObject(browser, eltPropertyValueSlide);
            _lessThan200K = new TestObject(browser, lnkLessThan200K);
            _value200KTo400K = new TestObject(browser, lnkValue200KTo400K);
            _value400KTo600K = new TestObject(browser, lnkValue400KTo600K);
            _value600KTo800K = new TestObject(browser, lnkValue600KTo800K);
            _value800KTo1M = new TestObject(browser, lnkValue800KTo1M);
            _value1MTo1_5M = new TestObject(browser, lnkValue1MTo1_5M);
            _value1_5MTo2M = new TestObject(browser, lnkValue1_5MTo2M);
            _value2MPlus = new TestObject(browser, lnkValue2MPlus);

            _lessThan200 = new TestObject(browser, lnkLessThan200);
            _value200To300 = new TestObject(browser, lnkValue200To300);
            _value300To400 = new TestObject(browser, lnkValue300To400);
            _value400To500 = new TestObject(browser, lnkValue400To500);
            _value500To700 = new TestObject(browser, lnkValue500To700);
            _value700To1000 = new TestObject(browser, lnkValue700To1000);
            _value1000To1500 = new TestObject(browser, lnkValue1000To1500);
            _value1500Plus = new TestObject(browser, lnkValue1500Plus);

            _eltApproxValue = new TestObject(browser, eltApproxValue);
            _lnkBack = new TestObject(browser, lnkBack);
        }


        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltPropertyValueSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;
            info.Actual = _eltPropertyValueSlide.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLessThan200KValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _lessThan200K.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf200KTo400KValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value200KTo400K.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf400KTo600KValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value400KTo600K.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf600KTo800KValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value600KTo800K.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf800KTo1MValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value800KTo1M.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf1MTo1_5MValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value1MTo1_5M.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf1_5MTo2MValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value1_5MTo2M.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf2MPlusValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value2MPlus.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLessThan200ValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _lessThan200.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf200To300ValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value200To300.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf300To400ValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value300To400.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf400To500ValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value400To500.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf500To700ValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value500To700.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf700To1000ValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value700To1000.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf1000To1500ValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value1000To1500.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOf1500PlusValueWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _value1500Plus.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void MoveBackToBedroomsSelection()
        {
            _lnkBack.Click();
        }

        public void MoveBackToPropertyType()
        {
            _lnkBack.Click();
        }


        public void SelectApproxValueAs(string approxValue)
        {
            var option = (ApproxValueEnum)Enum.Parse(typeof(ApproxValueEnum), approxValue);

            switch (option)
            {
                case ApproxValueEnum.LessThanTwoHunderedK:
                    SelectLessThan200K();
                    break;

                case ApproxValueEnum.TwoHunderedKToFourHunderedK:
                    Select200KTo400K();
                    break;

                case ApproxValueEnum.FourHunderedKToSixHunderedK:
                    Select400KTo600K();
                    break;

                case ApproxValueEnum.SixHunderedKToEightHunderedK:
                    Select600KTo800K();
                    break;

                case ApproxValueEnum.EightHunderedKToOneMillion:
                    Select800KTo1M();
                    break;

                case ApproxValueEnum.OneMillionToOneAndHalfMillion:
                    Select1MTo1_5M();
                    break;

                case ApproxValueEnum.OneAndHalfMillionToTwoMillion:
                    Select1_5MTo2M();
                    break;

                case ApproxValueEnum.MoreThanTwoMillion:
                    Select2MPlus();
                    break;

                case ApproxValueEnum.LessThanTwoHundered:
                    SelectLessThan200();
                    break;

                case ApproxValueEnum.TwoHunderedToThreeHundered:
                    Select200To300();
                    break;

                case ApproxValueEnum.ThreeHunderedToFourHundered:
                    Select300To400();
                    break;

                case ApproxValueEnum.FourHunderedToFiveHundered:
                    Select400To500();
                    break;

                case ApproxValueEnum.FiveHunderedToSevenHundered:
                    Select500To700();
                    break;

                case ApproxValueEnum.SevenHunderedToOneThousand:
                    Select700To1000();
                    break;

                case ApproxValueEnum.OneThousandToFifteenHundered:
                    Select1000To1500();
                    break;

                case ApproxValueEnum.MoreThanFifteenHundered:
                    Select1500Plus();
                    break;

                default:
                    return;
            }
        }


        private void SelectLessThan200K()
        {
            _lessThan200K.WaitForSlideOptionToBecomeActive();
            _lessThan200K.Click();
        }

        private void Select200KTo400K()
        {
            _value200KTo400K.WaitForSlideOptionToBecomeActive();
            _value200KTo400K.Click();
        }

        private void Select400KTo600K()
        {
            _value400KTo600K.WaitForSlideOptionToBecomeActive();
            _value400KTo600K.Click();
        }

        private void Select600KTo800K()
        {
            _value600KTo800K.WaitForSlideOptionToBecomeActive();
            _value600KTo800K.Click();
        }

        private void Select800KTo1M()
        {
            _value800KTo1M.WaitForSlideOptionToBecomeActive();
            _value800KTo1M.Click();
        }

        private void Select1MTo1_5M()
        {
            _value1MTo1_5M.WaitForSlideOptionToBecomeActive();
            _value1MTo1_5M.Click();
        }

        private void Select1_5MTo2M()
        {
            _value1_5MTo2M.WaitForSlideOptionToBecomeActive();
            _value1_5MTo2M.Click();
        }

        private void Select2MPlus()
        {
            _value2MPlus.WaitForSlideOptionToBecomeActive();
            _value2MPlus.Click();
        }

        private void SelectLessThan200()
        {
            _lessThan200.WaitForSlideOptionToBecomeActive();
            _lessThan200.Click();
        }

        private void Select200To300()
        {
            _value200To300.WaitForSlideOptionToBecomeActive();
            _value200To300.Click();
        }

        private void Select300To400()
        {
            _value300To400.WaitForSlideOptionToBecomeActive();
            _value300To400.Click();
        }

        private void Select400To500()
        {
            _value400To500.WaitForSlideOptionToBecomeActive();
            _value400To500.Click();
        }

        private void Select500To700()
        {
            _value500To700.WaitForSlideOptionToBecomeActive();
            _value500To700.Click();
        }

        private void Select700To1000()
        {
            _value700To1000.WaitForSlideOptionToBecomeActive();
            _value700To1000.Click();
        }

        private void Select1000To1500()
        {
            _value1000To1500.WaitForSlideOptionToBecomeActive();
            _value1000To1500.Click();
        }

        private void Select1500Plus()
        {
            _value1500Plus.WaitForSlideOptionToBecomeActive();
            _value1500Plus.Click();
        }

        public VerificationInfo ShouldDisplayTheValuesForRentAs(IList<string> values)
        {
            IList<string> valuesDisplayedOnPage = _eltApproxValue.GetAListOfAllMatchingTestObjectsTextsValues();
            VerificationInfo info = new VerificationInfo();
            info.Expected = string.Join(",", values.ToArray());
            info.Actual = string.Join(",", _eltApproxValue.GetAListOfAllMatchingTestObjectsTextsValues().ToArray());
            if (values.All(value => valuesDisplayedOnPage.Contains(value.Trim())))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldDisplayTheValuesForSellAs(IList<string> values)
        {
            IList<string> valuesDisplayedOnPage = _eltApproxValue.GetAListOfAllMatchingTestObjectsTextsValues();

            VerificationInfo info = new VerificationInfo();
            info.Expected = string.Join(",", values.ToArray());
            info.Actual = string.Join(",", _eltApproxValue.GetAListOfAllMatchingTestObjectsTextsValues().ToArray()); 
            if (values.All(value => valuesDisplayedOnPage.Contains(value.Trim())))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
