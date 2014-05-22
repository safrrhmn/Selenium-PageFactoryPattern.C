using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaceBook.Test.UI.ControlObject.Navigation;
using OpenQA.Selenium;

namespace FaceBook.Test.UI.PageObject
{
    class BaseMainMenuPage:BasePage
    {
        public BaseMainMenuPage(IWebDriver webDriver, By knownElementOnPage, string loadUrl = "") : base(webDriver, knownElementOnPage, loadUrl)
        {
            TopTopMenuMenu = new TopMenuMenuControl(Driver);

        }

        public BaseMainMenuPage(IWebDriver webDriver, string expectedTitle = "", string loadUrl = "") : base(webDriver, expectedTitle, loadUrl)
        {
            TopTopMenuMenu = new TopMenuMenuControl(Driver);
        }

        public TopMenuMenuControl TopTopMenuMenu { get; set; }
    }
}
