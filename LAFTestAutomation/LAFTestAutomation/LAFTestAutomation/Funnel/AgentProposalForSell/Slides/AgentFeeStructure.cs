using LAFTestAutomationFramework.ApplicationBasedHelpers;
using LAFTestAutomationFramework.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace LAFTestAutomationFramework.Funnel.AgentProposalForSell.Slides
{
    public class AgentFeeStructure
    {
        private readonly TestObject _feeStructureSlide;
        private readonly TestObject _next;
        private readonly TestObject _back;
        private readonly TestObject _forward;
        private readonly TestObject _agentFeeStructureQ;
        private readonly TestObject _propertiesBetween;
        private readonly TestObject _commissionTypes;
        private readonly TestObject _marketingBudget;
        private readonly TestObject _addHigherRange;
        private readonly TestObject _feeStructureSection;
        private readonly TestObject _firstFeeStrPropertiesBetweenLB;

        private readonly TestObject _firstFeeStrPropertiesBetweenUB;
        private readonly TestObject _firstFeeStrCommissionType;
        private readonly TestObject _firstFeeStrCommissionPercentage;
        private readonly TestObject _firstFeeStrCommissionFixed;
        private readonly TestObject _firstFeeStrMarketingBudget;
        private readonly TestObject _secondFeeStrPropertiesBetweenLB;
        private readonly TestObject _secondFeeStrPropertiesBetweenUB;
        private readonly TestObject _secondFeeStrCommissionType;
        private readonly TestObject _secondFeeStrCommissionPercentage;
        private readonly TestObject _secondFeeStrCommissionFixed;
        private readonly TestObject _secondFeeStrMarketingBudget;
        private readonly TestObject _thirdFeeStrPropertiesBetweenLB;
        private readonly TestObject _thirdFeeStrPropertiesBetweenUB;
        private readonly TestObject _thirdFeeStrCommissionType;
        private readonly TestObject _thirdFeeStrCommissionPercentage;
        private readonly TestObject _thirdFeeStrCommissionFixed;
        private readonly TestObject _thirdFeeStrMarketingBudget;
        private readonly TestObject _deleteRange;

        private readonly TestObject _errors;

        private readonly TestObject _feeStructureSubmit;

        public AgentFeeStructure(Browser browser, TestObjectProperties eltFeeStructureSlide,
            TestObjectProperties btnNext, TestObjectProperties lnkBack, TestObjectProperties lnkForward,
            TestObjectProperties eltAgentFeeStructureQuestion, TestObjectProperties lstPropertiesBetween,
            TestObjectProperties lstCommissionTypes, TestObjectProperties lstMarketingBudget, TestObjectProperties btnAddHigherRange,
            TestObjectProperties eltFeeStructureSection, TestObjectProperties LstFirstFeeStrPropertiesBetweenLB,
            TestObjectProperties lstFirstFeeStrPropertiesBetweenUB, TestObjectProperties lstFirstFeeStrCommissionType,
            TestObjectProperties txtFirstFeeStrCommissionPercentage, TestObjectProperties txtFirstFeeStrCommissionFixed,
            TestObjectProperties lstFirstFeeStrMarketingBudget, TestObjectProperties LstSecondFeeStrPropertiesBetweenLB,
            TestObjectProperties lstSecondFeeStrPropertiesBetweenUB, TestObjectProperties lstSecondFeeStrCommissionType,
            TestObjectProperties txtSecondFeeStrCommissionPercentage, TestObjectProperties txtSecondFeeStrCommissionFixed,
            TestObjectProperties lstSecondFeeStrMarketingBudget, TestObjectProperties LstThirdFeeStrPropertiesBetweenLB,
            TestObjectProperties lstThirdFeeStrPropertiesBetweenUB, TestObjectProperties lstThirdFeeStrCommissionType,
            TestObjectProperties txtThirdFeeStrCommissionPercentage, TestObjectProperties txtThirdFeeStrCommissionFixed,
            TestObjectProperties lstThirdFeeStrMarketingBudget, TestObjectProperties btnDeleteRange,
            TestObjectProperties btnFeeStructureSubmit, TestObjectProperties eltErrors)
        {
            _feeStructureSlide = new TestObject(browser, eltFeeStructureSlide);
            _next = new TestObject(browser, btnNext);
            _back = new TestObject(browser, lnkBack);
            _forward = new TestObject(browser, lnkForward);
            _agentFeeStructureQ = new TestObject(browser, eltAgentFeeStructureQuestion);
            _propertiesBetween = new TestObject(browser, lstPropertiesBetween);
            _commissionTypes = new TestObject(browser, lstCommissionTypes);
            _marketingBudget = new TestObject(browser, lstMarketingBudget);
            _addHigherRange = new TestObject(browser, btnAddHigherRange);
            _feeStructureSection = new TestObject(browser, eltFeeStructureSection);

            _firstFeeStrPropertiesBetweenLB = new TestObject(browser, LstFirstFeeStrPropertiesBetweenLB);
            _firstFeeStrPropertiesBetweenUB = new TestObject(browser, lstFirstFeeStrPropertiesBetweenUB);
            _firstFeeStrCommissionType = new TestObject(browser, lstFirstFeeStrCommissionType);
            _firstFeeStrCommissionPercentage = new TestObject(browser, txtFirstFeeStrCommissionPercentage);
            _firstFeeStrCommissionFixed = new TestObject(browser, txtFirstFeeStrCommissionFixed);
            _firstFeeStrMarketingBudget = new TestObject(browser, lstFirstFeeStrMarketingBudget);

            _secondFeeStrPropertiesBetweenLB = new TestObject(browser, LstSecondFeeStrPropertiesBetweenLB);
            _secondFeeStrPropertiesBetweenUB = new TestObject(browser, lstSecondFeeStrPropertiesBetweenUB);
            _secondFeeStrCommissionType = new TestObject(browser, lstSecondFeeStrCommissionType);
            _secondFeeStrCommissionPercentage = new TestObject(browser, txtSecondFeeStrCommissionPercentage);
            _secondFeeStrCommissionFixed = new TestObject(browser, txtSecondFeeStrCommissionFixed);
            _secondFeeStrMarketingBudget = new TestObject(browser, lstSecondFeeStrMarketingBudget);

            _thirdFeeStrPropertiesBetweenLB = new TestObject(browser, LstThirdFeeStrPropertiesBetweenLB);
            _thirdFeeStrPropertiesBetweenUB = new TestObject(browser, lstThirdFeeStrPropertiesBetweenUB);
            _thirdFeeStrCommissionType = new TestObject(browser, lstThirdFeeStrCommissionType);
            _thirdFeeStrCommissionPercentage = new TestObject(browser, txtThirdFeeStrCommissionPercentage);
            _thirdFeeStrCommissionFixed = new TestObject(browser, txtThirdFeeStrCommissionFixed);
            _thirdFeeStrMarketingBudget = new TestObject(browser, lstThirdFeeStrMarketingBudget);
            _deleteRange = new TestObject(browser, btnDeleteRange);
            _feeStructureSubmit = new TestObject(browser, btnFeeStructureSubmit);
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
            return _agentFeeStructureQ.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _feeStructureSlide.VerifyDisplayStyleWith("block");
        }

        public VerificationInfo ShouldDisplayThePropertyBetweenValuesAs(IList<string> values)
        {
            IList<string> valuesDisplayedOnPage = _firstFeeStrPropertiesBetweenUB.GetAllOptionsText();

            VerificationInfo info = new VerificationInfo();
            info.Expected = string.Join(",", values.ToArray());
            info.Actual = string.Join(",", valuesDisplayedOnPage.ToArray());
            if (values.All(value => valuesDisplayedOnPage.Contains(value.Trim())))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldDisplayTheCommissionTypesValuesAs(IList<string> values)
        {
            IList<string> valuesDisplayedOnPage = _firstFeeStrCommissionType.GetAllOptionsText();
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
            IList<string> valuesDisplayedOnPage = _firstFeeStrMarketingBudget.GetAllOptionsText();
            VerificationInfo info = new VerificationInfo();
            info.Expected = string.Join(",", values.ToArray());
            info.Actual = string.Join(",", valuesDisplayedOnPage.ToArray());
            if (values.All(value => valuesDisplayedOnPage.Contains(value.Trim())))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private VerificationInfo VerifyCountOfFeeStructureSectionsWith(int count)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = count.ToString();
            info.Actual = _feeStructureSection.GetAllMatchingTestObjectsCount().ToString();
            if (count == _feeStructureSection.GetAllMatchingTestObjectsCount())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatSecondFeeStructureIsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            _secondFeeStrCommissionType.IsDisplayed();
            if (!VerifyCountOfFeeStructureSectionsWith(2).Result)
                info.Result = false;
            else
                if (_secondFeeStrPropertiesBetweenUB.IsEnabled() && _secondFeeStrCommissionType.IsEnabled() && _secondFeeStrMarketingBudget.IsEnabled())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatSecondFeeStructureIsNotDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            _secondFeeStrCommissionType.IsDisplayed();
            if (_secondFeeStrPropertiesBetweenUB.IsEnabled() && _secondFeeStrCommissionType.IsEnabled() && _secondFeeStrMarketingBudget.IsEnabled())
                info.Result = false;
            else
                info.Result = true;

            return info;
        }



        public VerificationInfo ShouldVerifyThatThirdFeeStructureIsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            _thirdFeeStrPropertiesBetweenLB.IsDisplayed();
            if (!VerifyCountOfFeeStructureSectionsWith(3).Result)
                info.Result = false;
            else
                if (_thirdFeeStrPropertiesBetweenUB.IsEnabled() && _thirdFeeStrCommissionType.IsEnabled() && _thirdFeeStrMarketingBudget.IsEnabled())
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyThatThirdFeeStructureIsNotDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            _thirdFeeStrPropertiesBetweenLB.IsDisplayed();
            if (!VerifyCountOfFeeStructureSectionsWith(3).Result)
                info.Result = true;
            else
                if (_thirdFeeStrPropertiesBetweenUB.IsEnabled() && _thirdFeeStrCommissionType.IsEnabled() && _thirdFeeStrMarketingBudget.IsEnabled())
                info.Result = false;
            else
                info.Result = true;

            return info;
        }

        public void ClickAddHigherRange()
        {
            _addHigherRange.Click();
        }

        public void ClickAddHigherRangeSecondTime()
        {
            _secondFeeStrPropertiesBetweenUB.IsDisplayed();
            _addHigherRange.Click();
        }

        public void ClickDeleteRange()
        {
            _deleteRange.Click();
        }

        public void ClickDeleteRangeToDeleteSecFeeStr()
        {
            _addHigherRange.IsDisplayed();
            _deleteRange.Click();
        }

        public void SelectFirstFeeStructurePropertiesBetweenUB(string text)
        {
            if (!string.IsNullOrEmpty(text))
                _firstFeeStrPropertiesBetweenUB.Select(text);
        }

        public void SelectFirstFeeStructureCommissionTypeAs(string option)
        {
            if (!string.IsNullOrEmpty(option))
                _firstFeeStrCommissionType.Select(option);
        }

        public void SetFirstFeeStructureCommissionPercentageAs(string value)
        {
            if (!string.IsNullOrEmpty(value))
                _firstFeeStrCommissionPercentage.SendKeys(value);
        }

        public void SetFirstFeeStructureCommissionFixedFeeAs(string fixedFee)
        {
            if (!string.IsNullOrEmpty(fixedFee))
                _firstFeeStrCommissionFixed.SendKeys(fixedFee);
        }

        public void SelectFirstFeeStructureMarketingBudgetAs(string option)
        {
            if (!string.IsNullOrEmpty(option))
                _firstFeeStrMarketingBudget.Select(option);
        }



        public void ShouldEntertheFirstFeeStructureDetailsAs(VendorProposalFields vendPropFields)
        {
            SelectFirstFeeStructurePropertiesBetweenUB(vendPropFields.FirstFeeStrPropertiesBetweenUB);
            SelectFirstFeeStructureCommissionTypeAs(vendPropFields.FirstFeeStrCommissionType);
            if (vendPropFields.FirstFeeStrCommissionType == "percentage")
                SetFirstFeeStructureCommissionPercentageAs(vendPropFields.FirstFeeStrCommissionPercentage);
            else
                SetFirstFeeStructureCommissionFixedFeeAs(vendPropFields.FirstFeeStrCommissionFixedFee);

            SelectFirstFeeStructureMarketingBudgetAs(vendPropFields.FirstFeeStrMarketingBudget);
        }


        public void SelectSecondFeeStructurePropertiesBetweenUB(string text)
        {
            if (!string.IsNullOrEmpty(text))
                _secondFeeStrPropertiesBetweenUB.Select(text);
        }

        public void SelectSecondFeeStructureCommissionTypeAs(string option)
        {
            if (!string.IsNullOrEmpty(option))
                _secondFeeStrCommissionType.Select(option);
        }

        public void SetSecondFeeStructureCommissionPercentageAs(string value)
        {
            if (!string.IsNullOrEmpty(value))
                _secondFeeStrCommissionPercentage.SendKeys(value);
        }

        public void SetSecondFeeStructureCommissionFixedFeeAs(string fixedFee)
        {
            if (!string.IsNullOrEmpty(fixedFee))
                _secondFeeStrCommissionFixed.SendKeys(fixedFee);
        }

        public void SelectSecondFeeStructureMarketingBudgetAs(string option)
        {
            if (!string.IsNullOrEmpty(option))
                _secondFeeStrMarketingBudget.Select(option);
        }


        public void ShouldEntertheSecondFeeStructureDetailsAs(VendorProposalFields vendPropFields)
        {
            SelectSecondFeeStructurePropertiesBetweenUB(vendPropFields.SecondFeeStrPropertiesBetweenUB);
            SelectSecondFeeStructureCommissionTypeAs(vendPropFields.SecondFeeStrCommissionType);
            if (vendPropFields.SecondFeeStrCommissionType == "percentage")
                SetSecondFeeStructureCommissionPercentageAs(vendPropFields.SecondFeeStrCommissionPercentage);
            else
                SetSecondFeeStructureCommissionFixedFeeAs(vendPropFields.SecondFeeStrCommissionFixedFee);

            SelectSecondFeeStructureMarketingBudgetAs(vendPropFields.SecondFeeStrMarketingBudget);
        }


        public void SelectThirdFeeStructurePropertiesBetweenUB(string text)
        {
            if (!string.IsNullOrEmpty(text))
                _thirdFeeStrPropertiesBetweenUB.Select(text);
        }

        public void SelectThirdFeeStructureCommissionTypeAs(string option)
        {
            if (!string.IsNullOrEmpty(option))
                _thirdFeeStrCommissionType.Select(option);
        }

        public void SetThirdFeeStructureCommissionPercentageAs(string value)
        {
            if (!string.IsNullOrEmpty(value))
                _thirdFeeStrCommissionPercentage.SendKeys(value);
        }

        public void SetThirdFeeStructureCommissionFixedFeeAs(string fixedFee)
        {
            if (!string.IsNullOrEmpty(fixedFee))
                _thirdFeeStrCommissionFixed.SendKeys(fixedFee);
        }

        public void SelectThirdFeeStructureMarketingBudgetAs(string option)
        {
            if (!string.IsNullOrEmpty(option))
                _thirdFeeStrMarketingBudget.Select(option);
        }

        public void ShouldEntertheThirdFeeStructureDetailsAs(VendorProposalFields vendPropFields)
        {
            SelectThirdFeeStructurePropertiesBetweenUB(vendPropFields.ThirdFeeStrPropertiesBetweenUB);
            SelectThirdFeeStructureCommissionTypeAs(vendPropFields.ThirdFeeStrCommissionType);
            if (vendPropFields.ThirdFeeStrCommissionType == "percentage")
                SetThirdFeeStructureCommissionPercentageAs(vendPropFields.ThirdFeeStrCommissionPercentage);
            else
                SetThirdFeeStructureCommissionFixedFeeAs(vendPropFields.ThirdFeeStrCommissionFixedFee);

            SelectThirdFeeStructureMarketingBudgetAs(vendPropFields.ThirdFeeStrMarketingBudget);
        }

        public void ClickSubmit()
        {
            _feeStructureSubmit.Click();
        }

        public VerificationInfo ShouldVerifyThatErrorIsDisplayed(string errText)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = errText;
            info.Actual =string.Join(",", _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToArray());
            if (_errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errText))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheSecondFeeStructurePropBetweenLBValueWith(string value)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = value;
            info.Actual = _secondFeeStrPropertiesBetweenLB.GetSelectedValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheSecondFeeStructurePropBetweenUBValueWith(string value)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = value;
            info.Actual = _secondFeeStrPropertiesBetweenUB.GetSelectedValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheThirdFeeStructurePropBetweenLBValueWith(string value)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = value;
            info.Actual = _thirdFeeStrPropertiesBetweenLB.GetSelectedValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheThirdFeeStructurePropBetweenUBValueWith(string value)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = value;
            info.Actual = _thirdFeeStrPropertiesBetweenUB.GetSelectedValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheSecondFeeStrPropBetweenLBAndUBValueWith(string lowerBound, string upperBound)
        {
            VerificationInfo info = new VerificationInfo();
            if (ShouldVerifyTheSecondFeeStructurePropBetweenLBValueWith(lowerBound).Result && ShouldVerifyTheSecondFeeStructurePropBetweenUBValueWith(upperBound).Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = ShouldVerifyTheSecondFeeStructurePropBetweenLBValueWith(lowerBound).Actual + "-" + ShouldVerifyTheSecondFeeStructurePropBetweenUBValueWith(upperBound).Actual;
            return info;
        }

        public VerificationInfo ShouldVerifyTheThirdFeeStrPropBetweenLBAndUBValueWith(string lowerBound, string upperBound)
        {
            VerificationInfo info = new VerificationInfo();
            if (ShouldVerifyTheThirdFeeStructurePropBetweenLBValueWith(lowerBound).Result && ShouldVerifyTheThirdFeeStructurePropBetweenUBValueWith(upperBound).Result)
                info.Result = true;
            else
                info.Result = false;

            info.Actual = ShouldVerifyTheThirdFeeStructurePropBetweenLBValueWith(lowerBound).Actual + "-" + ShouldVerifyTheThirdFeeStructurePropBetweenUBValueWith(upperBound).Actual;
            return info;
        }
    }
}
