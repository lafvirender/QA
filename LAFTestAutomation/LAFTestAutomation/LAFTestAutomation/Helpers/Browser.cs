using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using  OpenQA.Selenium.Remote;
using System.Collections.Generic;

namespace LAFTestAutomationFramework.Helpers
{
    public class Browser
    {
        private IWebDriver _instance;
        private readonly RemoteWebDriver _remoteInstance;

        public Browser(string browserName)
        {
            InitializeBrowser(browserName);
        }

        public Browser(string hub, Dictionary<string,string> browserSettings)
        {
            DesiredCapabilities capabilities = GetCapabilitiesFor(browserSettings["browserName"]);
            foreach (var settingKeyValuePair in browserSettings)
            {
                capabilities.SetCapability(settingKeyValuePair.Key, settingKeyValuePair.Value);
            }

            if (hub != "")
            {
                _remoteInstance = new RemoteWebDriver(new Uri(hub), capabilities);
            }
            else
            {
                InitializeBrowser(browserSettings["browserName"]);
            }
            Maximize();
        }

        public IWebDriver GetInstance()
        {
            return _instance ?? _remoteInstance;
        }

        private DesiredCapabilities GetCapabilitiesFor(string browserName)
        {
            switch (browserName)
            {
                case "internet explorer":
                    return DesiredCapabilities.InternetExplorer();

                case "chrome":
                    return DesiredCapabilities.Chrome();

                case "firefox":
                    return DesiredCapabilities.Firefox();

                default:
                    return null;
            }
        }

        private void InitializeBrowser(string browserName)
        {
            
            switch (browserName)
            {
                case "internet explorer":
                    _instance = new InternetExplorerDriver();
                    break;

                case "chrome":
                    _instance = new ChromeDriver();
                    break;

                case "firefox":
                    _instance = new FirefoxDriver();
                    break;

                default:
                    _instance = new InternetExplorerDriver();
                    break;
            }
        }

        public void Navigate(string url)
        {
            GetInstance().Navigate().GoToUrl(url);
        }

        public void Quit()
        {
            GetInstance().Quit();
        }

        public void Close()
        {
            GetInstance().Close();
        }

        public string CurrentWindowHandle { get { return GetInstance().CurrentWindowHandle; } }
        public string PageSource { get { return GetInstance().PageSource; } }
        public string Title { get { return GetInstance().Title; } }
        public string Url { get { return GetInstance().Url; } }
        public IList<string> WindowHandles { get { return GetInstance().WindowHandles; } }

        public void Maximize()
        {
            GetInstance().Manage().Window.Maximize();
        }

        public void SwitchToAlert()
        {
            GetInstance().SwitchTo().Alert();
        }

        public void SwitchToFrame(int frameIndex)
        {
            GetInstance().SwitchTo().Frame(frameIndex);
        }

        public void SwitchToWindow(string windowName)
        {
            GetInstance().SwitchTo().Window(windowName);
        }
    }
}
