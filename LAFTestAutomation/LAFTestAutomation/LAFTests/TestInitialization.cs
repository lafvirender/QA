using System.Configuration;
using LAFTestAutomationFramework.Pages;

namespace LAFTests
{
    public class TestInitialization
    {
        public BasePage BasePage;

        public TestInitialization(BasePage basePage, string testSettingsName)
        {
            BasePage = basePage;
            BasePage.ReadBrowserConfigurationFor(testSettingsName);
            BasePage.InitializeBrowser(ConfigurationManager.AppSettings.Get("Hub"));
            BasePage.InitializePages();
            BasePage.ShouldTakeMeToLAFHomePage();
        }

  

    }
}
