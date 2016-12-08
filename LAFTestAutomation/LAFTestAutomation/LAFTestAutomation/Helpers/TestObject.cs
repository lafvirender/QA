using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Drawing;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
using OpenQA.Selenium.Support.UI;

namespace LAFTestAutomationFramework.Helpers
{
    public class TestObject
    {
        private readonly IWebDriver _driver;
        private readonly Browser _browser;
        private readonly By _locator;
        WaitFor WaitFor;

        public TestObject(Browser browser, TestObjectProperties toProp)
        {
            _browser = browser;
            _driver = browser.GetInstance();
            _locator = GetLocator(toProp);
            WaitFor = new WaitFor(_driver, _locator);
        }

        private IWebElement GetAutomationElement()
        {
            WaitFor.ElementDisplayed();
            try
            {
                //focus(_driver.FindElement(_locator));
                return _driver.FindElement(_locator);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public VerificationInfo VerifyDisplayStyleWith(string displayValue)
        {
            VerificationInfo info = new VerificationInfo();
            string script = "var element = arguments[0];";
            script += "return element.style.display;";

            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            string displayStyle = js.ExecuteScript(script, GetAutomationElement()).ToString();

            info.Expected = displayValue;
            info.Actual = displayStyle;
            if (displayStyle.Contains(displayValue))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private IList<IWebElement> GetAutomationElements()
        {
            WaitFor.ElementDisplayed();
            return _driver.FindElements(_locator);
        }

        public void scrollToViewElement()
        {
            string script = "var element = arguments[0];";
            script += "element.scrollIntoView();";

            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript(script, GetAutomationElement());
        }

        private void focus(IWebElement element)
        {
            string script = "var element = arguments[0];";
            script += "window.focus();";
            script += "return element.focus();";

            IJavaScriptExecutor js = (IJavaScriptExecutor) _driver;
            js.ExecuteScript(script, element);
        }

        private IWebElement GetChildAutomationElementMatchingWith(TestObjectProperties toProp)
        {
            try
            {
                return GetAutomationElement().FindElement(GetLocator(toProp));
            }
            catch (NoSuchElementException)
            {
            }
            return null;
        }

        public bool WaitTillItsClassContainsActive()
        {
            WaitFor.ElementClassToContainActive();
            if (GetAutomationElement().GetAttribute("class").Contains("active"))
                return true;
            else
                return false;
        }

        public bool WaitForSlideOptionToBecomeActive()
        {
            WaitFor.SlideOptionToBecomeActive();
            if (GetAutomationElement().GetAttribute("tabindex").Contains("0"))
                return true;
            else
                return false;
        }


        public bool IsDisplayed()
        {
            if (GetAutomationElement()!=null)
                return GetAutomationElement().Displayed;
            else
                return false;
        }

        public bool IsEnabled()
        {
            if (GetAutomationElement() != null)
                return GetAutomationElement().Enabled;
            else
                return false;
        }

        public Point GetLocation()
        {
            return GetAutomationElement().Location;
        }

        public bool IsSelected()
        {
            return GetAutomationElement().Selected;
        }

        public Size GetSize()
        {
            return GetAutomationElement().Size;
        }

        public string GetTagName()
        {
            return GetAutomationElement().TagName;
        }

        public string GetText()
        {
            if (GetAutomationElement() != null)
            {
                HighlightElement();
                return GetAutomationElement().Text;
            }
            else
                return "error";
        }

        public string GetFieldValue()
        {
            HighlightElement();
            return GetAutomationElement().GetAttribute("value");
        }

        public void Click()
        {
            WaitFor.ElementToBeClickable();
            GetAutomationElement().Click();
        }

        public void SimulateDOMClick()
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].click();", GetAutomationElement());
        }


        public void Clear()
        {
            GetAutomationElement().Clear();
        }

        public string GetAttribute(string attName)
        {
            return GetAutomationElement().GetAttribute(attName);
        }

        public string GetCssValue(string propName)
        {
            return GetAutomationElement().GetCssValue(propName);
        }

        public void SendKeys(string value)
        {
            Clear();
            GetAutomationElement().SendKeys(value);
        }

        public void Submit()
        {
            GetAutomationElement().Submit();
        }

        public void Select(string sValue)
        {
            SelectElement element = new SelectElement(GetAutomationElement());
            element.SelectByText(sValue);
        }

        public string GetSelectedValue()
        {
            SelectElement element = new SelectElement(GetAutomationElement());
            return element.SelectedOption.Text;
        }

        private IList<TestObject> GetAllMatchingTestObjects()
        {
            IList<TestObject> testObjectList = new List<TestObject>();
            foreach (var element in GetAutomationElements())
            {
                TestObjectProperties testObjectProp = new TestObjectProperties(Locator.XPath, getXPathTo(element));
                testObjectList.Add(new TestObject(_browser,testObjectProp));
            }
              
            return testObjectList;
        }

        public int GetAllMatchingTestObjectsCount()
        {
            return GetAutomationElements().Count;
        }

        public IList<string> GetAllOptionsText()
        {
            IList<string> options = new List<string>();

            SelectElement selElement = new SelectElement(GetAutomationElement());

            foreach(IWebElement optionElt in selElement.Options)
            {
                options.Add(optionElt.Text);
            }
            return options;
        }

        public void SelectTheOneMatchingToText(string sText)
        {
            foreach (var testObject in GetAllMatchingTestObjects())
            {
                if (testObject.GetText() == sText)
                {
                    testObject.GetInputChildObject().Click();
                }
            }
             
        }

        private TestObject GetInputChildObject()
        {
            TestObjectProperties inputObjectProp = new TestObjectProperties(Locator.TagName, "input");

            TestObjectProperties childObjectProps = new TestObjectProperties(Locator.XPath, 
                                                getXPathTo(GetChildAutomationElementMatchingWith(inputObjectProp)));
            return new TestObject(_browser, childObjectProps);

        }

        public IList<string> GetAListOfAllMatchingTestObjectsTextsValues()
        {
            IList<string> textList = new List<string>();
            foreach (var testObject in GetAllMatchingTestObjects())
            {
                textList.Add(testObject.GetText());
            }

            return textList;
        }

        public void SelectMatchingItemNumber(int listItemNumber)
        {
            GetAllMatchingTestObjects()[listItemNumber-1].Click();
        }

        public IList<string> GetAListOfAllMatchingTestObjectsTitleValues()
        {
            IList<string> textList = new List<string>();
            foreach (var testObject in GetAllMatchingTestObjects())
            {
                textList.Add(testObject.GetAttribute("title"));
            }

            return textList;
        }


        public override string ToString()
        {
            return GetAutomationElement().ToString();
        }

        public void HighlightElement()
        {
            for (int i = 0; i < 2; i++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", GetAutomationElement(), "border: 2px solid red;");
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", GetAutomationElement(), "");
            }

        }


        public string getXPathTo(IWebElement element)
        {
            string script = "function getPathTo(element){";
            script += "if (element.tagName == 'HTML')";
            script += "return '/HTML[1]';";
            script += "if (element === document.body)";
            script += " return '/HTML[1]/BODY[1]';";
            script += "var index = 0;";
            script += "var siblings = element.parentNode.childNodes;";
            script += "for (var i = 0; i < siblings.length; i++){";
            script += "var sibling = siblings[i];";
            script += "if (sibling === element)";
            script += "return getPathTo(element.parentNode) + '/' + element.tagName + '[' + (index + 1) + ']';";
            script += "if (sibling.nodeType === 1 && sibling.tagName === element.tagName)";
            script += "index++;}}";
            script += "return getPathTo(arguments[0]);";


            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            return js.ExecuteScript(script, element).ToString();
        }


        private static By GetLocator(TestObjectProperties toProp)
        {
            switch (toProp.LocateBy)
            {
                case Locator.Id:
                    return By.Id(toProp.Value);

                case Locator.LinkText:
                    return By.LinkText(toProp.Value);

                case Locator.XPath:
                    return By.XPath(toProp.Value);

                case Locator.Name:
                    return By.Name(toProp.Value);

                case Locator.PartialLinkText:
                    return By.PartialLinkText(toProp.Value);

                case Locator.TagName:
                    return By.TagName(toProp.Value);

                case Locator.CssSelector:
                    return By.CssSelector(toProp.Value);

                case Locator.ClassName:
                    return By.ClassName(toProp.Value);

                default:
                    return null;
            }
        }

        private string GetHexValueOfColor(string rgbString)
        {
            string[] arr;
            if (rgbString.Contains("rgba"))
                arr = rgbString.Replace("rgba(", "").Replace(")", "").Split(',');
            else
                arr = rgbString.Replace("rgb(", "").Replace(")", "").Split(',');


            if (arr.Length < 3) return "";
            var r = int.Parse(arr[0].Trim()).ToString("X2");
            var g = int.Parse(arr[1].Trim()).ToString("X2");
            var b = int.Parse(arr[2].Trim()).ToString("X2");
            return "#" + r + g + b;
        }

        public string GetBackgroundColorHexValue()
        {
            var color = GetAutomationElement().GetCssValue("background-color");
            return color.StartsWith("#") ? color : GetHexValueOfColor(color);
        }

        public string GetBorderBottomColorHexValue()
        {
            var color = GetAutomationElement().GetCssValue("border-bottom-color");
            return color.StartsWith("#") ? color : GetHexValueOfColor(color);
        }

        public VerificationInfo VerifyFieldError()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "#ec0928";
            info.Actual = GetBorderColorHexValue();
            if (GetBorderColorHexValue().Equals("#ec0928", StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo VerifyColorForActive()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "#16B24D";
            info.Actual = GetBorderColorHexValue();
            if (GetBorderColorHexValue().Equals("#16B24D", StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo VerifyAgentRegProgressCircleColorForActive()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "#14B24B";
            info.Actual = GetBorderColorHexValue();
            if (GetBorderColorHexValue().Equals("#14B24B", StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo VerifyPropRegProgressLine()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "#16B24D";
            info.Actual = GetBorderBottomColorHexValue();
            if (GetBorderColorHexValue().Equals("#16B24D", StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo VerifyAgentRegProgressLine()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "#14B24B";
            info.Actual = GetBorderBottomColorHexValue();
            if (GetBorderColorHexValue().Equals("#14B24B", StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo VerifyPropRegProgressCircleForActive()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "#16B24D";
            info.Actual = GetBackgroundColorHexValue();
            if (GetBorderColorHexValue().Equals("#16B24D", StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo VerifyAgentRegProgressCircleForActive()
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = "#14B24B";
            info.Actual = GetBackgroundColorHexValue();
            if (GetBackgroundColorHexValue().Equals("#14B24B", StringComparison.OrdinalIgnoreCase))
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private string GetBorderColorHexValue()
        {
            var color = GetAutomationElement().GetCssValue("border-color");
            return color.StartsWith("#") ? color : GetHexValueOfColor(color);
        }

        private string GetTestObjectColorHexValue()
        {
            var color = GetAutomationElement().GetCssValue("color");
            return color.StartsWith("#") ? color : GetHexValueOfColor(color);
        }

        public string GetClassAttributeValue()
        {
            return GetAutomationElement().GetAttribute("class");
        }

    }
}
