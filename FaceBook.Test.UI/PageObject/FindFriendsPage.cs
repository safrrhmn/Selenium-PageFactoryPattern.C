namespace FaceBook.Test.UI.PageObject
{
	using System.Linq;
	using FaceBook.Test.UI.ControlObject;
	using FaceBook.Test.UI.DataObject;
	using FaceBook.Test.UI.Model;
	using OpenQA.Selenium;


    public class FindFriendsPage:BasePage
    {
        private static readonly By KnownElementOnPage = By.CssSelector(".uiHeaderTitle");
        private static readonly By InviteYourFriendsFieldSelector = By.Name("email_list");
        private static readonly By InviteFriendButtonSelector = By.CssSelector(".uiButton.uiButtonConfirm");
        public FindFriendsPage(IWebDriver webDriver) : base(webDriver, KnownElementOnPage)
        {

        }

        public FindFriendsPage InviteYourFriends(UserDetailModel model)
        {
          
			Driver.FindElement(InviteYourFriendsFieldSelector).SendKeys(model.InviteFriendEmail);
            Driver.FindElement(InviteFriendButtonSelector).Click();
			Driver.FindElement(By.CssSelector(".pam.uiOverlayFooter.uiBoxGray.topborder a")).Click();

            return this;
        }

    }
}