
using LAFTestAutomationFramework.Helpers;
using LAFTestAutomationFramework.UIMap;

namespace LAFTestAutomationFramework.Pages
{
    public class HomePage: HomePageUIMap
    {
        private readonly TestObject _getStarted;

        public HomePage(Browser browser): base()
        {
            _getStarted = new TestObject(browser, LnkGetStarted);
        }

        public bool IsDisplayed()
        {
            return _getStarted.IsDisplayed();
        }

        public void ClickGetStarted()
        {
            _getStarted.Click();
        }
    }
}
