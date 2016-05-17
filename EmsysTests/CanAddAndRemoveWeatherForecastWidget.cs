using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmsysAutoTests;

namespace EmsysTests
{
    [TestClass]
    public class CanAddAndRemoveWeatherForecastWidget
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void AddAndRemoveWeatherForecastWidget()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.GoTo();
            loginPage.LoginAs("dkovpak").WithPassword("dkovpak1").Login();
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");

            //DashboardPage.GoTo();
            DashboardPage dashboardPage = new DashboardPage();

            dashboardPage.OpenWebCatalogue();
            dashboardPage.ClickAddWeatherForecast();
            Assert.IsTrue(DashboardPage.WidgetIsAdded, "Failed to add WeatherForecastWidget");
            //DashboardPage.RemoveWeatherForecastWidget();
            //Assert.IsTrue(DashboardPage.WidgetIsRemoved, "Failed to remove WeatherForecastWidget");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
