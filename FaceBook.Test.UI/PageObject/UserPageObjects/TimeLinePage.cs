namespace FaceBook.Test.UI.PageObject.UserPageObjects
{
    using OpenQA.Selenium;
    public class TimeLinePage:BasePage
    {
        public static readonly By TimeLinePageSelector = By.CssSelector("._6-6._6-7");
        public TimeLinePage(IWebDriver webDriver)
            : base(webDriver, TimeLinePageSelector)
        {

        }
    }
}