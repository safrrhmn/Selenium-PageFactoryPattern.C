using FaceBook.Test.UI.ControlObject;
using OpenQA.Selenium;

namespace FaceBook.Test.UI.PageObject
{
    
    public class CareersPage:BasePage
    {

        private static readonly By KnownElementOnPage = By.CssSelector(".careersHomePageTitle._3ma._6n._7g._6v");
        private static readonly By SearchFieldSelector = By.CssSelector("[value='Search Jobs']");
        private static readonly By SearchButtonSelector = By.CssSelector("[title='Search Jobs']");

        public CareersPage(IWebDriver webDriver) : base(webDriver, KnownElementOnPage)
        {

        }

        public SearchJobResultPage SearchJob(string job)
        {
            Driver.FindElement(SearchFieldSelector).Clear();
            Driver.FindElement(SearchFieldSelector).SendKeys(job);
            Driver.FindElement(SearchButtonSelector).Click();
            return new SearchJobResultPage(Driver);
        }
    }
}