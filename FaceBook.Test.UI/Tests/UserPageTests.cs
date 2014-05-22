using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaceBook.Test.UI.DataObject;
using FaceBook.Test.UI.PageObject;
using NUnit.Framework;

namespace FaceBook.Test.UI.Tests
{
	[TestFixture(Browser.Chrome)]
	[TestFixture(Browser.Firefox)]
	[TestFixture(Browser.InternetExplorer)]
    [TestFixture]
    class UserPageTests:BaseTestFixtures
    {
        private WelcomePage _welcomePage;
        public UserPageTests(BaseTestFixtures.Browser browser): base(browser)
        {

        }

        [TestFixtureSetUp]
        public void SetUpTest()
        {
            _welcomePage = new LoginPage(Driver).LoginAs(PersonData.ValidUserData());

        }

        [Test]
        public void SubmitUserStatusSucess()
        {
            Assert.IsNotNull(
                _welcomePage.TopMenu.UserPage().WriteAndPostStatus("Test post using selenium driver on 5/9/2014"));

        }


        [Test]
        public void PostAndDeleteStatuSucess()
        {
            Assert.IsNotNull(_welcomePage.TopMenu.UserPage().WriteAndPostStatus("This test post will be deleted").DeleteStatus());
        }




    }
}
