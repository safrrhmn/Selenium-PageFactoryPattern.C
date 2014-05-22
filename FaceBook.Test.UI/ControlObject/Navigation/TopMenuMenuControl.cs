

using FaceBook.Test.UI.ControlObject.Navigation.SubMenuNavigation;

namespace FaceBook.Test.UI.ControlObject.Navigation
{
    using PageObject;
    using OpenQA.Selenium;

    public class TopMenuMenuControl:BaseMenuControl
    {
        private readonly By _welcomePageSelector = By.CssSelector(".headerTinymanName");
        private readonly By _userPageSelector = By.CssSelector("[title='Timeline']");
        private readonly By _findFriendsPageSelector = By.Id("findFriendsNav");

        public TopMenuMenuControl(IWebDriver webDriver) : base(webDriver)
        {
//            UserPage = new UserPage(webDriver);
//            HomePage = new HomePage(webDriver);
//            WelcomePage = new WelcomePage(webDriver);
            PullDownSubMenusControl = new PullDownSubMenus(webDriver);


        }

        public PullDownSubMenus PullDownSubMenusControl { get; set; }

        public WelcomePage Welcome()
        {
            NavigateTo(_welcomePageSelector);
            return new WelcomePage(Driver);
        }

        public UserPage UserPage()
        {
            NavigateTo(_userPageSelector);
            return new UserPage(Driver);
        }


        public FindFriendsPage FindFriendsPage()
        {
            NavigateTo(_findFriendsPageSelector);
            return new FindFriendsPage(Driver);
        }
    }
}