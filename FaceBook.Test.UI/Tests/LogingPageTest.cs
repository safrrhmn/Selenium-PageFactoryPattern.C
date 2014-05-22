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
    public class LogingPageTest:BaseTestFixtures
    {
        public LogingPageTest(Browser browser) : base(browser)
        {

        }

        [TestFixtureSetUp]
        public void SetUpTest()
        {
           // new LoginPage(Driver);
        }

        [Test]
        public void LogingWithValidCredentialSucess()
        {
            var homePage = new LoginPage(Driver).LoginAs(PersonData.ValidUserData());
            Assert.IsNotNull(homePage);
        }
    }
}
