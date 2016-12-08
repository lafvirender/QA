using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForRent.Slides
{
    public class AgentRentalFeeStructure
    {
        private readonly TestObject _rentalFeeStructureSlide;
        private readonly TestObject _rentalFeeStructureQ;
        private readonly TestObject _lettingFee;
        private readonly TestObject _managementFee;
        private readonly TestObject _marketingBudget;
        private readonly TestObject _rentalFeeStructureSubmit;
        private readonly TestObject _errors;

        public AgentRentalFeeStructure(Browser browser, TestObjectProperties eltRentalFeeStructureSlide,
            TestObjectProperties eltRentalFeeStructureQ, TestObjectProperties lstLettingFee, TestObjectProperties txtManagementFee,
            TestObjectProperties lstMarketingBudget, TestObjectProperties btnRentalFeeStructureSubmit,
            TestObjectProperties eltErrors)
        {
            _rentalFeeStructureSlide = new TestObject(browser, eltRentalFeeStructureSlide);
            _rentalFeeStructureQ = new TestObject(browser, eltRentalFeeStructureQ);
            _lettingFee = new TestObject(browser, lstLettingFee);
            _managementFee = new TestObject(browser, txtManagementFee);
            _marketingBudget = new TestObject(browser, lstMarketingBudget);
            _rentalFeeStructureSubmit = new TestObject(browser, btnRentalFeeStructureSubmit);
            _errors = new TestObject(browser, eltErrors);
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
            return _rentalFeeStructureQ.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _rentalFeeStructureSlide.VerifyDisplayStyleWith("block");
        }

        public VerificationInfo ShouldDisplayTheLettingFeeValuesAs(IList<string> values)
        {
            IList<string> valuesDisplayedOnPage = _lettingFee.GetAllOptionsText();

            VerificationInfo info = new VerificationInfo();
            info.Expected = string.Join(",", values.ToArray());
            info.Actual = string.Join(",", valuesDisplayedOnPage.ToArray());
            if (values.All(value => valuesDisplayedOnPage.Contains(value.Trim())))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldDisplayTheMarketingBudgetValuesAs(IList<string> values)
        {
            IList<string> valuesDisplayedOnPage = _marketingBudget.GetAllOptionsText();

            VerificationInfo info = new VerificationInfo();
            info.Expected = string.Join(",", values.ToArray());
            info.Actual = string.Join(",", valuesDisplayedOnPage.ToArray());
            if (values.All(value => valuesDisplayedOnPage.Contains(value.Trim())))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatErrorIsDisplayed(string errText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = errText;
            info.Actual = string.Join(",", _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToArray());
            if (_errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public void SelectLettingFeeAs(string text)
        {
            if (!string.IsNullOrEmpty(text))
                _lettingFee.Select(text);
        }

        public void SelectMarketingBudgetAs(string option)
        {
            if (!string.IsNullOrEmpty(option))
                _marketingBudget.Select(option);
        }

        public void SetManagementFeeAs(string mgmtFee)
        {
            if (!string.IsNullOrEmpty(mgmtFee))
                _managementFee.SendKeys(mgmtFee);
        }
        public void ClickSubmit()
        {
            _rentalFeeStructureSubmit.Click();
        }
        public void ShouldEntertheRentalFeeStructureDetailsAs(LandlordProposalFields landlordPropFields)
        {
            SelectLettingFeeAs(landlordPropFields.LettingFee);
            SetManagementFeeAs(landlordPropFields.RentalsManagementFee);
            SelectMarketingBudgetAs(landlordPropFields.RentalMarketingBudget);
        }
    }
}
