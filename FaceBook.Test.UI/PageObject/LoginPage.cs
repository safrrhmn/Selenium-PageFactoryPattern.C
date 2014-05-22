using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaceBook.Test.UI.DataObject;
using FaceBook.Test.UI.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FaceBook.Test.UI.PageObject
{

    public class LoginPage:BasePage
    {
        private const string Url = "https://www.facebook.com";
        private static readonly By LoginButtonSelector = By.Id("loginbutton");
        private static readonly By EmailOrPhone = By.Id("email");
        private static readonly By Password = By.Id("pass");

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement Pass { get; set; }

        public LoginPage(IWebDriver webDriver) : 
            base(webDriver, LoginButtonSelector, Url)
        {
        }

        public void TypeEmailOrPhone(string emailOrPhone)
        {
            Email.SendKeys(emailOrPhone);
        }

        public void TypePassword(String passWord)
        {
            Pass.SendKeys(passWord);
        }

        public WelcomePage ClickLoginButton()
        {
            Driver.FindElement(LoginButtonSelector).Click();
            return new WelcomePage(Driver);
        }

        public WelcomePage LoginAs(UserDetailModel model)
        {
			TypeEmailOrPhone(model.UserLoginEmail);
			TypePassword(model.UserLoginPassword);
            ClickLoginButton();
            return new WelcomePage(Driver);
        }
    }
}
