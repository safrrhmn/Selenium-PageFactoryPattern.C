using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaceBook.Test.UI.PageObject;
using OpenQA.Selenium;

namespace FaceBook.Test.UI.ControlObject.Navigation.SubMenuNavigation
{
    public class PullDownSubMenus:BaseMenuControl
    {

        private static readonly By PullDownSubMenuSelector = By.Id("userNavigationLabel");
        private static readonly By CareerPageMenuSelector = By.LinkText("Careers");

        public PullDownSubMenus(IWebDriver webDriver) : base(webDriver)
        {
//            CreatePage = new CreatePage(webDriver);
//            Advertising = new Advertising(webDriver);
//            ActivityLog = new ActivityLog(webDriver);
//            SubMenuSettings = new SubMenuSettings(webDriver);
//            LogOut = new LogOut(webDriver);
//            Careers = new Careers(webDriver);
//            SubMenuHelp = new SubMenuHelp(webDriver);
//            ReportAProblem = new ReportAProblem(webDriver);

        }

        public CareersPage CareersPage()
        {
            NavigateToSubMenu(PullDownSubMenuSelector, CareerPageMenuSelector);
            return new CareersPage(Driver);
        }


//        public ReportAProblem ReportAProblem { get; set; }
//
//        public SubMenuHelp SubMenuHelp { get; set; }
//
//        public Careers Careers { get; set; }
//
//        public LogOut LogOut { get; set; }
//
//        public SubMenuSettings SubMenuSettings { get; set; }
//
//        public Advertising Advertising { get; set; }
//
//        public ActivityLog ActivityLog { get; set; }
//
//        public CreatePage CreatePage { get; set; }



    }
}
