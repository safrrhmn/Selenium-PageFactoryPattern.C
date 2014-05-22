using FaceBook.Test.UI.PageObject.UserPageObjects;
using OpenQA.Selenium;

namespace FaceBook.Test.UI.ControlObject.Navigation.UserPageNavigations
{
	public class UserPageTopNavigationMenu:BaseMenuControl
	{
		public readonly By TimeLinePageSelector = By.CssSelector("._6-6._6-7");
		public readonly By AboutPageSelector = By.CssSelector("[data-medley-id='pagelet_timeline_medley_about']");
		public readonly By PhotoPageSelector = By.CssSelector("[data-medley-id='pagelet_timeline_medley_photos']");
		public readonly By FriendsPageSelector = By.CssSelector("[data-medley-id='pagelet_timeline_medley_friends']");
		public readonly By MoreMenuSelector = By.Id("u_jsonp_4_2");
	    public readonly By EventsPageSelector = By.LinkText("Events");
		public UserPageTopNavigationMenu(IWebDriver webDriver) : base(webDriver)
		{

		}

        public TimeLinePage TimeLinePage()
	    {
            NavigateTo(TimeLinePageSelector);

            return new TimeLinePage(Driver);
	    }

	    public EventsPage EventsPage()
	    {
            NavigateToSubMenu(MoreMenuSelector,EventsPageSelector);

            return  new EventsPage(Driver);
	    }

	}
}
