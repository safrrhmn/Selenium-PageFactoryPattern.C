using FaceBook.Test.UI.DataObject;
using FaceBook.Test.UI.PageObject;
using NUnit.Framework;

namespace FaceBook.Test.UI.Tests
{
	[TestFixture(Browser.Chrome)]
	[TestFixture(Browser.Firefox)]
	[TestFixture(Browser.InternetExplorer)]
	internal class FindFriendPageTest : BaseTestFixtures
	{
		private FindFriendsPage _findFriendsPage;

		public FindFriendPageTest(Browser browser) : base(browser)
		{
		}

		[TestFixtureSetUp]
		public void SetupTest()
		{
			_findFriendsPage = new LoginPage(Driver).LoginAs(PersonData.ValidUserData()).TopMenu.FindFriendsPage();
		}

		[Test]
		public void FindFriendsSucess()
		{
			Assert.IsNotNull(_findFriendsPage.InviteYourFriends(PersonData.ValidUserData()));
		}
	}
}