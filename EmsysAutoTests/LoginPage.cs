using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmsysAutoTests
{
    public class LoginPage
    {
        public  void GoTo()
        {
            //var driver = new FirefoxDriver();
            Driver.Instance.Navigate().GoToUrl("https://qa.emsys1.com/");
            Driver.Instance.Manage().Window.Maximize();
        }

        public LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
            }

    public class LoginCommand
    {
        private string password;
        private string userName;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("UserName"));
            loginInput.SendKeys(userName);
            var passwordInput = Driver.Instance.FindElement(By.Id("Password"));
            passwordInput.SendKeys(password);
            Thread.Sleep(30000);
            var loginButton = Driver.Instance.FindElement(By.Id("logon-login"));
            loginButton.Click();
        }
    }
}


