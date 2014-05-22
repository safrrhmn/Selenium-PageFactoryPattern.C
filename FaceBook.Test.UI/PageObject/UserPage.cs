using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using FaceBook.Test.UI.ControlObject;
using FaceBook.Test.UI.ControlObject.Navigation.UserPageNavigations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace FaceBook.Test.UI.PageObject
{
    public class UserPage:BasePage
    {
        private static readonly By KnownElementOnPage = By.CssSelector(".uiIconText._51z7");
        private static readonly By StatusTextAreaBoxSelector = By.CssSelector("[aria-label=\"What's on your mind?\"]");
        private static readonly By PostButtonSelector = By.CssSelector("._42ft._4jy0._11b._4jy3._4jy1.selected");
        private static readonly By StatusOptionDropDownSelector = By.CssSelector("[aria-label='Options for this story']");
        private static readonly By StatusDeleteButtonSelector = By.LinkText("Delete...");


        public UserPage(IWebDriver webDriver) : base(webDriver, KnownElementOnPage)
        {

        }

        public UserPageTopNavigationMenu UserPageTopNavigationMenu { get; set; }

        public UserPage WriteAndPostStatus(string status)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until((ExpectedConditions.ElementExists(StatusTextAreaBoxSelector)));

            Driver.FindElement(StatusTextAreaBoxSelector).Clear();
            Driver.FindElement(StatusTextAreaBoxSelector).SendKeys(status + " " + DateTime.Now);
            Driver.FindElement(PostButtonSelector).Click();
            Thread.Sleep(10); //Temprorary 
            return this;
        }
        

        public UserPage DeleteStatus()
        {
            Driver.FindElements(StatusOptionDropDownSelector)[0].Click();

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until((ExpectedConditions.ElementExists(StatusDeleteButtonSelector)));

            Driver.FindElement(StatusDeleteButtonSelector).Click();

            Driver.SwitchTo().Window(Driver.WindowHandles.LastOrDefault());
            Driver.FindElement(By.Name("Delete")).Click();

            return this;
        }
    }
}