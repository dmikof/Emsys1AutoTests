﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmsysAutoTests;

namespace EmsysTests
{
    [TestClass]
    public class CanLoginAsDkovpak
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
                    }

        [TestMethod]
        public void LoginAsDkovpak()
        {   LoginPage loginPage = new LoginPage();
            loginPage.GoTo();
            loginPage.LoginAs("admin").WithPassword("password").Login();
          //  Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }
    }
}
