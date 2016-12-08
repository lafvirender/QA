using System;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.PropertyRegistration.Slides
{
    public class Bedrooms
    {
        private readonly TestObject _oneBedRoom;
        private readonly TestObject _twoBedRoom;
        private readonly TestObject _threeBedRoom;
        private readonly TestObject _fourBedRoom;
        private readonly TestObject _lnkBack;
        private readonly TestObject _eltBedroomsSlide;

        public Bedrooms(Browser browser, TestObjectProperties eltBedroomsSlide,
                        TestObjectProperties lnkOneBedRoom, TestObjectProperties lnkTwoBedRoom, 
                        TestObjectProperties lnkThreeBedRoom, TestObjectProperties lnkFourBedRoom, 
                        TestObjectProperties lnkBack)
        {
            _eltBedroomsSlide = new TestObject(browser,eltBedroomsSlide);
            _oneBedRoom = new TestObject(browser, lnkOneBedRoom);
            _twoBedRoom = new TestObject(browser, lnkTwoBedRoom);
            _threeBedRoom = new TestObject(browser, lnkThreeBedRoom);
            _fourBedRoom = new TestObject(browser, lnkFourBedRoom);
            _lnkBack = new TestObject(browser, lnkBack);
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_eltBedroomsSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _eltBedroomsSlide.GetClassAttributeValue();
            return info;
        }

        public void MoveBackToPropertyType()
        {
            _lnkBack.Click();
        }

        public VerificationInfo ShouldVerifyTheColorOfOneBedroomOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _oneBedRoom.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOfTwoBedroomOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _twoBedRoom.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOfThreeBedroomOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _threeBedRoom.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
        public VerificationInfo ShouldVerifyTheColorOfFourBedroomOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _fourBedRoom.GetBackgroundColorHexValue();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyOneBedroomTextWith(string bedroomText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = bedroomText;
            info.Actual = _oneBedRoom.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTwoBedroomTextWith(string bedroomText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = bedroomText;
            info.Actual = _twoBedRoom.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThreeBedroomTextWith(string bedroomText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = bedroomText;
            info.Actual = _threeBedRoom.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyFourPlusBedroomTextWith(string bedroomText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = bedroomText;
            info.Actual = _fourBedRoom.GetText();
            if (info.Actual == info.Expected)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void SelectBedroomAs(string bedrooms)
        {
            if (string.IsNullOrEmpty(bedrooms)) return;
            var option = (BedroomsEnum)Enum.Parse(typeof(BedroomsEnum), bedrooms);
            switch (option)
            {
                case BedroomsEnum.One:
                    SelectOneBedRoom();
                    break;

                case BedroomsEnum.Two:
                    SelectTwoBedRoom();
                    break;

                case BedroomsEnum.Three:
                    SelectThreeBedRoom();
                    break;

                case BedroomsEnum.Four:
                    SelectFourBedRoom();
                    break;

                default:
                    return;
            }
        }

        private void SelectOneBedRoom()
        {
            _oneBedRoom.WaitForSlideOptionToBecomeActive();
            _oneBedRoom.Click();
        }

        private void SelectTwoBedRoom()
        {
            _twoBedRoom.WaitForSlideOptionToBecomeActive();
            _twoBedRoom.Click();
        }

        private void SelectThreeBedRoom()
        {
            _threeBedRoom.WaitForSlideOptionToBecomeActive();
            _threeBedRoom.Click();
        }

        private void SelectFourBedRoom()
        {
            _fourBedRoom.WaitForSlideOptionToBecomeActive();
            _fourBedRoom.Click();
        }

    }
}
