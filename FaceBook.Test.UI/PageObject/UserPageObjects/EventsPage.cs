using System;
using OpenQA.Selenium;

namespace FaceBook.Test.UI.PageObject.UserPageObjects
{
    public class EventsPage:BasePage
    {
        private static readonly By EventsPageSelector = By.Id("medley_header_events");
        private static readonly By CreateEventButtonSelector = By.CssSelector("._42ft._4jy0._4-rs._4-rt._4jy4._517h");
        private static readonly By EventNameSelector = By.Name("u_3a_3");

        private static readonly By CreateButtonSelector =
            By.CssSelector("._42ft._4jy0.layerConfirm.createButtonFromCreateDialog.uiOverlayButton._4jy3._4jy1.selected");
        public EventsPage(IWebDriver webDriver)
            : base(webDriver, EventsPageSelector)
        {

        }

        public EventDetailPage CreateEvent()
        {
            Driver.FindElement(CreateEventButtonSelector).Click();

            Driver.FindElement(EventNameSelector).SendKeys("This Event Was Created at: " + DateTime.Now);

            Driver.FindElement(CreateButtonSelector).Click();

            return new EventDetailPage(Driver);
        }
    }
}