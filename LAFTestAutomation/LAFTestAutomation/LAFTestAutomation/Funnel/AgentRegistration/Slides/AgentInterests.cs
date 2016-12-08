using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration.Slides
{
    public class AgentInterests
    {
        private readonly TestObject _propCategorySlide;
        private readonly TestObject _sales;
        private readonly TestObject _rentals;
        private readonly TestObject _both;
        private readonly TestObject _forward;
        private readonly TestObject _agentInterestQuestion;


        public AgentInterests(Browser browser, TestObjectProperties eltpropCategorySlide,
                                TestObjectProperties lnkSales, TestObjectProperties lnkRentals,
                                 TestObjectProperties lnkBoth, TestObjectProperties lnkForward,
                                 TestObjectProperties eltAgentInterestQuestion)
        {
            _propCategorySlide = new TestObject(browser, eltpropCategorySlide);
            _sales = new TestObject(browser, lnkSales);
            _rentals = new TestObject(browser, lnkRentals);
            _both = new TestObject(browser, lnkBoth);
            _forward = new TestObject(browser, lnkForward);
            _agentInterestQuestion = new TestObject(browser, eltAgentInterestQuestion);
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
            return _agentInterestQuestion.GetText();
        }


        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_propCategorySlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _propCategorySlide.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyPropertyCategorySalesTextWith(string catText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = catText;
            info.Actual = _sales.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyPropertyCategoryRentalsTextWith(string catText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = catText;
            info.Actual = _rentals.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyPropertyCategoryBothTextWith(string catText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = catText;
            info.Actual = _both.GetText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private void SelectSell()
        {
            _sales.Click();
        }

        private void SelectRent()
        {
            _rentals.Click();
        }

        private void SelectBoth()
        {
            _both.Click();
        }


        public void MoveForwardToAboutYou()
        {
            _forward.Click();
        }

        public void SelectPropertyCategoryAs(string category)
        {
            var option = (PropertyCategoryEnum)System.Enum.Parse(typeof(PropertyCategoryEnum), category);

            switch (option)
            {
                case PropertyCategoryEnum.Sales:
                    SelectSell();
                    break;

                case PropertyCategoryEnum.Rentals:
                    SelectRent();
                    break;

                case PropertyCategoryEnum.Both:
                    SelectBoth();
                    break;

                default:
                    return;
            }
        }

        public VerificationInfo ShouldVerifyTheColorOfSalesOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _sales.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfRentalsOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _rentals.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfBothOptionWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _both.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void MoveForwardToAgentDetails()
        {
            _forward.Click();
        }
    }
}
