

namespace FaceBook.Test.UI.ControlObject
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Use for Base Navigation and generic driver
    /// </summary>
    /// 
    
   public class BaseMenuControl   
    {
        public BaseMenuControl(IWebDriver webDriver)
        {
            Driver = webDriver;

        }

        public IWebDriver Driver { get; set; }

        protected void NavigateTo(By manuSelector)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementExists(manuSelector));
            Driver.FindElement(manuSelector).Click();

        }

        protected void NavigateToSubMenu(By pullDownSubMenuSelector, By pullDownPageMenuSelector)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementExists(pullDownSubMenuSelector));
            Driver.FindElement(pullDownSubMenuSelector).Click();

            wait.Until(ExpectedConditions.ElementExists(pullDownPageMenuSelector));
            Driver.FindElement(pullDownPageMenuSelector).Click();
        }


    }
}
