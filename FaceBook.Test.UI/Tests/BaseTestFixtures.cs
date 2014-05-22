using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace FaceBook.Test.UI.Tests
{
    /// <summary>
    /// To select browser type to run the test on
    /// </summary>
  public class BaseTestFixtures
    {
        protected IWebDriver Driver;

        public enum Browser
        {
            Chrome,
            Firefox,
            InternetExplorer,
        }

        public BaseTestFixtures(Browser browser)
        {
            Driver = GetWebDriver(browser);
        }

        [TestFixtureTearDown]
        public void BaseTestFixtureTearDownTest()
        {
            Driver.Quit();
        }

        private IWebDriver GetWebDriver(Browser browser)
        {
            Driver = null;
            switch (browser)

            {
                case Browser.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case Browser.Firefox:
                    Driver = new FirefoxDriver();
                    break;
                case Browser.InternetExplorer:
                    Driver = new InternetExplorerDriver();
                    break;
            }
            return Driver;
        }
    }
}
