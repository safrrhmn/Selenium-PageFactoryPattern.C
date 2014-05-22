using FaceBook.Test.UI.DataObject;
using FaceBook.Test.UI.PageObject;
using FaceBook.Test.UI.PageObject.UserPageObjects;
using NUnit.Framework;

namespace FaceBook.Test.UI.Tests
{
    [TestFixture(Browser.Chrome)]
    [TestFixture(Browser.Firefox)]
    [TestFixture(Browser.InternetExplorer)]
    class EventPageTests : BaseTestFixtures
    {
        private EventsPage _eventPage;
        public EventPageTests(Browser browser)
            : base(browser)
        {
        }

        [TestFixtureSetUp]
        public void SetUpTest()
        {
            _eventPage =
                new LoginPage(Driver).LoginAs(PersonData.ValidUserData())
                    .TopMenu.UserPage()
                    .UserPageTopNavigationMenu.EventsPage();
        }

        [Test]
        public void CreateEventSuccess()
        {

            Assert.IsNotNull(_eventPage.CreateEvent());
        }


    }
}
