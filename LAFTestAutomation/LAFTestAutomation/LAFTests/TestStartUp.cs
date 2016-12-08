using System;
using BoDi;
using TechTalk.SpecFlow;
using LAFTestAutomationFramework.Pages;

namespace LAFTests
{
   [Binding]
    public class TestStartUp
    {
        private readonly IObjectContainer _objectContainer;
        private BasePage _basePage;

        public TestStartUp(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void SetUp()
        {
            _basePage = new BasePage();
            _objectContainer.RegisterInstanceAs<BasePage>(_basePage);
        }

        [AfterScenario]
        public void TearDown()
        {
            _basePage.ShouldQuitTheBrowser();
        }
    }
    
}
