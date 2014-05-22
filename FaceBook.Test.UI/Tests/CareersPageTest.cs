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
//    [TestFixture(Browser.Chrome)]
    [TestFixture(Browser.Firefox)]
//    [TestFixture(Browser.InternetExplorer)]
    class CareersPageTest:BaseTestFixtures
    {
        private CareersPage _careersPage;
        public CareersPageTest(Browser browser) : base(browser)
        {
        }

        [TestFixtureSetUp]
        public void SetUpTest()
        {
            _careersPage =
                new LoginPage(Driver).LoginAs(PersonData.ValidUserData())
                    .TopMenu.PullDownSubMenusControl.CareersPage();
        }

        [Test]
        public void SearchJobSuccess()
        {
            Assert.IsNotNull(_careersPage.SearchJob("QA Tester"));

        }


    }
}
