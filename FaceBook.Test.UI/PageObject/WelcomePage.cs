using FaceBook.Test.UI.ControlObject.Navigation;
using OpenQA.Selenium;

namespace FaceBook.Test.UI.PageObject
{
    public class WelcomePage:BasePage
    {
        private static readonly By KnownElementOnPage = By.CssSelector("[title='Welcome']");
        public WelcomePage(IWebDriver driver) : base(driver, KnownElementOnPage)
        {
            TopMenu = new TopMenuMenuControl(Driver);

        }

        public TopMenuMenuControl TopMenu { get; set; }
    }
}