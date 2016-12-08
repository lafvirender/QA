
using System;
using System.Collections.Generic;
using System.Configuration;
using LAFTestAutomationFramework.Helpers;
using System.Collections.Specialized;
using LAFTestAutomationFramework.Funnel.PropertyRegistration;
using LAFTestAutomationFramework.Funnel.AgentRegistration;
using LAFTestAutomationFramework.Funnel.AgentProposalForSell;
using LAFTestAutomationFramework.Funnel.AgentProposalForRent;

namespace LAFTestAutomationFramework.Pages
{
    public class BasePage
    {

        private Browser _browser;
        public HomePage HomePage;
        public PropertyRegistrationFunnel PropertyRegistrationFunnel;
        public AgentRegistrationFunnel AgentRegistrationFunnel;
        public AgentProposalForSellFunnel AgentProposalForSellFunnel;
        public AgentProposalForRentFunnel AgentProposalForRentFunnel;



        private Dictionary<string, string> _settings;

        public BasePage()
        {
         
        }


        public void InitializeBrowser(string hub)
        {
            _browser = new Browser(hub, _settings);
        }

        public void InitializePages()
        {
            HomePage = new HomePage(_browser);
            PropertyRegistrationFunnel = new PropertyRegistrationFunnel(_browser);
            AgentRegistrationFunnel = new AgentRegistrationFunnel(_browser);
            AgentProposalForSellFunnel = new AgentProposalForSellFunnel(_browser);
            AgentProposalForRentFunnel = new AgentProposalForRentFunnel(_browser);
        }

        public void ReadBrowserConfigurationFor(string settingsSectionName)
        {
            _settings = new Dictionary<string, string>();
            var sectionNamePath = "Browsers/" + settingsSectionName;
            var browserSettingsKeyValuePairColl= ConfigurationManager.GetSection(sectionNamePath) as NameValueCollection;
            if (browserSettingsKeyValuePairColl != null)
            {
                foreach (var settingKey in browserSettingsKeyValuePairColl.AllKeys)
                {
                    var value = browserSettingsKeyValuePairColl.Get(settingKey);
                    if (value != null)
                    {
                        _settings.Add(settingKey, value);
                    }
                }
            }
        }

        public void ShouldQuitTheBrowser()
        {
            _browser.Quit();
        }

        public void ShouldTakeMeToLAFHomePage()
        { 
           _browser.Navigate(ConfigurationManager.AppSettings.Get("LAFStagingURL"));
        }

        public void ShouldTakeMeToAddressAt(string url)
        {
            _browser.Navigate(url);
        }

        public void ShouldTakeMeToPropertyRegistrationFunnelStartSlide()
        {
            _browser.Navigate(ConfigurationManager.AppSettings.Get("LAFPropertyRegistrationPage_Ver31"));
            ShouldWaitForPropertyRegistrationFunnelStartSlideToLoad();
        }

        public void ShouldTakeMeToAgentRegistrationFunnelStartSlide()
        {
            _browser.Navigate(ConfigurationManager.AppSettings.Get("LAFAgentSignUp"));
            ShouldWaitForAgentRegistrationFunnelStartSlideToLoad();
        }

        private VerificationInfo ShouldWaitForAgentRegistrationFunnelStartSlideToLoad()
        {
            return AgentRegistrationFunnel.BeforeYouStart.IsDisplayed();
        }

        private VerificationInfo ShouldWaitForPropertyRegistrationFunnelStartSlideToLoad()
        {
            return PropertyRegistrationFunnel.IsDisplayed();
        }
        /* 
         * private static T GetPage<T>() where T : new()
         {
             var page = new T();
             return page;
         }

         public static HomePage HomePage
         {
             get { return GetPage<HomePage>(); }
         }
         *
         */
    }
}
