using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace FaceBook.Test.UI.PageObject
{
    /// <summary>
    /// This class should contains comon methods for every page.
    /// </summary>
    public class BasePage
    {
        public BasePage(IWebDriver webDriver, By knownElementOnPage, String loadUrl = "")
        {
            Driver = webDriver;
            GoToUrl(loadUrl);

            Driver.Manage().Window.Maximize();
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(knownElementOnPage));

            FindElementOnPage(knownElementOnPage);
            PageFactory.InitElements(Driver, this);

        }

        public BasePage(IWebDriver webDriver, String expectedTitle = "", string loadUrl = "")
        {
            Driver = webDriver;
            GoToUrl(loadUrl);

            if (expectedTitle.ToLower() != Title.ToLower())
            {
                var stopWatch = Stopwatch.StartNew();
                var msgOut = String.Format("Expectd page {0}, actual page {1}", expectedTitle, Title);
                throw new NoSuchElementException();

            }

        }

        public string Title
            {
                get{return Driver.Title;}
            }
            

        private void FindElementOnPage(By knownElementOnPage)
        {
            Driver.FindElement(knownElementOnPage);
        }

        private void GoToUrl(string loadUrl)
        {
            if (loadUrl != string.Empty)
            {
                Driver.Navigate().GoToUrl(loadUrl);
            }
        }

        public IWebDriver Driver { get; set; }


        public IAlert Alert()
        {
            return Driver.SwitchTo().Alert();
        }

    }


}
