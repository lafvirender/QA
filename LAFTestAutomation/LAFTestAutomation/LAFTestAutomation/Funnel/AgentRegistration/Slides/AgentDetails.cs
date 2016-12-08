using System;
using LAFTestAutomationFramework.Helpers;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace LAFTestAutomationFramework.Funnel.AgentRegistration.Slides
{
    public class AgentDetails
    {
        private readonly TestObject _aboutYouSlide;
        private readonly TestObject _agentFirstName;
        private readonly TestObject _agentLastName;
        private readonly TestObject _agentPhone;
        private readonly TestObject _agentMobile;
        private readonly TestObject _agentEmail;
        private readonly TestObject _agentPosition;  
        private readonly TestObject _next;
        private readonly TestObject _back;
        private readonly TestObject _agentPersonalDetailsQuestion;
        private readonly TestObject _errors;

        public AgentDetails(Browser browser, TestObjectProperties eltAboutYouSlide,
                                TestObjectProperties txtAgentFirstName,
                                TestObjectProperties txtAgentLastName, TestObjectProperties txtAgentPhone,
                                TestObjectProperties txtAgentMobile, TestObjectProperties txtAgentEmail,
                                TestObjectProperties lstAgentPosition, TestObjectProperties lnkNext,
                                TestObjectProperties lnkBack, TestObjectProperties EltAgentPersonalDetailsQuestion,
                                TestObjectProperties eltErrors)
        {
            _aboutYouSlide = new TestObject(browser, eltAboutYouSlide);
            _agentFirstName = new TestObject(browser, txtAgentFirstName);
            _agentLastName = new TestObject(browser, txtAgentLastName);
            _agentPhone = new TestObject(browser, txtAgentPhone);
            _agentMobile = new TestObject(browser, txtAgentMobile);
            _agentEmail = new TestObject(browser, txtAgentEmail);
            _agentPosition = new TestObject(browser, lstAgentPosition);
            _next = new TestObject(browser, lnkNext);
            _back = new TestObject(browser, lnkBack);
            _agentPersonalDetailsQuestion = new TestObject(browser, EltAgentPersonalDetailsQuestion);
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
            return _agentPersonalDetailsQuestion.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            VerificationInfo info = new VerificationInfo();
            if (_aboutYouSlide.WaitTillItsClassContainsActive())
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _aboutYouSlide.GetClassAttributeValue();
            return info;
        }

        public VerificationInfo ShouldVerifyErrorForAgentFirstNameField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (_agentFirstName.VerifyFieldError().Result
               && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _agentFirstName.VerifyFieldError().Actual + "-" + string.Join(",", _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToArray());
            return info;
        }

        public VerificationInfo ShouldVerifyErrorForAgentLastNameField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (_agentLastName.VerifyFieldError().Result
            && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _agentLastName.VerifyFieldError().Actual + "-" + string.Join(",", _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToArray());

            return info;
        }

        public VerificationInfo ShouldVerifyErrorAndMsgForAgentPhoneField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (_agentPhone.VerifyFieldError().Result
            && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _agentPhone.VerifyFieldError().Actual + "-" + string.Join(",", _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToArray());

            return info;
        }

        public VerificationInfo ShouldVerifyErrorForAgentPhoneField()
        {
            return _agentPhone.VerifyFieldError();  
        }

        public VerificationInfo ShouldVerifyErrorAndMsgForAgentMobileField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (_agentMobile.VerifyFieldError().Result
            && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _agentMobile.VerifyFieldError().Actual + "-" + string.Join(",", _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToArray());
            return info;
        }

        public VerificationInfo ShouldVerifyErrorForAgentMobileField()
        {
            return _agentMobile.VerifyFieldError();
        }

        public VerificationInfo ShouldVerifyErrorForAgentEmailField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (_agentEmail.VerifyFieldError().Result
                && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;


            info.Actual = _agentEmail.VerifyFieldError().Actual + "-" + string.Join(",", _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToArray());
            return info;
        }

        public VerificationInfo ShouldVerifyErrorForAgentPositionField(string errString)
        {
            VerificationInfo info = new VerificationInfo();
            if (_agentPosition.VerifyFieldError().Result
            && _errors.GetAListOfAllMatchingTestObjectsTextsValues().Contains(errString))
                info.Result = true;
            else
                info.Result = false;

            info.Actual = _agentPosition.VerifyFieldError().Actual + "-" + string.Join(",", _errors.GetAListOfAllMatchingTestObjectsTextsValues().ToArray());
            return info;
        }

        private void SetValueInAgentFirstNameAs(string fName)
        {
            if(!string.IsNullOrEmpty(fName))
            _agentFirstName.SendKeys(fName);
        }

        private void SetValueInAgentLastNameAs(string lName)
        {
            if (!string.IsNullOrEmpty(lName))
                _agentLastName.SendKeys(lName);
        }

        private void SetValueInAgentPhoneAs(string phone)
        {
            if (!string.IsNullOrEmpty(phone))
                _agentPhone.SendKeys(phone);
        }

        private void SetValueInAgentMobileAs(string mobile)
        {
            if (!string.IsNullOrEmpty(mobile))
                _agentMobile.SendKeys(mobile);
        }

        private void SetValueInAgentEmailAs(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                if (email == "randomize")
                {
                    string randomEmail = GetRandomEmail();
                    _agentEmail.SendKeys(randomEmail);
                }
                else
                    _agentEmail.SendKeys(email);
            }
        }

        public string GetRandomEmail()
        {
            StringBuilder builder = new StringBuilder();
            System.Random random = new System.Random();
            char ch;
            for (int i = 1; i < 8; i++)
            {
                ch = System.Convert.ToChar(System.Convert.ToInt32(System.Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            string email = builder.ToString() + "@test.com";
            return email;
        }

        private void SetValueInAgentPositionAs(string position)
        {
            if (!string.IsNullOrEmpty(position))
            {
                _agentPosition.Select(position);
            }
                
        }

        private void ClickNext()
        {
            _next.Click();
        }

        public void MoveBackToAgentInterestSection()
        {
            _back.Click();
        }

        public void EnterAgentDetailsAs(string firstName, string lastName, string phone, 
                                        string mobile, string email, string position)
        {
            SetValueInAgentFirstNameAs(firstName);
            SetValueInAgentLastNameAs(lastName);
            SetValueInAgentPhoneAs(phone);
            SetValueInAgentMobileAs(mobile);
            SetValueInAgentEmailAs(email);
            SetValueInAgentPositionAs(position);                
            ClickNext();
        }

        public VerificationInfo ShouldDisplayTheJobTitleValuesAs(IList<string> values)
        {
            IList<string> valuesDisplayedOnPage = _agentPosition.GetAllOptionsText();

            VerificationInfo info = new VerificationInfo();
            if (values.All(value => valuesDisplayedOnPage.Contains(value.Trim())))
                info.Result = true;
            else
                info.Result = false;
            info.Actual = string.Join(",", valuesDisplayedOnPage.ToArray());
            return info;
        }
    }
}
