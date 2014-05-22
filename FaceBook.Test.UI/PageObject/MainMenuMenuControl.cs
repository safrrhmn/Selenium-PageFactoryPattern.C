using FaceBook.Test.UI.ControlObject;
using FaceBook.Test.UI.ControlObject.Navigation;
using OpenQA.Selenium;

namespace FaceBook.Test.UI.PageObject
{
    /// <summary>
    /// This class represents the main header controlss navigation for logged in users
    /// </summary>

    public class MainMenuMenuControl:BaseMenuControl
    {
        public MainMenuMenuControl(IWebDriver webDriver) : base(webDriver)
        {
            UserPage = new UserPage(webDriver);
            HomePage = new HomePage(webDriver);
            FindFriendsPage = new FindFriendsPage(webDriver);
            FriendRequest = new FriendRequest(webDriver);
            Inbox = new Inbox(webDriver);
            Notifications = new Notifications(webDriver);
            Settings = new Settings(webDriver);
            TopMenuMenuControl = new TopMenuMenuControl(webDriver);

        }

        public TopMenuMenuControl TopMenuMenuControl { get; set; }

        public Settings Settings { get; set; }

        public Notifications Notifications { get; set; }

        public Inbox Inbox { get; set; }

        public FriendRequest FriendRequest { get; set; }

        public FindFriendsPage FindFriendsPage { get; set; }

        public HomePage HomePage { get; set; }

        public UserPage UserPage { get; set; }



    }
}
