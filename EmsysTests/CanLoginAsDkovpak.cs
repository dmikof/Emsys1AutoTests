using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmsysAutoTests;

namespace EmsysTests
{
    [TestClass]
    public class CanLoginAsDkovpak
    {
        [TestMethod]
        public void LoginAsDkovpak()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("admin").WithPassword("password").Login();
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }
    }
}
