using EmsysAutoTests;
using OpenQA.Selenium;

namespace EmsysTests
{
    public class DashboardPage
    {
        public static bool IsAt {
            get {
                var webCatalogueLink = Driver.Instance.FindElements(By.Id("showWebPartCatalogLink"));
                if (webCatalogueLink.Count > 0)
                    return webCatalogueLink[0].Text == "Customize Dashboard";
                return false;
                    }
        }
    }
}