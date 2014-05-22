using System;
using OpenQA.Selenium;

namespace FaceBook.Test.UI.PageObject.UserPageObjects
{
    public class EventDetailPage:BasePage
    {
        private static readonly By EventDetailPageSelector = By.Id("fbCoverImageContainer");
        public EventDetailPage(IWebDriver driver):base(driver,EventDetailPageSelector)
        {
            
        }
    }
}