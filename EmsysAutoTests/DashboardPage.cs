using System;
using EmsysAutoTests;
using OpenQA.Selenium;

namespace EmsysTests
{
    public class DashboardPage

    {
        public static bool WidgetIsAdded {
        get {
                var widgets = Driver.Instance.FindElements(By.CssSelector(".weather"));
                if (widgets.Count > 0)
                    return widgets[0].Text == "Weather Forecast";
                return false; 
                    }
        }
        public static bool WidgetIsRemoved;

        public static bool IsAt {
            get {
                var webCatalogueLink = Driver.Instance.FindElements(By.Id("showWebPartCatalogLink"));
                if (webCatalogueLink.Count > 0)
                    return webCatalogueLink[0].Text == "Customize Dashboard";
                return false;
                    }
        }

     /*   public static void GoTo()
        {
            throw new NotImplementedException();
        } */

        public static void OpenWebCatalogue()
        {
            var CustomizeDashboardLink = Driver.Instance.FindElement(By.Id("showWebPartCatalogLink"));
            CustomizeDashboardLink.Click();
        }

        public static void ClickAddWeatherForecast()
        {
            var AddWeatherForecastButton = Driver.Instance.FindElement(By.XPath(".//*[@id='WebPartCatalog']/form/div/table/tbody/tr[5]/td[1]/button"));
            AddWeatherForecastButton.Click();
        }

      /*  public static void RemoveWeatherForecastWidget()
        {
            throw new NotImplementedException();
        } */
    }
}