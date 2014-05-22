using OpenQA.Selenium;

namespace FaceBook.Test.UI.PageObject
{
    public class SearchJobResultPage:BasePage
    {
        private static readonly By KnownElementOnPage = By.CssSelector(".careersSubPageSubTitle._3ma._6n._6s._6v");
        public SearchJobResultPage(IWebDriver driver) : base(driver, KnownElementOnPage)
        {
            
        }
    }
}