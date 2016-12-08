using System;
using System.Drawing;
using LAFTestAutomationFramework.Helpers;

namespace LAFTestAutomationFramework.ApplicationBasedHelpers
{
    public class PostCode
    {
        private readonly TestObject _agencyName;
        private readonly TestObject _branch;
        private readonly TestObject _rentalsCategory;
        private readonly TestObject _salesCategory;
        private readonly TestObject _both;
        private readonly TestObject _postCode1;
        private readonly TestObject _postCode2;
        private readonly TestObject _postCode3;
        private readonly TestObject _postCode4;
        private readonly TestObject _postCode5;
        private readonly TestObject _next;

        public PostCode(Browser browser, TestObjectProperties txtAgencyName,
            TestObjectProperties txtBranchName, TestObjectProperties rbtnRentals,
            TestObjectProperties rbtnSales, TestObjectProperties rbtnBoth,
            TestObjectProperties txtAgentPostCode1, TestObjectProperties txtAgentPostCode2,
            TestObjectProperties txtAgentPostCode3, TestObjectProperties txtAgentPostCode4,
            TestObjectProperties txtAgentPostCode5, TestObjectProperties lnkNext)
        {
            _agencyName = new TestObject(browser, txtAgencyName);
            _branch = new TestObject(browser, txtBranchName);
            _rentalsCategory = new TestObject(browser, rbtnRentals);
            _salesCategory = new TestObject(browser, rbtnSales);
            _both = new TestObject(browser, rbtnBoth);
            _postCode1 = new TestObject(browser, txtAgentPostCode1);
            _postCode2 = new TestObject(browser, txtAgentPostCode2);
            _postCode3 = new TestObject(browser, txtAgentPostCode3);
            _postCode4 = new TestObject(browser, txtAgentPostCode4);
            _postCode5 = new TestObject(browser, txtAgentPostCode5);
            _next = new TestObject(browser, lnkNext);
        }


        public VerificationInfo ShouldVerifyErrorForAgencyNameField()
        {
            return _agencyName.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForBranchField()
        {
            return _branch.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForPostCode1Field()
        {
            return _postCode1.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForPostCode2Field()
        {
            return _postCode2.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForPostCode3Field()
        {
            return _postCode3.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForPostCode4Field()
        {
            return _postCode4.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForPostCode5Field()
        {
            return _postCode5.VerifyFieldError();
        }

        private void SetValueInAgencyNameAs(string agencyName)
        {
            if (!string.IsNullOrEmpty(agencyName))
                _agencyName.SendKeys(agencyName);
        }

        private void SetValueInBranchAs(string branch)
        {
            if (!string.IsNullOrEmpty(branch))
                _branch.SendKeys(branch);
        }

        private void SetValueInPostCode1As(string postCode1)
        {
            if (!string.IsNullOrEmpty(postCode1))
                _postCode1.SendKeys(postCode1);
        }

        private void SetValueInPostCode2As(string postCode2)
        {
            if (!string.IsNullOrEmpty(postCode2))
                _postCode2.SendKeys(postCode2);
        }

        private void SetValueInPostCode3As(string postCode3)
        {
            if (!string.IsNullOrEmpty(postCode3))
                _postCode3.SendKeys(postCode3);
        }

        private void SetValueInPostCode4As(string postCode4)
        {
            if (!string.IsNullOrEmpty(postCode4))
                _postCode4.SendKeys(postCode4);
        }

        private void SetValueInPostCode5As(string postCode5)
        {
            if (!string.IsNullOrEmpty(postCode5))
                _postCode4.SendKeys(postCode5);
        }

        private void SelectTheInterestedInCategory(string category)
        {
            switch (category)
            {
                case "Rentals":
                    SelectRentals();
                    break;

                case "Sales":
                    SelectSales();
                    break;

                case "Both":
                    SelectBoth();
                    break;
            }
        }

        private void SelectRentals()
        {
            _rentalsCategory.Click();
        }

        private void SelectSales()
        {
            _salesCategory.Click();
        }

        private void SelectBoth()
        {
            _both.Click();
        }

        private void ClickNext()
        {
            _next.Click();
        }

        private void SetValueInPostCodesAs(string postCodes)
        {
            var arr = postCodes.Split(',');
            try
            {
                if (!string.IsNullOrEmpty(arr[0]))
                    _postCode1.SendKeys(arr[0]);

                if (!string.IsNullOrEmpty(arr[1]))
                    _postCode2.SendKeys(arr[1]);

                if (!string.IsNullOrEmpty(arr[2]))
                    _postCode3.SendKeys(arr[2]);

                if (!string.IsNullOrEmpty(arr[3]))
                    _postCode4.SendKeys(arr[3]);

                if (!string.IsNullOrEmpty(arr[4]))
                    _postCode5.SendKeys(arr[4]);

            }
            catch (IndexOutOfRangeException)
            {
                
            }
           
        }
        public void EnterAgencyDetailsAs(string agencyName, string branch, string interestedIn,
                                         string postCodes)
        {
            SetValueInAgencyNameAs(agencyName);
            SetValueInBranchAs(branch);
            SelectTheInterestedInCategory(interestedIn);
            SetValueInPostCodesAs(postCodes);
            ClickNext();
        }
    }
}
