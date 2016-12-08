using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace LAFTestAutomationFramework.Helpers
{
    public class WaitFor
    {
        private IWebDriver _driver;
        private By _locator;
        public WaitFor(IWebDriver driver, By locator)
        {
            _driver = driver;
            _locator = locator;
        }

        public void ElementPresent()
        {
            WaitForElementPresent(15);
        }

        public void ElementDisplayed()
        {
            IWait<IWebDriver> wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(_locator));
            }
            catch (NoSuchElementException)
            {
            }
            catch (WebDriverTimeoutException)
            {
            }
        }

        public void ElementToBeClickable()
        {
            IWait<IWebDriver> wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(_locator));
            }
            catch (NoSuchElementException)
            {
            }
            catch (WebDriverTimeoutException)
            {
            }
        }

        public void SlideOptionToBecomeActive()
        {
            IWait<IWebDriver> wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(drv => drv.FindElement(_locator).GetAttribute("tabindex").Contains("0"));
            }
            catch (NoSuchElementException)
            {
            }
            catch (WebDriverTimeoutException)
            {
            }
        }

        public void ElementClassToContainActive()
        {
            IWait<IWebDriver> wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(drv => drv.FindElement(_locator).GetAttribute("class").Contains("active"));
            }
            catch (NoSuchElementException)
            {
            }
            catch (WebDriverTimeoutException)
            {
            }
        }

        private void WaitForElementPresent(int seconds)
        {
            IWait<IWebDriver> wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(seconds));
            try
            {
                wait.Until(ExpectedConditions.ElementExists(_locator));
            }
            catch (NoSuchElementException) { }
            catch (WebDriverTimeoutException) { }   
               
           
        }
    }
}
